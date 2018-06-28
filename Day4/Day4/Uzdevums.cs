using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Uzdevums
    {


        public void Publiska ()
        {

            Izvade();
            
            Console.WriteLine(Saskaitisana());
            
        }


        private void Izvade()
        {
            Console.WriteLine("Sis ir...");
            Console.WriteLine("...viegls uzdevums");  // izvadit
            

        }

        private int Saskaitisana()
        {
            int result = 3 + 5;
            return result;

        }
        


    }
}
