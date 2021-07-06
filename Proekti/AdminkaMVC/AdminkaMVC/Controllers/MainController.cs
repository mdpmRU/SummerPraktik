using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminkaMVC.Models;//Добавила Самойлова
using Microsoft.EntityFrameworkCore;//
using Microsoft.AspNetCore.Mvc.Rendering;//Херня для редактирования

namespace AdminkaMVC.Controllers
{
    public class MainController : Controller
    {
        ApplicationContext db;
        public MainController(ApplicationContext context)
        {
            db = context;
        }
        // GET: ProductController
        public ActionResult Select_Product()
        {
            // получение
            var prod = db.TableTovar.ToList();
            return View(prod);
        }
        //Заказ
        public ActionResult Create_Order(int id)
        {
            Tovar prod = db.TableTovar.Find(id); // Нашли выбранный продукт
            ViewBag.choice = prod.Name; //Сохранили его имя, выбранное клиентом
            ViewBag.id = prod.ItemCode;//ID товара
            ViewBag.date_order = DateTime.Now.ToShortDateString();//Дата текущая 
            return View();
        }
        [HttpPost]
        public ActionResult Create_Order(Order ord)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order
                {
                    OrderCode = ord.OrderCode,
                    ItemCode = ord.ItemCode,
                    FirstName = ord.FirstName,
                    LastName = ord.LastName,
                    MiddleName = ord.MiddleName,
                    Address = ord.Address,
                    Quantity = ord.Quantity,
                    Email = ord.Email,
                    Status = ord.Status,
                    Order_date = ord.Order_date
                };
                db.TableOrder.Add(order);
                db.SaveChanges();
                //Реализация минуса
                Tovar prod = db.TableTovar.Find(ord.ItemCode); // выбранный продукт             
                prod.Balance = prod.Balance - ord.Quantity;
                db.Entry(prod).State = EntityState.Modified;
                db.SaveChanges();
                //Конец  реализации минуса

                return RedirectToAction("Select_Product");
            }
            return View(ord);

        }
        //Редактирование и  удаление
        public ActionResult Edit(int id)
        {
            Tovar prod = db.TableTovar.Find(id); // выбранный продукт
            ViewBag.id = prod.ItemCode;
            ViewBag.comp = prod.Company;
            ViewBag.choice = prod.Name; //Сохранили его имя
            ViewBag.desc = prod.Description;//
            ViewBag.pr = prod.Price;
            ViewBag.bal = prod.Balance;
            ViewBag.img = prod.Image;//
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Tovar p)
        {
            if (ModelState.IsValid)
            {
                Tovar product = new Tovar
                {
                    ItemCode = p.ItemCode,
                    Company = p.Company,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Balance = p.Balance,
                    Image = p.Image,
                };
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Select_Product");
            }
            return View();
        }
        public ActionResult Minus(Tovar p, int Count)
        {
            if (ModelState.IsValid)
            {
                Tovar product = new Tovar
                {
                    ItemCode = p.ItemCode,
                    Company = p.Company,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Balance = p.Balance - Count,
                    Image = p.Image,
                };
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View();  
        }
        public ActionResult Delete(int id)
        {
            Tovar product = db.TableTovar.Find(id); // Нашли выбранный продукт
            db.TableTovar.Remove(product);   //LINQ - удаляем
            db.SaveChanges();
            return RedirectToAction("Select_Product");//увидим результат 

        }
        //

        //Выше вставить редактирование и удаление заказов
        //Пилим фильтрацию заказов
        public ActionResult Filter_Order(string Name_Product)
        //Name - при первом запуске пуст, при выборе клиента - имя выбранного продукта 
        {//Формируем список наименований продуктов
            var NameLst = new List<string>();
            var query_name = from d in db.TableOrder
                             orderby d.Order_date
                             select d.Order_date;
            NameLst.AddRange(query_name.Distinct());
            ViewBag.Name_Product = new SelectList(NameLst);
            // Формируем полный список заказов
            var query_order = from m in db.TableOrder select m;
            // При первом пуске выводим все заказы
            if (string.IsNullOrEmpty(Name_Product))
                return View(query_order);
            else //При выборе клиента выводим только заказы на указанный продукт
            {
                return View(query_order.Where(x => x.Order_date == Name_Product));
            }
        }
        public ActionResult Filter_Order_Quantity(int Name_Product)
        //Name - при первом запуске пуст, при выборе клиента - имя выбранного продукта 
        {//Формируем список наименований продуктов
            var NameLst = new List<int>();
            var query_name = from d in db.TableTovar
                             orderby d.Balance
                             select d.Balance;
            NameLst.AddRange(query_name.Distinct());
            ViewBag.Name_Product = new SelectList(NameLst);
            // Формируем полный список заказов
            var query_order = from m in db.TableTovar select m;
            // При первом пуске выводим все заказы
                return View(query_order);

        }

        //ниже код для редактирования товара
        //удаление заказа
        public ActionResult Delete_Order(int id)
        {
            Order order = db.TableOrder.Find(id); // Нашли выбранный продукт
            db.TableOrder.Remove(order);   //LINQ - удаляем
            db.SaveChanges();
            return RedirectToAction("Filter_Order");//work

        }
        //редактирование заказа
        public ActionResult Edit_Order(int id)
        {
            Order ord = db.TableOrder.Find(id); // выбранный продукт
            ViewBag.id = ord.OrderCode;
            ViewBag.tov = ord.ItemCode;
            ViewBag.fname = ord.FirstName;
            ViewBag.lname = ord.LastName;
            ViewBag.mname = ord.MiddleName;
            ViewBag.adr = ord.Address;
            ViewBag.quant = ord.Quantity;
            ViewBag.email = ord.Email;
            ViewBag.status = ord.Status;
            ViewBag.date = ord.Order_date;
            return View();
        }
        [HttpPost]
        public ActionResult Edit_Order(Order p)
        {
            if (ModelState.IsValid)
            {
                Order orde = new Order
                {
                    OrderCode = p.OrderCode,
                    ItemCode = p.ItemCode,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    MiddleName = p.MiddleName,
                    Address = p.Address,
                    Quantity = p.Quantity,
                    Email = p.Email,
                    Status = p.Status,
                    Order_date = p.Order_date,

                };
                db.Entry(orde).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Filter_Order");
            }
            return View();
        }


    }
}
