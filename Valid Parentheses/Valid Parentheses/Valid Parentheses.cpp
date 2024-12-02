#include <iostream>
#include <string>
#include <stack>
using namespace std;

bool isValid(string s) {
    stack<char> stk;

    for (char c : s) {
   
        if (c == '(' || c == '{' || c == '[') {
            stk.push(c);
        }
        else if (c == ')' || c == '}' || c == ']') {
            
            if (stk.empty()) {
                return false; 
            }
            char top = stk.top();
            if ((c == ')' && top == '(') ||
                (c == '}' && top == '{') ||
                (c == ']' && top == '[')) {
                stk.pop(); 
            }
            else {
                return false; 
            }
        }
    }

   
    return stk.empty();
}

int main() {
    string s;
    cout << "Nhap vao chuoi ky tu: ";
    getline(cin, s);

    if (isValid(s))
        cout << "Ket qua la: true" << endl;
    else
        cout << "Ket qua la: false" << endl;

    return 0;
}
