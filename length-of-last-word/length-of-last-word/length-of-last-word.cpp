#include <iostream>
#include <string>
using namespace std;
    int lengthOfLastWord(string s) {
        string sub;
        while (s[0] == ' ')
        {
            s.erase(0, 1);
        }
        while (s[s.size() - 1] == ' ')
        {
            s.erase(s.size() - 1, 1);
        }
        for (int i = 0; i < s.size(); i++)
        {
            if (s[i] == ' ' and s[i + 1] == ' ')
            {
                s.erase(i, 1);
            }
        }
        for (int i = s.size() - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                sub = s.substr(i + 1, s.size() - i);
                break;
            }
            else
            {
                sub = s;
            }
        }
        return sub.size();
    }
int main()
 {
    string s;
    getline(cin, s);
    cout << lengthOfLastWord(s) << endl;

 }
