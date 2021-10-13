using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLab
{
    class Circle
    {

        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius)
        {
            this.radius = FormatNumber(radius);
        }


        public double CalculateCircumference()
        {
            return (2 * Math.PI) * radius;
        }

        public string CalculateFormattedCircumference()
        {
            return $"Circumference: {Math.Round(CalculateCircumference(), 2)}";
        }

        public double CalculateArea()
        {
            this.radius = Math.PI * (Radius * Radius);
            return radius;
        }

        public string CalculateFormattedArea()
        {
            return $"Area: {Math.Round(CalculateArea(), 2)}";
        }

        private static double FormatNumber(double x)
        {
            Console.WriteLine("Enter a radius: ");
            while (true)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    if (x > 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("Value entered needs to be 1 or greater");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Value entered is not a number. \nPlease try again: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return x;
        }

        }
    }

