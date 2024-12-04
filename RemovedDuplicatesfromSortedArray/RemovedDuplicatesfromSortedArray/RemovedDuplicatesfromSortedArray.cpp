#include <iostream>
#include <vector>
using namespace std;

int removeDuplicates(vector<int>& nums) {
    if (nums.empty()) return 0;

    int k = 1;
    for (int i = 1; i < nums.size(); i++) {
        if (nums[i] != nums[k - 1]) { 
            nums[k] = nums[i];
            k++;
        }
    }
    return k;
}

int main() {
   
    vector<int> nums1 = { 1, 1, 2 };
    int k1 = removeDuplicates(nums1);
    cout << "Output: " << k1 << ", nums = [";
    for (int i = 0; i < nums1.size(); i++) {
        if (i < k1) cout << nums1[i];
        else cout << "_";
        if (i < nums1.size() - 1) cout << ", ";
    }
    cout << "]" << endl;

    
    vector<int> nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
    int k2 = removeDuplicates(nums2);
    cout << "Output: " << k2 << ", nums = [";
    for (int i = 0; i < nums2.size(); i++) {
        if (i < k2) cout << nums2[i];
        else cout << "_";
        if (i < nums2.size() - 1) cout << ", ";
    }
    cout << "]" << endl;

    return 0;
}
