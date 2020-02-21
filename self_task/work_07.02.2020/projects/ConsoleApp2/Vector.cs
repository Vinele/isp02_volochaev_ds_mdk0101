using System;

namespace ConsoleApp2
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(int vectorX, int vectorY,int vectorZ)
        {
            X = vectorX;
            Y = vectorY;
            Z = vectorZ;
        }
        public double Lenght (Vector vector01)
        {
            return Math.Sqrt(Math.Pow(vector01.X, 2) + Math.Pow(vector01.Y, 2) 
                 + Math.Pow(vector01.Z, 2));
        }
        public double ScalarProduct(Vector vector01, Vector vector02)
        {
            return (vector01.X) * (vector02.X) + (vector01.Y) 
                 * (vector02.Y) + (vector01.Z) * (vector02.Z);
        }
        public double Product(Vector vector01, Vector vector02)
        {
            double vectorX = (vector01.Y) * (vector02.Z) - (vector01.Z) * (vector02.Y);
            double vectorY = (vector01.Z) * (vector02.X) - (vector01.X) * (vector02.Z);
            double vectorZ = (vector01.X) * (vector02.Y) - (vector01.Y) * (vector02.X);
            return vectorX - vectorY - vectorZ;
        }
        public override string ToString()
        {
            return $"vec(x:{X}; y:{Y}; z:{Z} )";
        }
    }
}
