#include <iostream>
#include <string>
using namespace std;
string addBinary(string a, string b) {
    string result = "";
    int carry = 0;
    int i = a.size() - 1, j = b.size() - 1;

    
    while (i >= 0 || j >= 0 || carry > 0) {
        int digitA = (i >= 0) ? a[i] - '0' : 0;
        int digitB = (j >= 0) ? b[j] - '0' : 0; 

        int sum = digitA + digitB + carry; 
        carry = sum / 2;                   
        result += (sum % 2) + '0';         

        
        i--;
        j--;
    }

    
    reverse(result.begin(), result.end());

    return result;
}
int main() {
    string a = "11", b = "1";
    cout << addBinary(a, b) << endl; 

    a = "1010", b = "1011";
    cout << addBinary(a, b) << endl; 

    return 0;
}

