using BankingApp.L1.DataAcess.Facade;
using BankingApp.L1.DataAcess.Implementations;
using BankingApp.L2.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L2.Business.Implementation
{
    public class CompteBusinessImpl : IComptesBusiness
    {
        const decimal TAUX = 0.1M;
        private IComptesRepository repo = new ComptesRepositoryImpl_EF();

        public decimal ConsulterSolde(string id)
        {
            var resultat = repo.FindById(id);
            if (resultat !=null)
            {
                return (resultat.Numero.StartsWith("E")) ?
                    resultat.Solde * (1 + TAUX)
                    :
                    resultat.Solde;
            }
            else
            {
                return decimal.MinValue;
            }
        }
    }
}
