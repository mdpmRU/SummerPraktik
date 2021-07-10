using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; 
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseProject
{
    public partial class WarehouseF : Form
    {
        public class Order
        {
            public int OrderCode { get; set; }
            public int ItemCode { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }
            public string Address { get; set; }
            public int Quantity { get; set; }
            public string Email { get; set; }
            public bool Status { get; set; }
            public string Order_date { get; set; }
        }
        
        private const string APP_PATH = " https://localhost:44359";
        public int id = 0;
        public WarehouseF()
        {
            InitializeComponent();

    }

        private void btnBD_Click(object sender, EventArgs e)//Вывод бд
        {

            var client = new HttpClient();
            var response = client.GetAsync(APP_PATH + "/api/Order").Result;
            string msg = response.Content.ReadAsStringAsync().Result;
            List<Order> order = (List<Order>)Newtonsoft.Json.JsonConvert.DeserializeObject(msg, typeof(List<Order>));
                dGVWarehouse.Rows.Clear();
                dGVWarehouse.Columns[0].HeaderText = "Код товара";
                dGVWarehouse.Columns[1].HeaderText = "Код пункта";
                dGVWarehouse.Columns[2].HeaderText = "Имя";
                dGVWarehouse.Columns[3].HeaderText = "Фамилия";
                dGVWarehouse.Columns[4].HeaderText = "Отчество";
                dGVWarehouse.Columns[5].HeaderText = "Адрес";
                dGVWarehouse.Columns[6].HeaderText = "Количество";
                dGVWarehouse.Columns[7].HeaderText = "Email";
                dGVWarehouse.Columns[8].HeaderText = "Статус";
                dGVWarehouse.Columns[9].HeaderText = "Дата заказа";


            for (int i = 0; i < order.Count(); i++)
            {
                   dGVWarehouse.Rows.Add();
                   dGVWarehouse[0, i].Value = order[i].OrderCode;
                   dGVWarehouse[1, i].Value = order[i].ItemCode.ToString();
                   dGVWarehouse[2, i].Value = order[i].FirstName.ToString();
                   dGVWarehouse[3, i].Value = order[i].LastName.ToString();
                   dGVWarehouse[4, i].Value = order[i].MiddleName.ToString();
                   dGVWarehouse[5, i].Value = order[i].Address.ToString();
                   dGVWarehouse[6, i].Value = order[i].Quantity;
                   dGVWarehouse[7, i].Value = order[i].Email.ToString();
                   dGVWarehouse[8, i].Value = order[i].Status;
                   dGVWarehouse[9, i].Value = order[i].Order_date.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            

        }

        private async void Btn_Ed_Click(object sender, EventArgs e)
        {
            bool change = true;
            int id = Convert.ToInt32(tb_oc.Text);
            Order order = new Order { OrderCode = id,//6
                ItemCode = 1,
//                FirstName = "TestNerabotaet ",
                LastName = "RAzzzzzz",
                MiddleName = "Nedrug",
                Address = "Смоленск Кутузова6",
                    Quantity = 1,
                   Email = "dada@gmail.com",
                   Status = change,
                  Order_date = "14.08.2021"
            };
            var client = new HttpClient();
            var json_object = JsonConvert.SerializeObject(order);
            HttpContent content = new StringContent(json_object.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage result = await client.PutAsync(APP_PATH + "/api/Order/" + id, content);
            if (result.IsSuccessStatusCode)
            {
                var response = result.StatusCode.ToString();
                MessageBox.Show("Удачно");
            }
            else { MessageBox.Show("Неудачно"); }




        }
    }
}
