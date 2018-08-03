using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankingApp.L3.Service.WCF
{
    
    [ServiceContract]
    public interface IServiceConsultation
    {
        [OperationContract]
        decimal GetSolde(string numero);
    }
}
