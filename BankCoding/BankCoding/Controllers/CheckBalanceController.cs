using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class CheckBalanceController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<spCheckBalance_Result> Get(int idAccount)
        {
            List<spCheckBalance_Result> result = new List<spCheckBalance_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                result = entities.spCheckBalance(idAccount).ToList();
            }
            return result;
        }
    }
}