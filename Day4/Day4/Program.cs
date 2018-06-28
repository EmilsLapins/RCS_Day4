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
            Console.WriteLine("1, ja izvelies izsaukt Uzdevums klasi; 2, ja Zarosanas klasi!");
            string input = Console.ReadLine();
           

            if (input == "1") // ja ievaditais ir lielaks par 5 vai 5, tad izsaucam uzdevums klasi
            {
                Console.WriteLine("Izvelejaties Uzdevums klasi!");
                Uzdevums uzdevums1 = new Uzdevums(); // konstruejam objektu!
                uzdevums1.Publiska(); // izsaucam no uzdevums klases public funkciju!
            }
            else
            {
           
                if (input == "2")
                {
                    Console.WriteLine("Izvelejaties Zarosanas klasi!");
                    Zarosanas zari = new Zarosanas(); // ja ievaditais ir mazaks par 5
                    zari.LielaksVaiMazaks();
                }
                else
                {
                    Console.WriteLine("Nemakam lasit?");
                   
                }
                
            }
            


            Console.ReadLine();


            
        }

        ///////









    }
}
