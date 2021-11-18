using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BalLibrary;
using DalLibrary;
using System.Web.Http.Cors;
using ProjectWebApplication.Models;

namespace ProjectWebApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {

        public string Get()
        {
            return "value";
        }

        [HttpPost]
        public IHttpActionResult AdminLogin(AdminModel ba)
        {

            AdminBAL ba1 = new AdminBAL();
            ba1.AdminId = ba.AdminId;
            ba1.AdminPassword = ba.AdminPassword;
            LoginDAL ds = new LoginDAL();
            bool ans = ds.ValidateAdmin(ba1);
            if (ans == false)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid user", });

            }
            else
            {
                return Ok(new { status = 200, isSuccess = true, message = "valid user" });

            }

        }

        [HttpPost]
        public IHttpActionResult CustomerLogin(CustomerLoginModel cust)
        {

            CustomerLoginBAL bal = new CustomerLoginBAL();
            LoginDAL dal = new LoginDAL();

            bal.EmailId = cust.EmailId;
            bal.Password = cust.Password;
            bool ans = dal.ValidateCustomer(bal);
            if (ans == false)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid user", });
            }
            else
            {
                return Ok(new { status = 200, isSuccess = true, message = "valid user" });
            }
        }




    }
}