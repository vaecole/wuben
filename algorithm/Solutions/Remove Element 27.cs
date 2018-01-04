namespace algorithm.Solutions
{
    public class Remove_Element_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int length = nums.Length;
            if (length == 0)
            {
                return 0;
            }
            int valPos = length;

            int t = 0;
            for (int i = 0; i < length && valPos > i; i++)
            {
                if (nums[i] == val)
                {
                    while (nums[valPos - 1] == val)
                    {
                        valPos--;
                        if (valPos <= i)
                        {
                            return valPos;
                        }
                    }
                    t = nums[i];
                    nums[i] = nums[valPos - 1];
                    nums[valPos - 1] = t;
                }
            }
            return valPos;
        }
    }
}
