using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lab1
{
    public class TTrianglePrizm : TTriangle
    {
        private double height;
        private TTriangle triangle;

        public TTrianglePrizm()
        {
            height = 0;
            triangle = new TTriangle();
        }

        public TTrianglePrizm(TTriangle triangle, double height)
        {
            this.height = height;
            this.triangle = triangle;
        }

        public TTrianglePrizm(TTrianglePrizm trianglePrizm)
        {
            this.height = trianglePrizm.height;
            this.triangle = trianglePrizm.triangle;
        }

        public override string ToString()
        {
            return $"{triangle}, height = {height}";
        }

        public double Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }



        //override public string ToString()
        //{
        //    return $"{triangle}, h = {height}";
        //}

        public static double Volume(TTrianglePrizm prizm)
        {
            return TTriangle.Surface(prizm.triangle) * prizm.height;
        }

        public static double Surface(TTrianglePrizm prizm)
        {
            return (TTriangle.Surface(prizm.triangle) * 2) + (TTriangle.Perimeter(prizm.triangle) * prizm.height);
        }
    }
}
