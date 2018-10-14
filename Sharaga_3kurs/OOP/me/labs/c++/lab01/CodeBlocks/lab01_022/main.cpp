#include <iostream>
#include <string>
#include <bits/stdc++.h>
#include <algorithm>
#include <random>
#include <vector>

using namespace std;

class Point
{
    private:
        int x;
        int y;
        //int _x{ set; get; }
    public:
        Point();
        Point(int x, int y);
        ~Point(){cout << "Object deleted" << endl;};

        void show();
        int distance();
        void onVector(int a, int b);
        int getPointX();
        int getPointY();

        void setPointXY(int x, int y);
        void XYMultiplyBy(int z);

};


Point::Point(){};

Point::Point(int x, int y)
{
    this->x = x;
    this->y = y;
};

void Point::show()
{
	cout << "X: " << this->x << endl;
	cout << "Y: " << this->y << endl;
};

int Point::distance()
{
    return sqrt(pow(x, 2) + pow(y, 2));
};

void Point::onVector(int a, int b)
{
	cout << "X: " << a + x << endl;
	cout << "Y: " << b + y << endl;
};

int Point::getPointX() {return this->x;}

int Point::getPointY() {return this->y;}

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

int main()
{
    Point p1;
    Point p2(5, 6);

    p1.setPointXY(1, 2);
    p2.onVector(3, 3);
    p1.show();
    cout << p1.getPointX();


    return 0;
}
