using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class TransferController : ApiController
    {
        // PUT api/<controller>/5
        [HttpPut]
        public IEnumerable<spTransfer_Result> Put(int idAccount, string concept, string reference, decimal amount, int idAccountTransfer)
        {
            List<spTransfer_Result> result = new List<spTransfer_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                result = entities.spTransfer(idAccount, concept, reference, amount, idAccountTransfer).ToList();
            }

            return result;
        }
    }
}