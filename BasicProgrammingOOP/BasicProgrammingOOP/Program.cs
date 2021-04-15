using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string repeat;
                do
                {
                    Console.WriteLine("Input Number From 1-4" + Environment.NewLine +
                        "1. Body Mas Index" + Environment.NewLine +
                        "2. Reprint Name" + Environment.NewLine +
                        "3. Prints Even's Character" + Environment.NewLine +
                        "4. Sum the inputted array" + Environment.NewLine);

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            // code block
                            Console.WriteLine("Input Your Weight (kg)");
                            double kg = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input Your Height (cm)");
                            double cm = Convert.ToDouble(Console.ReadLine());
                            Bmi bmi1 = new Bmi(kg, cm);
                            break;
                        case 2:
                            // code block
                            Console.WriteLine("Please input your name");
                            string name = Console.ReadLine();
                            Name name1 = new Maudy(name);
                            name1.Spell();
                            break;
                        case 3:
                            // code block
                            Console.WriteLine("Please input your name");
                            name = Console.ReadLine();
                            Name name2 = new Maudy(name);
                            name2.SpellEven();
                            break;
                        case 4:
                            // code block
                            Console.WriteLine("Input size of array");
                            int size = Convert.ToInt32(Console.ReadLine());
                            Array array1 = new Array(size);
                            break;
                        default:
                            // code block
                            Console.WriteLine("masukkan angka dari 1-4");
                            break;
                    }
                    Console.WriteLine("ketik \"yes\" untuk mengulang program");
                    repeat = Console.ReadLine().ToLower();
                } while (repeat == "yes");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak bisa dimasukkan angka 0");

            }
            catch (FormatException)
            {
                Console.WriteLine("Tolong masukkan angka, bukan huruf");
            }
        }
    }
}
