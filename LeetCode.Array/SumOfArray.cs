namespace LeetCode.Array;

public static class SumOfArray
{
    public static int[] RunningSum(int[] nums)
    {
        if(nums.Length == 1) {
            nums[0] += nums[0];
            return nums; 
        }
        for(var i=0; i < nums.Length; i++){
            if(i>0){
                nums[i] += nums[i-1];
            }
          
        }
        return nums;
    }
}