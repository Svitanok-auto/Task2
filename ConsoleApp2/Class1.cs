using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Console.WriteLine("What is the radius of the circle? Radius should be more than 0");
            int i = 0;

            while (i < 3)
            {

                string InputString = Console.ReadLine();
                if (InputString.ToString() != string.Empty) // the Convert fails when ""
                {
                    try
                    {
                        Radius = Convert.ToDouble(InputString);
                        Console.WriteLine("Radius is " + Radius);

                        break;
                    }
                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("Incorrect Input, error" + LastError);
                        Console.WriteLine("Try again to populate correct radius of circle");
                        i++;

                    }

                }

                else
                {
                    Console.WriteLine("Empty input");
                }

            }

            if (i == 3)
            {

                double minNumber = 0.5;
                double maxNumber = 5.0;
                Radius = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
                Console.WriteLine("Random value is " + Radius);
            }

        }
        public override double Area()
        {
            double Pi = Math.PI;
            double result = Math.Round((Radius * Pi), 2);
            return result;
        }
    }
}
