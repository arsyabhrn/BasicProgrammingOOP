using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    class Bmi
    {
        public double kg;
        public double cm;

        public Bmi(double aKg, double aCm)
        {
            kg = aKg;
            cm = aCm;
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
        }
    }
}
