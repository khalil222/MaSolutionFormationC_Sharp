namespace Banking.BackOffice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBank : DbContext
    {
        public ModelBank()
            : base("name=ModelBank")
        {
        }

        public virtual DbSet<Compte> Comptes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
