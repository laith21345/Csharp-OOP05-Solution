using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Question_01
{
    internal class Circle : ICircle
    {
        private double radius;


        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value<0)
                    Console.WriteLine("Invalid Value for Radius");
                else
                    radius = value;
            }
        }
        public double Area {
            get 
            {
                return Radius * Radius * 3.14;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Circle, Area ={Area}");
        }
    }
}
