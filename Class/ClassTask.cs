using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }

        public Rectangle(double a)
        {
            this.sideA = a;
            sideB = 5;
        }
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return (sideA + sideB) * 2;
        }

        public bool IsSquare()
        {
            return sideA == sideB;
        }

        public void ReplaceSides()
        {
            double temp = sideA;
            sideA = sideB;
            sideB = temp;
        }



    }


    public class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(Rectangle[] rectangle_array)
        {
            this.rectangle_array = rectangle_array;
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }

            }
            return false;
        }

        public int NumberMaxArea()
        {
            int number = 0;
            double area_temp = double.MinValue;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > area_temp)
                {
                    number = i;
                    area_temp = rectangle_array[i].Area(); 

                }
            }
            return number;
        }
        public int NumberMinPerimeter()
        {
            int number = 0;
            double temp_perimeter = double.MaxValue;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() < temp_perimeter)
                { 
                    number = i; 
                    temp_perimeter= rectangle_array[i].Perimeter();
                }
            }
            return number;
        }

        public int NumberSquare()
        {
            int count = 0;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].IsSquare())
                    count++;
            }
            return count;
        }


    }
}
