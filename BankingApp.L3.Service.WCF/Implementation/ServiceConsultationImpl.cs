using BankingApp.L2.Business.Facade;
using BankingApp.L2.Business.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankingApp.L3.Service.WCF
{
    
    public class ServiceConsultationImpl : IServiceConsultation
    {
        private IComptesBusiness business = new CompteBusinessImpl();


        public  decimal GetSolde(string numero)
        {
            return business.ConsulterSolde(numero);
        }
    }
}
