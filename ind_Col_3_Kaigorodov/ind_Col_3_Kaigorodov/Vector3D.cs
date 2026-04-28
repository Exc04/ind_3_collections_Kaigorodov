using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_Col_3_Kaigorodov
{
    internal class Vector3D
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double Z1 { get; set; }

        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double Z2 { get; set; }

        public double Vx => X2 - X1;
        public double Vy => Y2 - Y1;
        public double Vz => Z2 - Z1;

        public Vector3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            X1 = x1; Y1 = y1; Z1 = z1;
            X2 = x2; Y2 = y2; Z2 = z2;
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(0, 0, 0, a.Vx + b.Vx, a.Vy + b.Vy, a.Vz + b.Vz);
        }

        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D(0, 0, 0, a.Vx - b.Vx, a.Vy - b.Vy, a.Vz - b.Vz);
        }

        public double GetLength()
        {
            return Math.Sqrt(Vx * Vx + Vy * Vy + Vz * Vz);
        }

        public static double GetDotProduct(Vector3D a, Vector3D b)
        {
            return a.Vx * b.Vx + a.Vy * b.Vy + a.Vz * b.Vz;
        }

        public static double GetCosAngle(Vector3D a, Vector3D b)
        {
            double lenA = a.GetLength();
            double lenB = b.GetLength();

            if (lenA == 0 || lenB == 0)
                return 0;

            return GetDotProduct(a, b) / (lenA * lenB);
        }

        public override string ToString()
        {
            return $"({Vx:F2}; {Vy:F2}; {Vz:F2})";
        }
    }
}
