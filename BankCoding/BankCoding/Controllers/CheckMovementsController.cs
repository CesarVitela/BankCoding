﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankCoding.Models;

namespace BankCoding.Controllers
{
    public class CheckMovementsController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<spCheckMovements_Result> Get(int idAccount)
        {
            List<spCheckMovements_Result> result = new List<spCheckMovements_Result>();

            using (dbBankCodingEntities entities = new dbBankCodingEntities())
            {
                result = entities.spCheckMovements(idAccount).ToList();
            }
            return result;
        }
    }
}