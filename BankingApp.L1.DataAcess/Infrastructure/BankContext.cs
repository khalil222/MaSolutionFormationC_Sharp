using BankingApp.L0.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAcess.Infrastructure
{
    public class BankContext : DbContext
    {
        public virtual DbSet<Compte> Comptes { get; set; }
        public BankContext():base("name=MyBankDb")
        {

        }
    }
}
