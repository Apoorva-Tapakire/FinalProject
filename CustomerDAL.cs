using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalLibrary;


namespace DalLibrary
{
    public class CustomerDAL
    {
        public string AddCustomer(CustomerBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[p_InsertCustomer]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_firstname", ba.FirstName);
            cmd.Parameters.AddWithValue("@p_lastname", ba.LastName);
            cmd.Parameters.AddWithValue("@p_emailId", ba.EmailId);
            cmd.Parameters.AddWithValue("@p_password", ba.Password);
            cmd.Parameters.AddWithValue("@p_MobileNos", ba.MobileNo);
            cmd.Parameters.AddWithValue("@p_city", ba.City);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "u are welcome";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }
    }
}
