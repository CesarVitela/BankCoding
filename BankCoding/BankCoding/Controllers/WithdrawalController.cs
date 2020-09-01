using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class WithdrawalController : ApiController
    {
        // PUT api/<controller>/5
        [HttpPut]
        public IEnumerable<spWithdrawal_Result> Put(int idAccount, decimal amount)
        {
            List<spWithdrawal_Result> result = new List<spWithdrawal_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                result = entities.spWithdrawal(idAccount, amount).ToList();
            }

            return result;
        }
    }
}