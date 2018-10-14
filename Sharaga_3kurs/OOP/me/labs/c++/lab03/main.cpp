#include <iostream>
#include <string.h>
#include <bits/stdc++.h>
#include <algorithm>
#include <random>
#include <vector>

using namespace std;

class Figure
{
public:
    virtual double Square() = 0;
    virtual double Perimetr() = 0;
    virtual void info() = 0;
};

class Rectangle : public Figure
{
private:

    int a;
    int b;

public:
    Rectangle(double w, double h) : a(w), b(h)
    {
    }

    double Square() override
    {
        return a * b;
    }

    double Perimetr() override
    {
        return 2 * a + 2 * b;
    }

    void info() override
    {
        cout << "Rectangle" << endl;
    }
};

class Circle : public Figure
{
private:
    double radius;

public:
    Circle(double r) : radius(r)
    {
    }

    double Square() override
    {
        return radius * radius * 3.14;
    }

    double Perimetr() override
    {
        return 2 * 3.14 * radius;
    }
    void info()
    {
        std::cout << "Circle" << std::endl;
    }
};

class Triangle : public Figure
{
private:
    int a;
    int b;
    int c;

public:
    Triangle(int x, int y, int z) : a(x), b(y), c(z)
    {
        if (!((a+b>c) && (b+c>a) && (c+a>b)))
        {
            a = 0; b = 0; c = 0;
            cout << "This triangle not exist";
        }
    }

    double Square() override
    {
        double P = (a + b + c) / 2.0;
        double S = sqrt(P * (P - a) * (P - b) * (P - c));
        return S;
    }

    double Perimetr() override
    {
        return a + b + c;
    }

    void info()
    {
        std::cout << "Triangle" << std::endl;
    }
};

int main() {

    Rectangle rect(30, 50);
    Circle circle(30);
    Triangle triangle(30, 40, 50);

    std::cout << "Rectangle square: " << rect.Square() << std::endl;
    std::cout << "Circle square: " << circle.Square() << std::endl;
    std::cout << "Triangle square: " << triangle.Square() << std::endl;
    cout << endl;
    std::cout << "Rectangle perimetr: " << rect.Perimetr() << std::endl;
    std::cout << "Circle perimetr: " << circle.Perimetr() << std::endl;
    std::cout << "Triangle perimetr: " << triangle.Perimetr() << std::endl;
    cout << endl;
    rect.info();
    circle.info();
    triangle.info();
    cout << endl;


    Figure *n[6];
    n[0] = new Rectangle(30, 50);
    n[1] = new Circle (12);
    n[2] = new Triangle (62, 47, 54);
    n[3] = new Rectangle (10, 10);
    n[4] = new Circle (30);
    n[5] = new Triangle (30, 40, 50);

    for (int i = 0; i < 6; ++i)
    {
        n[i]->info();
        cout << " Square = " << n[i]->Square() << endl;
        cout << "Perimetr = " << n[i]->Perimetr() << endl << endl;
    }
    return 0;
}
