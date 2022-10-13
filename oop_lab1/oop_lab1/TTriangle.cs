using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace oop_lab1
{
    public class TTriangle
    {
        private double sideA, sideB, sideC;

        public TTriangle()
        {
            sideA = 1;
            sideB = 1;
            sideC = 1;
        }

        public TTriangle(double sideA, double sideB, double sideC)
        {
            //if (IsTriangle(sideA, sideB, sideC))
            //{
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            //}
            //else Environment.Exit(0);
        }

        public TTriangle(TTriangle triangle)
        {
            if (IsTriangle(sideA, sideB, sideC))
            {
                this.sideA = triangle.sideA;
                this.sideB = triangle.sideB;
                this.sideC = triangle.sideC;
            }
            else Environment.Exit(0);
        }

        override public string ToString()
        {
            return $"a = {sideA}, b = {sideB}, c = {sideC}";
        }

        public double SideA
        {
            get { return sideA; }
            set { if (value > 0) sideA = value; }
        }
        public double SideB
        {
            get { return sideB; }
            set { if (value > 0) sideB = value; }
        }
        public double SideC
        {
            get { return sideC; }
            set { if (value > 0) sideC = value; }
        }

        public static double Surface(TTriangle triangle)
        {
            if (IsTriangle(triangle.sideA, triangle.sideB, triangle.sideC))
            {
                double p = Perimeter(triangle) / 2;
                return Math.Sqrt(p * (p - triangle.sideA) * (p - triangle.sideB) * (p - triangle.sideC));
                //return 1 / 4 * Math.Sqrt((triangle.sideA + triangle.sideB + triangle.sideC) * (triangle.sideB + triangle.sideC - triangle.sideA) *
                //    (triangle.sideA + triangle.sideC - triangle.sideB) * (triangle.sideA + triangle.sideB - triangle.sideC));
            }
            else { Environment.Exit(0); return 0; };
        }

        public static double Perimeter(TTriangle triangle)
        {
            if (IsTriangle(triangle.sideA, triangle.sideB, triangle.sideC))
            {
                return triangle.sideA + triangle.sideB + triangle.sideC;
            }
            else { Environment.Exit(0); return 0; };
        }

        public static bool IsSimilar(TTriangle triangle1, TTriangle triangle2)
        {
            //if (triangle1.sideA == triangle2.sideA || triangle1.sideA == triangle2.sideB || triangle1.sideA == triangle2.sideC);
            //if (triangle1.sideB == triangle2.sideA || triangle1.sideB == triangle2.sideB || triangle1.sideB == triangle2.sideC);
            //if (triangle1.sideC == triangle2.sideA || triangle1.sideC == triangle2.sideB || triangle1.sideC == triangle2.sideC);
            if (IsTriangle(triangle1.sideA, triangle1.sideB, triangle1.sideC) && IsTriangle(triangle2.sideA, triangle2.sideB, triangle2.sideC))
                return (triangle1.sideB == triangle2.sideA || triangle1.sideB == triangle2.sideB || triangle1.sideB == triangle2.sideC) &&
                    (triangle1.sideB == triangle2.sideA || triangle1.sideB == triangle2.sideB || triangle1.sideB == triangle2.sideC) &&
                    (triangle1.sideC == triangle2.sideA || triangle1.sideC == triangle2.sideB || triangle1.sideC == triangle2.sideC);
            else { Environment.Exit(0); return false; }; 
        }

        public static bool IsTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0) return false;
            if (sideA > sideB + sideC) return false;
            if (sideB > sideA + sideC) return false;
            if (sideC > sideA + sideB) return false;
            else return true;
        }
         
        //public static TTriangle operator +(TTriangle triangle1, TTriangle triangle2)
        //{
        //    return new TTriangle(triangle1.sideA + triangle2.sideA, triangle1.sideB + triangle2.sideB, triangle1.sideC + triangle2.sideC);
        //}

        //public static TTriangle operator -(TTriangle triangle1, TTriangle triangle2)
        //{
        //    return new TTriangle(triangle1.sideA - triangle2.sideA, triangle1.sideB - triangle2.sideB, triangle1.sideC - triangle2.sideC);
        //}

        public static TTriangle operator *(TTriangle triangle, double num)
        {
            return new TTriangle(triangle.sideA * num, triangle.sideB * num, triangle.sideC * num);
        }

        public static TTriangle operator *(double num, TTriangle triangle)
        {
            return new TTriangle(triangle.sideA * num, triangle.sideB * num, triangle.sideC * num);
        }

    }
}
