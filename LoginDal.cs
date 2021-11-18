using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalProject;

namespace DalProject
{
    public class LoginDal
    {
        public bool ValidateAdmin(AdminBal dal)
        {
            SqlConnection cn = new SqlConnection("Data Source=desktop-7gh9mjq\\sqlexpress;Integrated Security=true;Initial Catalog=OnlineShopping");
            string s = "Select[dbo].[AdminLoginFunction](@p_aid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_aid", dal.AdminId);
            cmd.Parameters.AddWithValue("@p_pwd", dal.AdminPassword);
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
        public bool ValidateCustomer(CustomerLoginBal ba)
        {
            SqlConnection cn = new SqlConnection("Data Source=desktop-7gh9mjq\\sqlexpress;Integrated Security=true;Initial Catalog=OnlineShopping");
            string s = "Select[dbo].[CustomerLoginFunction](@p_aid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_aid", ba.EmailId);
            cmd.Parameters.AddWithValue("@p_pwd", ba.Password);
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
        public void ForgotPassword(CustomerLoginBal bal)
        {

            SqlConnection cn = new SqlConnection("Data Source=desktop-7gh9mjq\\sqlexpress;Integrated Security=true;Initial Catalog=OnlineShopping");
            string s = "[dbo].[ForgotPassword]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_EmailId", bal.EmailId);
            cmd.Parameters.AddWithValue("@p_password", bal.Password);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }
    }
}
