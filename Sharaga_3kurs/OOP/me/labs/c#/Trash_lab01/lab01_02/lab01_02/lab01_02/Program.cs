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
        public Point() { }
        public Point(int x, int y)
        {
            this->x = x;
            this->y = y;
        }

        public void show()
        {
            Console.WriteLine("X: " << this->x << endl);
            Console.WriteLine("Y: " << this->y << endl);
        }
        public int distance()
        {
            return sqrt(pow(x, 2) + pow(y, 2));
        }
        public void onVector(int a, int b)
        {
            Console.WriteLine("X: " << a + x << endl);
            Console.WriteLine("Y: " << b + y << endl);
        }
        public int getPointX();
        public int getPointY();

        void setPointXY(int x, int y);
        void XYMultiplyBy(int z);

    };


    Point::Point(){};

Point::Point(int x, int y)
    {
        this->x = x;
        this->y = y;
    }

void Point::show()
{
    Console.WriteLine("X: " << this->x << endl;
    Console.WriteLine("Y: " << this->y << endl;
}

int Point::distance()
{
    return sqrt(pow(x, 2) + pow(y, 2));
}

void Point::onVector(int a, int b)
{
    Console.WriteLine("X: " << a + x << endl;
    Console.WriteLine("Y: " << b + y << endl;
}

int Point::getPointX() { return this->x; }

int Point::getPointY() { return this->y; }

void Point::setPointXY(int xx, int yy)
{
    this->x = xx;
    this->y = yy;
};

void Point::XYMultiplyBy(int z)
{
    x *= z;
    y *= z;
}


class Program
{
    static void Main(string[] args)
    {
        Point p1;
        Point p2(5, 6);

        p1.setPointXY(1, 2);
        p2.onVector(3, 3);
        p1.show();
        Console.WriteLine(p1.getPointX();

    }
}
}
