#include <iostream>
#include <bits/stdc++.h>

using namespace std;

class Wheels
{
    public:
        int amount;
        virtual void Info() = 0;
};

class Yamaha : public Wheels
{
    private:
        int amount;
    
    public:
        Yamaha(int amount)
        {
            this->amount = amount;
        }

        void Info()
        {
            cout << "Wheels Yamaha, amount " << amount << endl;
        }

};

class BBC : public Wheels
{
    private:
        int amount;
    
    public:
        BBC(int amount)
        {
            this->amount = amount;
        }
    
        void Info()
        {
            cout << "Wheels BBC, amount " << amount << endl;
        }
};

class Engine
{
    private:
        int power;
    
    public: Engine(int power)
        {
            this->power = power;
        }
        void Info()
        {
            cout << "Engine power = " << power << endl;
        }
};

class Body
{
    private:
        string color;

    public:
        Body(string color)
        {
            this->color = color;
        }


        void Info()
        {
            cout << "Body color = " << color << endl;
        }
};

class Car_Agregation
{
private:
    Wheels *wheels;
    Engine *engine;
    Body *body;

public:
    Car_Agregation(Wheels *wheels, Engine *engine, Body *body) {
        this->wheels = wheels;
        this->engine = engine;
        this->body = body;
    }

    void Info()
    {
        cout << "\tCar Agregation:\n" << endl;
        wheels->Info();
        engine->Info();
        body->Info();
        cout << endl << endl;
    }
};

class Car_Composition
{
private:
    Wheels *wheels;
    Engine *engine;
    Body *body;

public:
    Car_Composition()
    {
        wheels = new BBC(4);
        //wheels = new Yamaha(7);

        engine = new Engine(400);
        body = new Body("Red");
    }

    void Info()
    {
        cout << "\tCar Composition:\n" << endl;
        wheels->Info();
        engine->Info();
        body->Info();
        cout << endl << endl;    }
};




int main() {

    Wheels *w = new Yamaha(5);
    //Wheels *w2 = new BBC(7);
    Engine *e = new Engine(500);
    Body *b = new Body("Blue");

    Car_Agregation *carAgregation = new Car_Agregation(w, e, b);
    carAgregation->Info();

    Car_Composition *carComposition = new Car_Composition();
    carComposition->Info();
    return 0;
}