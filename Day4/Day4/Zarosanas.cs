using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Zarosanas
    {
        public void LielaksVaiMazaks()
        {
            Console.WriteLine("Ludzu skaitli: ");

            string input = Console.ReadLine();
            int skaitlis = Convert.ToInt16(input);

            // vai skaitlis ir lielaks vai mazaks par 5 ?


            if (skaitlis > 5)
            {
                Console.WriteLine(skaitlis + " ir lielaks par 5! ");
            }
            else
            {

                if (skaitlis == 5)
                {
                    Console.WriteLine(skaitlis + " ir 5! ");
                }

                else
                {
                    Console.WriteLine(skaitlis + " ir mazaks par 5!");
                }
            }

        }
        public void ArIf(string ievade)

        {
           
            int skaitlis = Convert.ToInt32(ievade);

            if (skaitlis > 10 || skaitlis < 0) // visas kludainas vertibas seit
            {
                Console.WriteLine("Ievade ir kludaina!");

            }
            else // visas derigas vertibas seit
            {
                if (skaitlis == 0)
                {
                    Console.WriteLine("Ievade ir nulle!");
                }
                if (skaitlis == 1)
                {
                    Console.WriteLine("Ievade ir 1!");
                }
                if (skaitlis == 2)
                {
                    Console.WriteLine("Ievade ir 2!");
                }
                if (skaitlis == 3)
                {
                    Console.WriteLine("Ievade ir 3!");
                }
                if (skaitlis == 4)
                {
                    Console.WriteLine("Ievade ir 4!");
                }
                if (skaitlis == 5)
                {
                    Console.WriteLine("Ievade ir 5!");
                }
                if (skaitlis == 6)
                {
                    Console.WriteLine("Ievade ir 6!");
                }
                if (skaitlis == 7)
                {
                    Console.WriteLine("Ievade ir 7!");
                }
                if (skaitlis == 8)
                {
                    Console.WriteLine("Ievade ir 8!");
                }
                if (skaitlis == 9)
                {
                    Console.WriteLine("Ievade ir 9!");
                }
                if (skaitlis == 10)
                {
                    Console.WriteLine("Ievade ir 10!");
                }
                if (skaitlis == 11)
                {
                    Console.WriteLine("Ievade ir kludaina!");
                }
            }
            


            


        }



        public void ArCase(string ievade)


        {
            int skaitlis = Convert.ToInt32(ievade);


            switch (skaitlis)
            {
                case 1:
                    Console.WriteLine("Ievade ir 1 ");
                    break;

                case 2:
                    Console.WriteLine("Ievade ir 2 ");
                    break;
                case 3:
                    Console.WriteLine("Ievade ir 3 ");
                    break;
                case 4:
                    Console.WriteLine("Ievade ir 4");
                    break;
                case 5:
                    Console.WriteLine("Ievade ir 5 ");
                    break;
                case 6:
                    Console.WriteLine("Ievade ir 6  ");
                    break;
                case 7:
                    Console.WriteLine("Ievade ir  7 ");
                    break;
                case 8:
                    Console.WriteLine("Ievade ir  8 ");
                    break;
                case 9:
                    Console.WriteLine("Ievade ir  9 ");
                    break;
                case 10:
                    Console.WriteLine("Ievade ir 10! ");
                    break;
                case 11:
                    Console.WriteLine("Ievade ir kludaina! ");
                    break;
                case 0:
                    Console.WriteLine("Kludaina ievade ");
                    break;

                default:
                    Console.WriteLine("Kludaina ievade!");
                    break;



            }
            Console.WriteLine("Done!");
            Console.ReadLine();

        }

    }
}
