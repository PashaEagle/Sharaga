#include <bits/stdc++.h>

using namespace std;

class Money
{
    private:
        int first = 0;
        int second = 0;
        //int _x{ set; get; }
    public:
        Money();
        Money(int first, int second);
        ~Money(){cout << "Object deleted" << endl;};

        void show();
        void isEnough();
        int howMany();

        void setFirst(int n);
        void setSecond(int n);

        int getSum();

};


Money::Money(){};

Money::Money(int x, int y)
{
    this->first = x;
    this->second = y;
};

void Money::show()
{
	cout << "Nominal: " << this->first << endl;
	cout << "Kilkist: " << this->second << endl;
};

void Money::isEnough()
{
    int n;
    int sum = this->first * this->second;
    cout << "Enter price to check >> ";
    cin >> n;
    if (sum >= n){cout << "You can buy this product" << endl;}
    else cout << "You can not buy this product." << endl;
}

int Money::howMany()
{
    int n;
    int sum = this->first * this->second;
    cout << "Enter price to check >> ";
    cin >> n;
    int kst = sum / n;
    return kst;
}

void Money::setFirst(int n)
{
    this->first = n;
}

void Money::setSecond(int n)
{
    this->second = n;
}

int Money::getSum()
{
    return (this->first * this->second);
}

int main()
{
    Money p1;
    Money p2(5, 6);

    cout << p1.getSum() << endl;
    cout << p2.getSum() << endl;

    p1.setFirst(4);
    p1.setSecond(2);
    p1.show();

    p2.isEnough();
    cout << "You can buy " << p1.howMany() << " this products" << endl;

    return 0;
}
