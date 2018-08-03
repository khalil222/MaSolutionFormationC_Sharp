using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
   // delegate void Operation(int x, int y);//Forme de delegation

    class Program
    {
        static void Main(string[] args)
        {

            //Subscription
            //Operation delegué1 = CalculUtils.Additionner;
            Action<int, int> delegué1 = CalculUtils.Additionner; //C#4 2010

            //Other Subscription
            delegué1 += CalculUtils.Multiplier;


            //Another subscription using anonymous delegate(c#2 2005)
            //delegué1 += delegate (int a, int b)
            //{
            //    Console.WriteLine($"La soustraction de {a} et {b} est égale a : {a - b}");
            //};

            delegué1 +=  (a,b) =>//Since c# 3,2008
            {
                Console.WriteLine($"La soustraction de {a} et {b} est égale a : {a - b}");
            };
            delegué1(11, 22);
        }

        
    }
}
