using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    class Name
    {
        public string name;

        public Name(string aName)
        {
            name = aName;
        }

        public void Spell()
        {
            int count = 1;
            foreach (char el in name)
            {
                Console.WriteLine($"Huruf ke {count} adalah {el}");
                count++;
            }
        }

        public void SpellEven()
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
