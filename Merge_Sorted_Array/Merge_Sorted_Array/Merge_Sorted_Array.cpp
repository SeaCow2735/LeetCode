#include <iostream>
#include <vector>
using namespace std;

void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
    // Create a temporary vector to hold the merged result
    vector<int> result;

    int i = 0, j = 0;

    // Merge the two sorted arrays
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

    // If there are remaining elements in nums1, add them to result
    while (i < m) {
        result.push_back(nums1[i]);
        i++;
    }

    // If there are remaining elements in nums2, add them to result
    while (j < n) {
        result.push_back(nums2[j]);
        j++;
    }

    // Copy the result back to nums1
    nums1 = result;
}

int main() {
    vector<int> nums1 = { 1, 2, 3, 0, 0, 0 };  // Pre-allocated space for nums2
    vector<int> nums2 = { 2, 5, 6 };
    int m = 3, n = 3;

    merge(nums1, m, nums2, n);

    // Output the merged result
    for (int num : nums1) {
        cout << num << " ";
    }

    return 0;
}
