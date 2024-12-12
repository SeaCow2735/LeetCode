#include <iostream>
using namespace std;
int climbStairs(int n) {
    if (n <= 2) return n;

    int first = 1, second = 2;
    for (int i = 3; i <= n; ++i) {
        int current = first + second;
        first = second;
        second = current;
    }
    return second;
}
int main()
{
    int n;
    cin >> n;
    int result = climbStairs(n);
    cout << result;
}

