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

        //Вычисление длины вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);
        }
        //Перегрузка оператора(%) скалярное произведение векторов
        public static float operator %(Vector vector1, Vector vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
        }
        //Перегрузка оператора(*) векторное произведение векторов
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            float resultX = vector1.Y * vector2.Z - vector1.Z * vector2.Y;
            float resultY = vector1.Z * vector2.X - vector1.X * vector2.Z;
            float resultZ = vector1.X * vector2.Y - vector1.Y * vector2.X;
            return new Vector(resultX, resultY, resultZ);
        }

    }
}
