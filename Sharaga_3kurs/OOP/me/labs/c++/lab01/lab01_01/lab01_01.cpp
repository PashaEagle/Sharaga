#include <iostream>
#include <string>
#include <bits/stdc++.h>
#include <cstdlib>
#include <iomanip>
#include <algorithm>
#include <random>
#include <vector>

using namespace std;

class Student
{
	private:
		char *name =  "defaultName";
		int course = -1;
		bool man = 0;

	public:
		Student();
		Student(char *n, int c, bool m);
		//Student(const Student &obj);
		~Student();

		void input();
		void output();
		void setName(char *n);
		char* getName();
		void setCourse(int c);
		int getCourse();
		void setGender(bool m);
		bool getGender();
};

Student::Student(){};

Student::Student(char *n, int c, bool m)
{
    setName(n);
    setCourse(c);
    setGender(m);
}

Student::~Student(){cout << "Object " << name << " deleted" << endl;};

//Student::Student(const Student &obj){};

void Student::input()
{
	char *n = new char[20];
	int c;
	bool m;
	int i = 0;

	while (i < 1)
	{
		try
		{
			cout << "Enter name: ";
			cin >> n;
			setName(n);

			cout << "Enter course: ";
			cin >> c;
			setCourse(c);

			cout << "Is it man (1) or woman (0)";
			cin >> m;
			setGender(m);
		}
		catch(exception e)
		{
			cout << "Please, again..";
			continue;
		}
		++i;
	}
}

void Student::output()
{
	cout << "Name : " << this->name << endl;
	cout << "Course : " << this->course << endl;
	cout << "Man : " << this->man << endl;
}

void Student::setName(char *n)
{
    string str = n;
	if (str.length() > 20 || find_if(str.begin(), str.end(), ::isdigit) != str.end())
	{
		cout << "Incorrect name" << endl;
	}
	else name = n;
}

char* Student::getName()
{
	return name;
}

void Student::setCourse(int c)
{
	c > 0 && c < 5 ? course = c : course = -1;
	if (course == -1) cout << "Incorrect course" << endl;
}

int Student::getCourse()
{
	return course;
}

void Student::setGender(bool m)
{
	if (m == 1 || m == 0) man = m; else cout << "Incorrect gender" << endl;
}

bool Student::getGender()
{
	return man;
}

int main()
{
    Student s1;
    Student s2("Vasya", 3, true);

    cout << s1.getName() << endl;
    cout << s1.getCourse() << endl;
    cout << s1.getGender() << endl; cout << endl;

    cout << s2.getName() << endl;
    cout << s2.getCourse() << endl;
    cout << s2.getGender() << endl; cout << endl;

    s1.setName("Petya");
    cout << s1.getName() << endl; cout << endl;

    s1.input();
    s1.output();
    cout << endl;
    s2.output();

    Student s3;
    s3 = s2;


    /*s1.setCourse(8);
    cout << s1.getCourse() << endl;*/

    return 0;
}
