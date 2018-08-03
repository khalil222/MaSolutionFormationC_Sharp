using BankingApp.L2.Business.Facade;
using BankingApp.L2.Business.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingApp.L3.Service.API.Controllers
{
    public class ConsutationCompteController : ApiController
    {
        private IComptesBusiness business=new CompteBusinessImpl();
        // GET api/values
        public decimal  Get(string numero)
        {
            return business.ConsulterSolde(numero);
        }
      
    }
}
