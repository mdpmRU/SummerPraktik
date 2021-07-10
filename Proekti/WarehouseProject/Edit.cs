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

    public partial class Edit : Form
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

        public Edit()
        {
            InitializeComponent();
        }

        private void Ed_load(object sender, EventArgs e)
        {



        }

        private void Btn_Vivod_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_oc.Text);
            var client = new HttpClient();
            var response = client.GetAsync(APP_PATH + "/api/Order/" + id).Result;
            string msg = response.Content.ReadAsStringAsync().Result;
        }

        private void Btn_Ed_Click(object sender, EventArgs e)
        {

        }
    }
}
