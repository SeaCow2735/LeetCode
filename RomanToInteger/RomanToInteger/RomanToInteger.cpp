#include <iostream>
#include <string>
using namespace std;

int romanToInt(string s) {
    int num = 0;
    for (int i = s.size() - 1; i >= 0; i--) {
        switch (s[i]) {
        case 'I':
            num += 1;
            break;
        case 'V':
            if (i > 0 && s[i - 1] == 'I') {
                num += 4;
                i--; 
            }
            else {
                num += 5;
            }
            break;
        case 'X':
            if (i > 0 && s[i - 1] == 'I') {
                num += 9;
                i--; 
            }
            else {
                num += 10;
            }
            break;
        case 'L':
            if (i > 0 && s[i - 1] == 'X') {
                num += 40;
                i--; 
            }
            else {
                num += 50;
            }
            break;
        case 'C':
            if (i > 0 && s[i - 1] == 'X') {
                num += 90;
                i--; 
            }
            else {
                num += 100;
            }
            break;
        case 'D':
            if (i > 0 && s[i - 1] == 'C') {
                num += 400;
                i--; 
            }
            else {
                num += 500;
            }
            break;
        case 'M':
            if (i > 0 && s[i - 1] == 'C') {
                num += 900;
                i--; 
            }
            else {
                num += 1000;
            }
            break;
        default:
            cout << "Invalid character in Roman numeral: " << s[i] << endl;
            return -1;
        }
    }
    return num;
}

int main() {
    cout << "nhap vao day so La Ma: ";
    string s;
    getline(cin, s);
    int result = romanToInt(s);
    if (result != -1) {
        cout << "Gia tri so nguyen la: " << result << endl;
    }
    return 0;
}
