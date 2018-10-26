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

        void operator ++();
        void operator --();
        Money operator + (int z);
        bool operator ! ();
        operator string();

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

void Money::operator ++()
{
    ++first; ++second;
}

void Money::operator --()
{
    --first; --second;
}

Money Money::operator + (int z)
{
    return Money(this->first, this->second + z);
}

bool Money::operator ! ()
{
    if (second != 0) return true;
    else return false;
}

Money::operator string()
{
    return string("First = " + to_string(first) + ", second = " + to_string(second) + "\n");
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

    ++p1;
    p1.show();

    --p1;
    p1 = p1 + 5;
    p1.show();

    if (!p1) cout << "second is not 0";
    else cout << "second is 0";
    cout << endl;

    cout << string(p1);

    return 0;
}
