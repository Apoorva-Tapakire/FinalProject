using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectWebApplication.Models;
using BalLibrary;
using DalLibrary;

namespace ProjectWebApplication.Controllers
{
    public class ProductController : ApiController
    {
        public string Get()
        {
            return "value";
        }



        [HttpPost]
        public IHttpActionResult ProductInsert(ProductModel prod)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductName = prod.ProductName;
            ba.ActualPrice = prod.ActualPrice;
            ba.Discount = prod.Discount;
            ba.Quantity = prod.Quantity;
            ba.Description = prod.Description;
            ba.Image = prod.Image;
            ba.CategoryId = prod.CategoryId;

            string s1 = ds.AddProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur logged sucess", });

        }


        [HttpDelete]
        public IHttpActionResult ProductDelete(ProductModel prod1)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductId = prod1.ProductId;
            string s1 = ds.DeleteProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur product deleted", });
        }



        [HttpPost]
        public IHttpActionResult ProductUpdate(ProductModel prod2)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductId = prod2.ProductId;
            ba.ProductName = prod2.ProductName;
            ba.ActualPrice = prod2.ActualPrice;
            ba.Discount = prod2.Discount;
            ba.Quantity = prod2.Quantity;
            ba.Description = prod2.Description;
            ba.Image = prod2.Image;
            ba.CategoryId = prod2.CategoryId;

            string s1 = ds.UpdateProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur product updated", });
        }


       
        
            [HttpGet]
            public List<ProductModel> showProduct()
        {
                ProductDAL dal = new ProductDAL();

                List<ProductBAL> prodlist = new List<ProductBAL>();

                prodlist = dal.showProduct();
                List<ProductModel> catmodel = new List<ProductModel>();
                foreach (var item in prodlist)
                {
                   ProductModel ca = new ProductModel();
                ca.ProductId = item.ProductId;
                ca.ProductName = item.ProductName;
                ca.ActualPrice = item.ActualPrice;
                ca.Discount = item.Discount;
                ca.Quantity = item.Quantity;
                ca.Description = item.Description;
                ca.Image = item.Image;
                ca.CategoryId = item.CategoryId;

                catmodel.Add(ca);

            }
            return catmodel;
}
            
        }
    }







