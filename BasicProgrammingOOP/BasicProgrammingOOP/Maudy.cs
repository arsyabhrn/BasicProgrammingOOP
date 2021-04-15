using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    class Maudy : Name
    {

        public Maudy(string aName)
        {
            name = aName;
        }
        public override void Spell()
        {
            
            int count = 1;
            foreach (char el in name)
            {
                Console.WriteLine($"Huruf ke {count} adalah {el}");
                count++;
            }
        }

        public override void SpellEven()
        {
            int count = 1;
            foreach (char el in name)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine($"Huruf ke {count} adalah {el}");
                    count++;
                }
                else
                {
                    count++;
                }
            }
        }
    }
}
