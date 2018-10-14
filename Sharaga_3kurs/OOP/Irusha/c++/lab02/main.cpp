//#include "stdafx.h"
//#include "Darray.h"
#include "iostream"

using namespace std;

//#pragma once
class Darray
{
    int n, m;
    int **a;

public:
    Darray();
    Darray(int nn, int mm);
    ~Darray();

    void input_k();
    void output_s();
    void sortt();

    int count_of_elts();
    void multiply_by(double x);

    void setN(int nn);
    void setM(int mm);
    void setA(int **b);
    int getN();
    int getM();
    int getA();

    friend Darray operator ++ (Darray x);
    friend Darray operator -- (Darray x);

    operator bool();
    Darray operator * (Darray y);
    //int** operator !(Darray x);
    //I dont understand last task, ask her
};

Darray::Darray(){}

Darray::Darray(int nn, int mm)
{
    n = nn;
    m = mm;
    a = new int*[n];

    for (int i = 0; i < n; ++i)
        a[i] = new int[m];

    for (int i = 0; i < n; i++)
    {// ââîä
        for (int j = 0; j < m; j++)
        {
            cout << "Enter element " << "[" << i << "][" << j << "]  ";
            cin >> a[i][j];
        }
        cout << endl;
    }
};

Darray::~Darray()
{
    //cout << "Object deleted";
}

void Darray::input_k()
{
    cout << "Enter the amount of rows, colnums :";
    int mm, nn;
    cin >> nn >> mm;
    n = nn;
    m = mm;
    a = new int*[n];
    for (int i = 0; i < n; i++)
        a[i] = new int[m];

    for (int i = 0; i < n; i++)
    {// ââîä
        for (int j = 0; j < m; j++)
        {
            cout << "Enter element " << "[" << i << "][" << j << "]  ";
            cin >> a[i][j];
        }
        cout << endl;
    }
}

void Darray::output_s()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            cout << a[i][j] << " ";
        }
        cout << endl;
    }
    cout << endl;
}

void Darray::sortt()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = m - 1; k > j; k--)
                if (a[i][k] > a[i][k - 1])
                {
                    int tmp = a[i][k];
                    a[i][k] = a[i][k - 1];
                    a[i][k - 1] = tmp;
                }
            //cout << "\t" << "a=" << a[i][j] << "\n";
        }
    }

    cout << "Sorted : " << endl;
    output_s();
}

int Darray::count_of_elts()
{
    return m * n;
}

void Darray::multiply_by(double x)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            a[i][j] *= x;
        }
    }
    cout << "Successfully multiplied" << endl;
}

void Darray::setN(int nn) { n = nn; }

void Darray::setM(int mm) { m = mm; }

void Darray::setA(int **b) { a = b; }

int Darray::getN() { return n; }

int Darray::getM() { return m; }

int Darray::getA() { return **a; }

Darray operator ++ (Darray x)
{
    for (int i = 0; i < x.getN(); i++)
    {
        for (int j = 0; j < x.getM(); j++)
        {
            x.a[i][j] += 1;
        }
    }
}

Darray operator -- (Darray x)
{
    for (int i = 0; i < x.getN(); i++)
    {
        for (int j = 0; j < x.getM(); j++)
        {
            x.a[i][j] -= 1;
        }
    }
}

Darray::operator bool()
{
    bool checker = true;
    for (int i = 0; i < this->getN(); i++)
    {
        for (int j = 1; j < this->getM(); j++)
        {
            if (this->a[i][j] < this->a[i][j - 1]) {checker = false; break;}
        }
    }
    return checker;
}

Darray Darray::operator * (Darray y)
{
    if (this->getM() != y.getM() || this->getN() != y.getN()){cout << "Cannot multiply"; return *this;}
    for (int i = 0; i < this->getN(); i++)
    {
        for (int j = 0; j < this->getM(); j++)
        {
            this->a[i][j] *= y.a[i][j];
        }
    }
    return *this;
}

/*
Darray::(**int) operator !(Darray x)
{
    return x.a;
}*/

// lab1_2.cpp : Defines the entry point for the console application.
//

int main()
{

    //***********************

    /*Adress::Adress(const Adress &obj)
    {
        this->name = obj->name;
        this->street = obj->street;
    }
    */
    //***********************

    Darray masyv;
    Darray s1(2, 2);
    masyv.input_k();
    masyv.output_s();
    //masyv.sortt();
    cout << "Amount of elements is " << masyv.count_of_elts() << endl;
    //masyv.multiply_by(2);
    masyv.output_s();

    ++masyv;
    masyv.output_s();

    --masyv;
    masyv.output_s();

    //peregruzka bool
    cout << "Masyv sorted in upper ? Answer: " <<  masyv << endl;

    //peregruzka *
    masyv = masyv * s1;
    masyv.output_s();


    //system("Pause");
    return 0;
}