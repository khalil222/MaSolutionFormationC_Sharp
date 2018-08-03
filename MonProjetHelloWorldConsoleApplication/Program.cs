using ODDO.Clients.Domain;
using System;


namespace ODDO.Clients.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bienvenue dans C#");
            Compte c = new Compte() 
            {
                Numero="C1000",
                Proprietaire="Khalil",
                Solde=1000M
            }; //Object initializer

            System.Console.WriteLine(c);

        }
    }
}
