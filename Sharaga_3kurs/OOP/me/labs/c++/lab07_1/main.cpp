#include <iostream>
#include <bits/stdc++.h>

using namespace std;

int main() {
    priority_queue <int> q;
    q.push(7);
    q.push(10);
    q.push(3);
    q.push(-20);
    q.push(11);

    cout << "Priority queue size = " << q.size() << endl;
    while (!q.empty()){
        cout << q.top() << endl;
        q.pop();
    }

    cout << endl;

    stack <int> s;
    s.push(7);
    s.push(10);
    s.push(3);
    s.push(-20);
    s.push(11);

    cout << "Stack size = " << s.size() << endl;
    while (!s.empty()){
        cout << s.top() << endl;
        s.pop();
    }



    return 0;
}