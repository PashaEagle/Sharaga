#include <iostream>
#include <string.h>
//#include <bits/stdc++.h>
//#include <algorithm>
#include <random>
#include <vector>

#define size 6

using namespace std;

class Tovar
{
public:
    virtual bool check(string s) = 0;
    virtual void info() = 0;
    virtual string getType() = 0;
};

class Toy : public Tovar
{
private:

    string type = "toy";
    string name;
    double price;
    string producer;
    string material;
    int age;

public:
    string getType() override{ return type; }
    Toy(string n, double v, string p, string m, int a) : name(n), price(v), producer(p), material(m), age(a)
    {
    }

    bool check(string s) override
    {
        if (s == type) return true;
        else return false;
    };

    void info() override
    {
        cout << "Type: Toy" << endl;
        cout << "Name: " << name << endl;
        cout << "Price: " << price << endl;
        cout << "Producer: " << producer << endl;
        cout << "Material: " << material << endl;
        cout << "Age: " << age << endl;
        cout << "**********************";
        cout << endl;
    }
};

class Book : public Tovar
{
private:

    string type = "book";
    string name;
    double price;
    string producer;
    string author;
    int age;

public:
    string getType() override{ return type; }
    Book(string n, double v, string p, string m, int a) : name(n), price(v), producer(p), author(m), age(a)
    {
    }

    bool check(string s) override
    {
        if (s == type) return true;
        else return false;
    };

    void info() override
    {
        cout << "Type: Book" << endl;
        cout << "Name: " << name << endl;
        cout << "Price: " << price << endl;
        cout << "Producer: " << producer << endl;
        cout << "Author: " << author << endl;
        cout << "Age: " << age << endl;
        cout << "**********************";
        cout << endl;
    }
};

class Inv : public Tovar
{
private:

    string type = "inv";
    string name;
    double price;
    string producer;
    int age;

public:
    string getType() override{ return type; }
    Inv(string n, double v, string p, int a) : name(n), price(v), producer(p), age(a)
    {
    }

    bool check(string s) override
    {
        if (s == type) return true;
        else return false;
    };

    void info() override
    {
        cout << "Type: Inventory" << endl;
        cout << "Name: " << name << endl;
        cout << "Price: " << price << endl;
        cout << "Producer: " << producer << endl;
        cout << "Age: " << age << endl;
        cout << "**********************";
        cout << endl;
    }
};


int main() {

    Tovar *n[size];
    n[0] = new Toy("Car", 10.10, "LEGO", "iron", 3);
    n[1] = new Book("Book1", 11, "Shelf", "Eastwood", 10);
    n[2] = new Inv("Sport", 100, "Sport", 13);
    n[3] = new Toy("House", 5.80, "LCC", "wood", 3);
    n[4] = new Book("Book2", 112, "Shelf", "Eastwood", 10);
    n[5] = new Inv("Camp", 200, "Sport", 17);

    //InFO
    cout << "There are these tovars:" << endl;
    for (int i = 0; i < size; ++i)
    {
        n[i]->info();
    }


    //Checking
    cout << n[0]->check("toy") << endl;


    //Search
    cout << "Enter type you want to find: (toy, book, inv): ";
    string s;
    cin >> s;

    bool succ = false;
    for (int i = 0; i < size; ++i)
    {
        if (s == n[i]->getType())
        {
            if (!succ)
            {
                succ = true;
                cout << "I find these tovars:" << endl;
            }
            n[i]->info();

        };
    }
    if (!succ) cout << "Nothing..";


    return 0;
}