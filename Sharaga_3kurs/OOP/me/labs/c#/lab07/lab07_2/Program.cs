using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;


namespace lab07_2
{
    [Serializable]
    class Point
    {
        private int x;
        private int y;
        public int X { set { x = value; } get { return x; } }
        public int Y { set { y = value; } get { return y; } }
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void show()
        {
            Console.WriteLine( "X: " + this.x );
            Console.WriteLine( "Y: " + this.y );
        }

        public double distance()
        {
            return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }

        public void onVector(int a, int b)
        {
            Console.WriteLine( "X: " + (a + x));
            Console.WriteLine( "Y: " + b + y );
        }

        public void setPointXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void XYMultiplyBy(int z)
        {
            x *= z;
            y *= z;
        }

    };


    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(7, 8);
            Point p2 = new Point(5, 6);
            Point p3 = new Point(0, 0);

            Point[] points = new Point[]{p1, p2, p3};
            SoapFormatter formatter = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("points.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, points);
 
                Console.WriteLine("Объект сериализован");
            }

            int i = 1;
            // десериализация
            using (FileStream fs = new FileStream("points.soap", FileMode.OpenOrCreate))
            {
                Point[] newPoints = (Point[]) formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                foreach (Point p in newPoints)
                {
                    Console.WriteLine("Element {0}: --- X: {1}, Y: {2}", i++, p.X, p.Y);
                }
            }
        }
    }
}