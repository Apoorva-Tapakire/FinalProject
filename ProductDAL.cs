using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalLibrary;

namespace DalLibrary
{
    public class ProductDAL
    {

        public string AddProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_InsertProduct]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_name", ba.ProductName);
            cmd.Parameters.AddWithValue("@p_actualprice", ba.ActualPrice);
            cmd.Parameters.AddWithValue("@p_discount", ba.Discount);
            cmd.Parameters.AddWithValue("@p_quantity", ba.Quantity);
            cmd.Parameters.AddWithValue("@p_description", ba.Description);
            cmd.Parameters.AddWithValue("@p_image", ba.Image);
            cmd.Parameters.AddWithValue("@p_catid", ba.CategoryId);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "your product added";
            
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        public string DeleteProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_deleteProduct]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_pid", ba.ProductId);
           
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "your product deleted";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        public string UpdateProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_UpdateProduct]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_pid", ba.ProductId);
            cmd.Parameters.AddWithValue("@p_name", ba.ProductName);
            cmd.Parameters.AddWithValue("@p_actualprice", ba.ActualPrice);
            cmd.Parameters.AddWithValue("@p_discount", ba.Discount);
            cmd.Parameters.AddWithValue("@p_quantity", ba.Quantity);
            cmd.Parameters.AddWithValue("@p_description", ba.Description);
            cmd.Parameters.AddWithValue("@p_image", ba.Image);
            cmd.Parameters.AddWithValue("@p_catid", ba.CategoryId);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "your product updated";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        




        
            public List<ProductBAL> showProduct()
            {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            SqlCommand cmd = new SqlCommand("select * from  ProductDescription", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<ProductBAL> prodlist = new List<ProductBAL>();
                while (dr.Read())
                {
                    ProductBAL c = new ProductBAL();
                    c.ProductId = Convert.ToInt32(dr[0]);
                    c.ProductName = dr[1].ToString();
                    c.ActualPrice = Convert.ToInt32(dr[2]);
                    c.Discount = Convert.ToInt32(dr[3]);
                    c.Quantity = Convert.ToInt32(dr[4]);
                    c.Description = dr[5].ToString();
                   

                byte[] photoArray = new byte[64];
                    try
                    {
                        photoArray = (byte[])dr[6];// image was converted here
                        MemoryStream stream = new MemoryStream(photoArray);
                        c.Image = stream.ToArray();
                    }
                    catch (Exception ex)
                    {

                        Array.Clear(photoArray, 0, photoArray.Length);
                    }


                c.CategoryId = Convert.ToInt32(dr[7]);

                //byte[] photoArray = (byte[])dr[2];// image was converted here
                //MemoryStream stream = new MemoryStream(photoArray);
                //c.Picture = stream.ToArray();
                prodlist.Add(c);
                }
                cn.Close();
                return prodlist;

            }
            
        }
    }




                    

