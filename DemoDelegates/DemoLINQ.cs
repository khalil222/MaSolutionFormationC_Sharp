using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class DemoLINQ
    {
        static void Main(string[] args)
        {
            IEnumerable<string> participants =
                new List<string>
                {
                    "Mohamed",
                    "Khalil",
                    "Othmen",
                    "Abdessalem",
                    "Oussema",
                    "Ahmed"
                };

            var filtres_extension_style = participants.Where(p => p.StartsWith("A"));

            var filtres_query_style =
                from p in participants
                where p.StartsWith("A")
                select p;
        }

    }
}
