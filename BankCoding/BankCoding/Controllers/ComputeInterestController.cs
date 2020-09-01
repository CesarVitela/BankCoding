using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class ComputeInterestController : ApiController
    {
        // PUT api/<controller>/5
        [HttpPut]
        public IEnumerable<spGetReturnCode_Result> Put()
        {
            int intResult = 0;
            List<spGetReturnCode_Result> result = new List<spGetReturnCode_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                intResult = entities.spComputeInterest();

                if (intResult > 0)
                {
                    result = entities.spGetReturnCode("001").ToList();
                }
                else
                {
                    result = entities.spGetReturnCode("999").ToList();
                }
            }

            return result;
        }
    }
}