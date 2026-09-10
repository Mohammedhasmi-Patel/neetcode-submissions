public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length==0) return 0;
        Array.Sort(nums);
        int highestCon = 1;
        int current = 1;

        for(int i=1;i<nums.Length;i++){
            if(nums[i]-nums[i-1] == 1){
                current++;
                highestCon = Math.Max(current,highestCon);

            } else if (nums[i]-nums[i-1] == 0) continue;
            
            else{
                highestCon = Math.Max(current,highestCon);
                current = 1;
            }
        }

        return highestCon;
    }
}
