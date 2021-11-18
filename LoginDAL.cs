using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BalLibrary;

namespace DalLibrary
{
    public class LoginDAL
    {

        public bool ValidateAdmin(AdminBAL ba)
        {

            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true; Database=OnlineShopping");
            string s = "Select[dbo].[AdminLoginFunction](@p_aid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_aid", ba.AdminId);
            cmd.Parameters.AddWithValue("@p_pwd", ba.AdminPassword);
            cn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            bool ans = true;
            if (Convert.ToInt32(rdr[0]) == 1)
            {
                ans = true;
            }
            else
            {

                ans = false;
            }
            cn.Close();
            cn.Dispose();
            return ans;
        }




        public bool ValidateCustomer(CustomerLoginBAL ba)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;Initial Catalog=OnlineShopping");
            string s = "Select[dbo].[CustomerLoginFunction](@p_uid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_uid", ba.EmailId);
            cmd.Parameters.AddWithValue("@p_pwd", ba.Password);
            cn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            bool ans;
            if (Convert.ToInt32(rdr[0]) == 1)
            {
                ans = true;
            }
            else
            {
                ans = false;
            }
            cn.Close();
            cn.Dispose();
            return ans;
        }





        
    }
}