using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class DepositController : ApiController
    {
        // PUT api/<controller>/5
        [HttpPut]
        public IEnumerable<spDeposit_Result> Put(int idAccount, string concept, string reference, decimal amount)
        {
            List<spDeposit_Result> result = new List<spDeposit_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                result = entities.spDeposit(idAccount, concept, reference, amount).ToList();
            }

            return result;
        }
    }
}