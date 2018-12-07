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
		char* getName() const;
		void setCourse(int c);
		int getCourse() const;
		void setGender(bool m);
		bool getGender() const;
};

Student::Student(){};

Student::Student(char *n, int c, bool m)
{
    setName(n);
    setCourse(c);
    setGender(m);
}

Student::~Student(){/*cout << "Object " << name << " deleted" << endl;*/};

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

char* Student::getName() const
{
	return name;
}

void Student::setCourse(int c)
{
	c > 0 && c < 5 ? course = c : course = -1;
	if (course == -1) cout << "Incorrect course" << endl;
}

int Student::getCourse() const
{
	return course;
}

void Student::setGender(bool m)
{
	if (m == 1 || m == 0) man = m; else cout << "Incorrect gender" << endl;
}

bool Student::getGender() const
{
	return man;
}

bool operator<(const Student& lhs, const Student& rhs)
{
    return lhs.getCourse() < rhs.getCourse();
}

int main()
{
    Student s1("Petya", 2, true);
    Student s2("Vasya", 3, true);
    Student s3("Kolya", 1, true);
    Student s4("Lena", 1, false);

    priority_queue <Student> q;
    q.push(s1);
    q.push(s2);
    q.push(s3);
    q.push(s4);

    cout << "Priority queue size = " << q.size() << endl;
    int i = 1;
    while (!q.empty()){
        cout << i++ << " element:" << endl;
        cout << q.top().getName() << endl;
        cout << "Course : " << q.top().getCourse() << endl;
        cout << "Man: " << q.top().getGender() << endl << endl;
        q.pop();
    }

    cout << endl;

    stack <Student> s;
    s.push(s1);
    s.push(s2);
    s.push(s3);
    s.push(s4);

    cout << "Stack size = " << s.size() << endl;
    i = 1;
    while (!s.empty()){
        cout << i++ << " element:" << endl;
        cout << s.top().getName() << endl;
        cout << "Course : " << s.top().getCourse() << endl;
        cout << "Man: " << s.top().getGender() << endl << endl;
        s.pop();
    }




    /*s1.setCourse(8);
    cout << s1.getCourse() << endl;*/

    return 0;
}
