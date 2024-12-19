#include <iostream>
#include <vector>
using namespace std;

void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
  
    vector<int> result;

    int i = 0, j = 0;

   
    while (i < m && j < n) {
        if (nums1[i] < nums2[j]) {
            result.push_back(nums1[i]);
            i++;
        }
        else {
            result.push_back(nums2[j]);
            j++;
        }
    }

  
    while (i < m) {
        result.push_back(nums1[i]);
        i++;
    }

   
    while (j < n) {
        result.push_back(nums2[j]);
        j++;
    }

 
    nums1 = result;
}

int main() {
    vector<int> nums1 = { 1, 2, 3, 0, 0, 0 };  
    vector<int> nums2 = { 2, 5, 6 };
    int m = 3, n = 3;

    merge(nums1, m, nums2, n);

    
    for (int num : nums1) {
        cout << num << " ";
    }

    return 0;
}
