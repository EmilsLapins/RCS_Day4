using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaitli ludzu");
            string abc = Console.ReadLine();
            int abc1 = Convert.ToInt16(abc);

            if (abc1 >= 5) // ja ievaditais ir lielaks par 5 vai 5, tad izsaucam uzdevums klasi
            {
                Console.WriteLine("Vienads ar 5 , vai lielaks par 5");
                Uzdevums uzdevums1 = new Uzdevums(); // konstruejam objektu!
                uzdevums1.Publiska(); // izsaucam no uzdevums klases public funkciju!
            }
            else 
            {
                Console.WriteLine("Mazaks par 5");
                Zarosanas zari = new Zarosanas(); // ja ievaditais ir mazaks par 5
                zari.LielaksVaiMazaks();
            }

           
            





            // cilveks var izveleties kuru funkciju izsaukt! <5 un >5 - divi gadijumi!




            Console.ReadLine();


            
        }

        ///////









    }
}
