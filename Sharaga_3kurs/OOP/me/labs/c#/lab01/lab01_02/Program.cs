using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_02
{ 

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


    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point(5, 6);

            p1.setPointXY(1, 2);
            p2.onVector(3, 3);
            p1.show();
            Console.WriteLine( p1.X);

        }
    }
}