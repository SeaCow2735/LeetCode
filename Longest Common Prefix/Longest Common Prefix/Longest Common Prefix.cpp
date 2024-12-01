#include <iostream>
#include <string>
#include <vector>
using namespace std;

string LongestCommonPrefix(vector<string>& strs) {
    if (strs.empty()) return ""; // Trả về chuỗi rỗng nếu vector trống.

    string prefix = strs[0]; // Lấy chuỗi đầu tiên làm cơ sở so sánh.

    for (size_t i = 1; i < strs.size(); ++i) {
        // Thu hẹp prefix cho đến khi nó là tiền tố của strs[i].
        while (strs[i].find(prefix) != 0) {
            prefix = prefix.substr(0, prefix.size() - 1); // Cắt bỏ ký tự cuối.
            if (prefix.empty()) return ""; // Không tìm thấy tiền tố chung.
        }
    }
    return prefix;
}

int main() {
    vector<string> strs = { "flower", "flow", "flight" };
    string result = LongestCommonPrefix(strs);
    cout << "Longest Common Prefix: " << result << endl; // Output: "fl"
    return 0;
}
