using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerProject.Models;
using System.Data.SqlClient;
using System.Collections;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerProject.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public OrderController(ApplicationContext context)
        {
            _context = context;
        }
        //https://localhost:44306/api/Order
        [HttpGet]
        public IEnumerable GetAll()
        {
            return _context.TableOrder.ToList();
        }
        //https://localhost:44359/api/Order/2
        [HttpGet("{oc}", Name = "GetOrder")]
        public IActionResult GetById(int oc)
        {
            var item = _context.TableOrder.FirstOrDefault(t => t.OrderCode == oc);//Первый или по-умолчанию
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        //https://localhost:44359/api/Order
        [HttpPost]
        public IActionResult Create([FromBody] Order item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            Order order = new Order { 
                OrderCode = item.OrderCode,
                ItemCode= item.ItemCode,
                FirstName = item.FirstName,
                LastName = item.LastName,
                MiddleName = item.MiddleName,
                Address= item.Address,
                Quantity = item.Quantity,
                Email = item.Email,
                Status = item.Status,
                Order_date= item.Order_date
            };
            _context.TableOrder.Add(order);
            _context.SaveChanges();
            return new NoContentResult();
        }
        //https://localhost:44359/api/Order/4
        [HttpPut("{oc}")]
        public IActionResult Update(long oc, [FromBody] Order item)
        {
            if (item == null || item.OrderCode != oc)
            {
                return BadRequest();
            }
            var order = _context.TableOrder.FirstOrDefault(t => t.OrderCode == oc);
            if (order == null)
            {
                return NotFound();
            }
            order.OrderCode = item.OrderCode;
//            order.ItemCode = item.ItemCode;
//            order.FirstName = item.FirstName;
//            order.LastName = item.LastName;
//            order.MiddleName = item.MiddleName;
//            order.Address = item.Address;
//            order.Quantity = item.Quantity;
//            order.Email = item.Email;
            order.Status = item.Status;
//            order.Order_date = item.Order_date;
            _context.TableOrder.Update(order);
            _context.SaveChanges();

            return new NoContentResult();
        }
        //https://localhost:44359/api/Order/10
        [HttpDelete("{oc}")]
        public IActionResult Delete(long oc)
        {
            var order = _context.TableOrder.FirstOrDefault(t => t.OrderCode == oc);
            if (order == null)
            {
                return NotFound();
            }

            _context.TableOrder.Remove(order);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}