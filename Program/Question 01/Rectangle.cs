using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Question_01
{
    internal class Rectangle : IRectangle
    {
        private double width;
        private double height;

        public double Width 
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Invalid Value for Width");
                else
                    width = value;
            }
        }
        public double Height 
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Invalid Value for Height");
                else
                    height = value;
            }
        }

        public double Area
        {
            get 
            {
                return width * height;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Rectangle, Area ={Area}");
        }
    }
}
