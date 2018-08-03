using System;
using System.Collections.Generic;
using CompteApp.Library.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODDO.Clients.Domain;

namespace CompteApp.Library.Tests
{
    [TestClass]
    public class UnitTestCompteManagerImplMemory
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            var underTest = new CompteManagerImpl_Memory();
            var expected = 3;//nombre de compte
            //ACT
            var actual = underTest.FindAll();
            foreach (var item in actual)
            {
                Console.WriteLine(item.Proprietaire);
            }
            //ASSERT
            Assert.AreEqual(expected, ((IList<Compte>)actual).Count);
        }



        [TestMethod]
        public void TestMethod2()
        {
            //ARRANGE
            var underTest = new CompteManagerImpl_Memory();
            var expected = new Compte {Numero="C1000",Proprietaire="Zakaria",Solde=1000M };//nombre de compte
            string id = "C1000";
            //ACT
            var actual = underTest.FindById(id);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
