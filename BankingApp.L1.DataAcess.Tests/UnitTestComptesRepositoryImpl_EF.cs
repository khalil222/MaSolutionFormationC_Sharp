using System;
using BankingApp.L0.Domain;
using BankingApp.L1.DataAcess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L1.DataAcess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void OuvrirCompte()
        {
            //ARRANGE
            var c = new Compte
            {
                Numero = "E200",
                Proprietaire = "Amine",
                Solde = 200M
            };
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT
            underTest.OuvrirCompte(c);
            //ASSERT

        }

        [TestMethod]
        public void FindById_Nominal()
        {
            var id = "C100";
            //ARRANGE
            var c = new Compte
            {
                Numero = "C100",
                Proprietaire = "Khalil",
                Solde = 100M
            };
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT
            var actual=underTest.FindById(id);
            //ASSERT
            Assert.AreEqual(c, actual);

        }

        [TestMethod]
        public void FindById_Degrade()
        {

            //ARRANGE
            var id = "Z100";
           
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT
            var actual = underTest.FindById(id);
            //ASSERT
            Assert.IsNull(actual);

        }
    }
}
