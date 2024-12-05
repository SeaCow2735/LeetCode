#include <iostream>
#include <vector>
using namespace std;
int removeElement(vector<int>& nums, int val) {
    if (nums.size() == 0)
        return 0;
    int k = 0;
    for ( int i = 0; i < nums.size(); i++)
    {
       if (nums[i] != val)
       {
           nums[k] = nums[i];
           k++;
       }
    }
    return k;
}
int main()
{
    vector<int> nums1 = { 1,2,3,3,3,3,4,4 };
    int value = 3;
    int k1 = removeElement(nums1, value);
    cout << "Output: " << k1 << ", nums = [";
    for (int i = 0; i < nums1.size(); i++) {
        if (i < k1) cout << nums1[i];
        else cout << "_";
        if (i < nums1.size() - 1) cout << ", ";
    }
    cout << "]" << endl;

}
