using BalProject;
using DalProject;
using System.Web.Http;
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

            AdminBal ba1 = new AdminBal();
            ba1.AdminId = ba.AdminId;
            ba1.AdminPassword = ba.AdminPassword;
            LoginDal ds = new LoginDal();
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

            CustomerLoginBal bal = new CustomerLoginBal();
            LoginDal dal = new LoginDal();
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
        [HttpPost]
        public IHttpActionResult ForgotPassword(CustomerLoginModel cust)
        {
            CustomerLoginBal bal = new CustomerLoginBal();
            bal.EmailId = cust.EmailId;
            bal.Password = cust.Password;
            LoginDal dal = new LoginDal();
            dal.ForgotPassword(bal);
            return Ok(new { status = 200, isSuccess = true, message = "Password updated Successfully" });

        }
    }
}