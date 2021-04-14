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
                            cm = cm / 100;

                            double result = kg / (cm * cm);
                            //math.round
                            if (result < 18.1)
                            {
                                Console.WriteLine("Your BMI'S " + Math.Round(result) + " Youre Underwieght");
                            }
                            else if (result >= 18.1 && result <= 23.1)
                            {
                                Console.WriteLine("Your BMI'S " + result.ToString("F") + " Youre Normal");
                            }
                            else if (result >= 23.1 && result <= 28.1)
                            {
                                Console.WriteLine("Your BMI'S " + result.ToString("F") + " Youre Overwieght");
                            }
                            else
                            {
                                Console.WriteLine("Your BMI'S " + result.ToString("F") + " Youre Obesitas");
                            }
                            break;
                        case 2:
                            // code block
                            Console.WriteLine("Please input your name");
                            string name = Console.ReadLine();
                            int count = 1;
                            foreach (char el in name)
                            {
                                Console.WriteLine($"Huruf ke {count} adalah {el}");
                                count++;
                            }
                            break;
                        case 3:
                            // code block
                            Console.WriteLine("Please input your name");
                            name = Console.ReadLine();
                            //int nameLenght = name.Length;
                            count = 1;
                            foreach (char el in name)
                            {
                                if (count % 2 != 0)
                                {
                                    Console.WriteLine($"Huruf ke {count} adalah {el}");
                                    count++;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            break;
                        case 4:
                            // code block
                            Console.WriteLine("Input size of array");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] intArray = new int[size];
                            for (int i = 0; i < size; i++)
                            {
                                Console.WriteLine($"Masukkan angka index ke-{i}");
                                intArray[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            int sum = intArray.Sum();
                            Console.WriteLine($"jumlah dari array adalah {sum}");
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
