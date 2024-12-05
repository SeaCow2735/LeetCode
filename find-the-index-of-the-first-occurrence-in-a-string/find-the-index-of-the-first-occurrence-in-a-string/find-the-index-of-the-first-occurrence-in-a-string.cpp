#include <iostream>
#include <string>
using namespace std;
int strStr(string haystack, string needle) {
    int i;
    int first_index =-2;
    string val = "";
    for (i = 0; i < haystack.size(); i++) 
    {
      
        val = haystack.substr(i, needle.size());
        if (needle.compare(val) == 0)
        {
            if(i<=first_index or first_index==-2)
                first_index = i;
        }    
    }
    if (first_index != -2)
        return first_index;
    else
        return -1;

}

int main()
{
    string haystack, needle;

    // Test case 1
    haystack = "hello";
    needle = "ll";
    cout << "Input: haystack = \"" << haystack << "\", needle = \"" << needle << "\"" << endl;
    cout << "Output: " << strStr(haystack, needle) << endl;

    // Test case 2
    /*haystack = "aaaaa";
    needle = "bba";
    cout << "Input: haystack = \"" << haystack << "\", needle = \"" << needle << "\"" << endl;
    cout << "Output: " << strStr(haystack, needle) << endl;*/

    // Test case 3
   /* haystack = "";
    needle = "";
    cout << "Input: haystack = \"" << haystack << "\", needle = \"" << needle << "\"" << endl;
    cout << "Output: " << strStr(haystack, needle) << endl;*/

    // Test case 4
   /* haystack = "abc";
    needle = "c";
    cout << "Input: haystack = \"" << haystack << "\", needle = \"" << needle << "\"" << endl;
    cout << "Output: " << strStr(haystack, needle) << endl;*/

    return 0;
}

