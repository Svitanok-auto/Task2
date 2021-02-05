using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Square : Drawing

    {
        public double Length { get; set; }

        public Square ()
        {
            Console.WriteLine("What is the side of the square? Should be more than 0");
            int i = 0;

            while (i < 3)
            {

                string InputString = Console.ReadLine();
                if (InputString.ToString() != string.Empty) // the Convert fails when ""
                {
                    try
                    {
                        Length = Convert.ToDouble(InputString);
                        Console.WriteLine("Lenght is " + Length);
                 
                        break;
                    }
                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("Incorrect Input, error" + LastError);
                        Console.WriteLine("Try again to populate correct side of the square");
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
                Length = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
                Console.WriteLine("Random Length is " + Length);
            }
        }


    public override double Area()
        {
        double result = Math.Round(Length * Length, 2);
        return result;
    }
    }
}
