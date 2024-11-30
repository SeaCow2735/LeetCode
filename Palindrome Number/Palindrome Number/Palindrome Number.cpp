#include <iostream>
#include <string>
using namespace std;

class Solution {
public:
    bool isPalindrome(int x) {
        string str_x = to_string(x);

        for (int i = 0; i < str_x.length() / 2; i++) {
            if (str_x[i] != str_x[str_x.length() - i - 1]) {
                return false;
            }
        }

        return true;
    }
};

int main() {
    int x;
    cout << "Enter x: ";
    cin >> x;

    Solution solution; 
    if (solution.isPalindrome(x)) {
        cout << "success" << endl;
    }
    else {
        cout << "fail" << endl;
    }

    return 0;
}
