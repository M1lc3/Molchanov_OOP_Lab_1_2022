using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace oop_lab1
{
    public class Rectangle
    {
        private double sideA, sideB; 

        public Rectangle()
        {
            sideA = 0;
            sideB = 0;
        }

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double SideA
        {
            get { return sideA; }
            set
            { 
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else sideA = value;
            }

        }

        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else sideB = value;
            }
        }

        public override string ToString()
        {
            return $"Rectangle {sideA} x {sideB}";
        }

        public static double Perimeter(Rectangle rectangle)
        {
            return rectangle.sideA * 2 + rectangle.sideB * 2;
        }

        public static double Surface(Rectangle rectangle)
        {
            return rectangle.sideA * rectangle.sideB;
        }

        public double GetSideA() { return sideA; }

        public double GetSideB() { return sideB; }
    }
}
