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
            
            //if else statements !
            
            Console.WriteLine("If un Switch... ");
            Console.WriteLine("Ievadiet skaitli!");
            string input = Console.ReadLine();

            Zarosanas zars1 = new Zarosanas();
            zars1.ArIf(input);
            zars1.ArCase(input);

            Console.WriteLine("1, ja izvelies izsaukt Uzdevums klasi; 2, ja Zarosanas klasi!");




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
                    Console.WriteLine("Error?");

                }

            }
            //
            // versija ar Switch statement!
            //
            switch (input)
            {
                case "1":

                    Console.WriteLine("Izvelejaties Uzdevums klasi!");
                    Uzdevums uzdevums1 = new Uzdevums(); // konstruejam objektu!
                    uzdevums1.Publiska(); // izsaucam no uzdevums klases public funkciju!

                    break;

                case "2":
                    Console.WriteLine("Izvelejaties Zarosanas klasi!");
                    Zarosanas zari = new Zarosanas(); // ja ievaditais ir mazaks par 5
                    zari.LielaksVaiMazaks();

                    break;
                default:
                    Console.WriteLine("Error");
                    break; // ar break mes izejam ara no switch statement!


            }
            Console.ReadLine();
        }
        
    }
}

