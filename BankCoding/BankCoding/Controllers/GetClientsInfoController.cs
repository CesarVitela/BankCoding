using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class GetClientsInfoController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<spGetClientsInfo_Result> Get()
        {
            List<spGetClientsInfo_Result> result = new List<spGetClientsInfo_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                result = entities.spGetClientsInfo().ToList();
            }

            return result;
        }
    }
}