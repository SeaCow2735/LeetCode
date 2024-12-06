class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        int index = -1;
        for (int i = 0; i < nums.size(); i++)
        {
            if (nums[i] == target)
            {
                index = i;
            }
        }
        if (index != -1)
            return index;
        else
        {
            for (int i = 0; i < nums.size(); i++)
            {
                if (nums[i] > target)
                {
                    return index = i;
                    break;
                }
                else
                {
                    index = nums.size();
                }
            }
        }
        return index;
    }

};