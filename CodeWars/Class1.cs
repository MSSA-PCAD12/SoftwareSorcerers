namespace CodeWars
{
    public class SumTwoLowestNumbers
    {
        public static int sumTwoLowestNumbers(int[] nums)
        {
            // sort the array from lowest to highest
            Array.Sort(nums);

            // return the sum
            return nums[0] + nums[2];
        }
    }
}
