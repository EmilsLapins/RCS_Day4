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
                Console.WriteLine(skaitlis + " ir mazaks par 5!");

            }

        }
    }
}
