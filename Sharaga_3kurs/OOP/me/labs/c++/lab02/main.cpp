#include <iostream>
#include <string.h>
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
    void setPointX(int x);
    void setPointY(int y);

    void setPointXY(int x, int y);
    void XYMultiplyBy(int z);
    void operator ++();
    void operator --();
    operator bool();
    Point operator + (int z);
    operator string();

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

void Point::setPointX(int x) {this->x = x;}

void Point::setPointY(int y) {this->y = y;}

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

void Point::operator ++()
{
    ++x; ++y;
}

void Point::operator --()
{
    --x; --y;
}

Point::operator bool()
{
    if (x == y) return true;
    else return false;
}

Point Point::operator + (int z)
{
    return Point(this->x + z, this->y + z);
}

Point::operator string()
{
    return string("x = " + to_string(x) + ", y = " + to_string(y));
}

int main()
{
    Point p1;
    Point p2(5, 6);

    p1.setPointXY(1, 2);
    p2.onVector(3, 3);
    p1.show();
    //cout << p1.getPointX() << endl;
    ++p1;
    p1.show();

    cout << p1 << endl;
    p1.setPointY(2);
    cout << p1 << endl;

    p1 = p1 + 7;
    p1.show();

    cout << string(p1) << endl;
    return 0;
}