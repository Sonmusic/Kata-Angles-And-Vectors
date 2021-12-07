using System;

namespace VectorsAndAngles
{
    public class Vector
    {
        public int X;
        public int Y;
        public int[] vector;

        //Constructor
        public Vector (int x, int y)
        {
            X = x;
            Y = y;
            vector = new int[] { x, y };
        }

        public double magnitude()
        {
            double magnitude = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
            return magnitude;
        }
        
        public double DotProduct(Vector b)
        {
            double dot = ((this.vector[0] * b.vector[0]) + (this.vector[1] * b.vector[1]));
            return dot;
        }

        public double AngleBetween(Vector b)
        {
            double Angle = (this.DotProduct(b)/(this.magnitude() * b.magnitude()));
            return Angle;
        }
    }
}
