#include <bits/stdc++.h>

using namespace std;

class Trans
{
public:
    virtual int Capacity() = 0;
    virtual void info() = 0;
};

class Car : public Trans
{
private:

    string marka = "";
    string number;
    int speed;
    int capacity;

public:
    Car(string w, string n, int s, int c) : marka(w), number(n), speed(s), capacity(c)
    {
    }

    int Capacity() override
    {
        return capacity;
    }

    void info() override
    {
        cout << "Car" << endl;
        cout << "Marka : " << marka << endl;
        cout << "Number : " << number << endl;
        cout << "Speed : " << speed << " km/h" <<endl;
        cout << "Capacity : " << Capacity() <<  " kg" << endl;
    }
};

class Motorcycle : public Trans
{
private:

    string marka = "";
    string number;
    int speed;
    int capacity;
    bool hasKalyaska;

public:
    Motorcycle(string w, string n, int s, int c, bool h) : marka(w), number(n), speed(s), capacity(c), hasKalyaska(h)
    {
    }

    int Capacity() override
    {
        if (hasKalyaska) return capacity;
        else return 0;
    }

    void info() override
    {
        cout << "Motorcycle" << endl;
        cout << "Marka : " << marka << endl;
        cout << "Number : " << number << endl;
        cout << "Speed : " << speed << " km/h" <<endl;
        cout << "Capacity : " << Capacity() <<  " kg" << endl;
    }
};

class Truck : public Trans
{
private:
    string marka = "";
    string number;
    int speed;
    int capacity;
    bool hasPritsep;

public:
    Truck(string w, string n, int s, int c, bool h) : marka(w), number(n), speed(s), capacity(c), hasPritsep(h)
    {
    }

    int Capacity() override
    {
        if (hasPritsep) return capacity * 2;
        else return capacity;
    }

    void info() override
    {
        cout << "Truck" << endl;
        cout << "Marka : " << marka << endl;
        cout << "Number : " << number << endl;
        cout << "Speed : " << speed << " km/h" <<endl;
        cout << "Capacity : " << Capacity() <<  " kg" << endl;
    }
};

int main() {
    Trans *n[6];
    n[0] = new Car("Nissan", "BX0606AH", 140, 120);
    n[1] = new Motorcycle ("Suzuki", "AA0001AO", 210, 20, true);
    n[2] = new Truck ("UAZ", "XM2001AA", 70, 400, true);
    n[3] = new Car ("KIA", "BX0607AH", 150, 240);
    n[4] = new Motorcycle ("Suzuki", "AA7777AO", 199, 99, false);
    n[5] = new Truck ("UAZ", "XM2002AA", 80, 700, false);

    for (int i = 0; i < 6; ++i)
    {
        n[i]->info();
        cout << endl;
    }

    cout << "Enter a minimum capacity you need : ";
    int cap; cin >> cap;
    for (int i = 0; i < 6; ++i)
    {
        if (n[i]->Capacity() >= cap)
        {
            n[i]->info();
            cout << endl;
        }
    }
    return 0;
}
