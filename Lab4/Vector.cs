using System;


namespace Lab4
{
    internal class Vector
    {
        private float _x;
        private float _y;
        private float _z;

        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public float Z { get => _z; set => _z = value; }

        public Vector(float x = 0, float y = 0, float z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public string DisplayVector()
        {
            return X + " " + Y + " " + Z;
        }

        
        public double VectorLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static Vector operator +(Vector coordinate1, Vector coordinate2)
        {
            return new Vector(coordinate1.X + coordinate2.X, coordinate1.Y + coordinate2.Y, coordinate1.Z + coordinate2.Z);
        }
        public static float operator %(Vector coordinate1, Vector coordinate2)
        {
            return coordinate1.X * coordinate2.X + coordinate1.Y * coordinate2.Y + coordinate1.Z * coordinate2.Z;
        }
        public static Vector operator *(Vector coordinate1, Vector coordinate2)
        {
            float resultX = coordinate1.Y * coordinate2.Z - coordinate1.Z * coordinate2.Y;
            float resultY = coordinate1.Z * coordinate2.X - coordinate1.X * coordinate2.Z;
            float resultZ = coordinate1.X * coordinate2.Y - coordinate1.Y * coordinate2.X;
            return new Vector(resultX, resultY, resultZ);
        }

    }
}
