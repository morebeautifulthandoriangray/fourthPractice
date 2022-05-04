using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _4Practice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> list = new List<Customer>();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("select * from Customers", con);
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Customer c = new Customer();
                    c.Id = (int) r["Id"];
                    c.Name = r["Name"].ToString();
                    c.Surname = r["Surname"].ToString();
                    c.YearOfBirth = (int) r["YearOfBirth"];
                    list.Add(c);
                }
            }

            return list;
        }

        public List<Order> GetOrders(int id)
        {
            List<Order> list = new List<Order>();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("select * from Orders where IdCust = @id", con);
                com.Parameters.Add(new SqlParameter("@id", id));
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Order or = new Order();
                    or.Id = (int)r["Id"];
                    or.Title = r["Title"].ToString();
                    or.IdCust = (int)r["IdCust"];
                    or.Price = (int)r["Price"];
                    or.Quantity = (int)r["Quantity"];
                    list.Add(or);
                }
            }

            return list;
        }
    }
}
