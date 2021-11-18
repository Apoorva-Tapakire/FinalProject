using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectWebApplication.Models;
using System.Web.Http.Cors;
using BalProject;
using DalProject;

namespace ProjectWebApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PaymentController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PaymentAdd(PaymentModel pay)
        {
            PaymentBal bal = new PaymentBal();
            bal.CardNo = pay.CardNo;
            bal.BankName = pay.BankName;
            bal.CVVNo = pay.CVVNo;
            bal.IFSCCode = pay.IFSCCode;
            bal.UPINo = pay.UPINo;
            PaymentDal dal = new PaymentDal();
            dal.PaymentMethod(bal);
            return Ok(new { status = 200, isSuccess = true, message = "valid user" });
        }
    }
}
