#include <iostream>
#include <bits/stdc++.h>

using namespace std;

class B1 {
    public:
        B1() { cout << "Initialize B1" << endl; }
        ~B1() { cout << "Destroying B1" << endl; }
};

class B2 {
    public:
        B2() { cout << "Initialize B2" << endl; }
        ~B2() { cout << "Destroying B2" << endl; }
};

class B3 {
public:
    B3() { cout << "Initialize B3" << endl; }
    ~B3() { cout << "Destroying B3" << endl; }
};

class D1 : protected B1, public B2 {
    public:
         D1() { cout << "Initialize D1" << endl; }
        ~D1(){ cout << "Destroying D1" << endl; }
};

class D2 : protected B3, public D1 {
    public:
        D2() { cout << "Initialize D2" << endl; }
        ~D2(){ cout << "Destroying D2" << endl; }
};

class D3 : public D2 {
    public:
        D3() { cout << "Initialize D3" << endl; }
        ~D3() { cout << "Destroying D3" << endl; }
};



int main() {
    D3 d3;
    return 0;
}