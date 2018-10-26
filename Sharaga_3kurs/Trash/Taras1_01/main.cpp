#include <bits/stdc++.h>

using namespace std;

class Product
{
	private:
		char *name =  "defaultName";
		char *code = "defaultCode";
		int amount = 0;

	public:
		Product();
		Product(char *n, char* c, int m);
		//Product(const Product &obj);
		~Product();

		void input();
		void output();
		void setName(char *n);
		char* getName();
		void setCode(char *c);
		char* getCode();
		void setAmount(int m);
		int getAmount();
};

Product::Product(){};

Product::Product(char *n, char *c, int m)
{
    setName(n);
    setCode(c);
    setAmount(m);
}

Product::~Product(){cout << "Object " << name << " deleted" << endl;};

//Product::Product(const Product &obj){};

void Product::input()
{
	char *n = new char[20];
	char *c = new char[20];
	int m;
	int i = 0;

	while (i < 1)
	{
		try
		{
			cout << "Enter name: ";
			cin >> n;
			setName(n);

			cout << "Enter code: ";
			cin >> c;
			setCode(c);

			cout << "Enter amount >> ";
			cin >> m;
			setAmount(m);
		}
		catch(exception e)
		{
			cout << "Please, again..";
			continue;
		}
		++i;
	}
}

void Product::output()
{
	cout << "Name : " << this->name << endl;
	cout << "Code : " << this->code << endl;
	cout << "Amount : " << this->amount << endl;
}

void Product::setName(char *n)
{
    string str = n;
	if (str.length() > 20 || find_if(str.begin(), str.end(), ::isdigit) != str.end())
	{
		cout << "Incorrect name" << endl;
	}
	else name = n;
}

char* Product::getName()
{
	return name;
}

void Product::setCode(char *c)
{
	string str = c;
	if (str.length() > 20)
	{
		cout << "Incorrect code" << endl;
	}
	else code = c;
}

char* Product::getCode()
{
	return code;
}

void Product::setAmount(int m)
{
	if (m >= 0) amount = m; else cout << "Incorrect amount" << endl;
}

int Product::getAmount()
{
	return amount;
}

int main()
{
    Product s1;
    Product s2("Vasya", "Shifr1", 3);

    cout << s1.getName() << endl;
    cout << s1.getCode() << endl;
    cout << s1.getAmount() << endl; cout << endl;

    cout << s2.getName() << endl;
    cout << s2.getCode() << endl;
    cout << s2.getAmount() << endl; cout << endl;

    s1.setName("Petya");
    cout << s1.getName() << endl; cout << endl;

    s1.input();
    s1.output();
    cout << endl;
    s2.output();

    Product s3;
    s3 = s2;


    /*s1.setCode(8);
    cout << s1.getCode() << endl;*/

    return 0;
}
