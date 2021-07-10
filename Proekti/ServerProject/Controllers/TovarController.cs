using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerProject.Models;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerProject.Controllers
{

    [Route("api/[controller]")]

    [ApiController]

    public class TovarController : ControllerBase

    {

        String connectionString = @"Data Source=DESKTOP-AML9JQ1\SQLEXPRESS;Initial Catalog=IntMag;Integrated Security=True";

        // GET: api/Tovar

        [HttpGet]

        public List<Tovar> Get()

        {

            List<Tovar> prod = new List<Tovar>(); ;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))

            {

                sqlConnection.Open();

                SqlCommand sqlCmd = new SqlCommand("Select * from TableTovar", sqlConnection);

                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())

                {

                    prod.Add(new Tovar() { ItemCode = reader.GetInt32(0), Company = reader.GetString(1).Trim(), Name = reader.GetString(2).Trim(), 
                        Description = reader.GetString(3).Trim(), Price = reader.GetInt32(4), Balance = reader.GetInt32(5), Image = reader.GetString(6).Trim()});

                }

                sqlConnection.Close();

            }

            return prod;

        }

    }

}