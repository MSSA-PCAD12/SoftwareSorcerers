namespace CodeWars
{
    public class SumTwoLowestNumbersKata
    {
        public static int SumTwoNumbers(int[] nums)
        {
            // sort the array from lowest to highest
            Array.Sort(nums);

            // return the sum
            return nums[0] + nums[1];
        }
    }
}
