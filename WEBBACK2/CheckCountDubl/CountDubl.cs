using System;

namespace CheckCountDubl
{
    public class CountDubl
    {
        public int Count(string str)
        {
            var alphabets = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            int[] nums = new int[alphabets.Length];
            var tmp = str.ToLower().ToCharArray();

            var counter = 0;
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char item in tmp)
                {
                    for (int i = 0; i < alphabets.Length; i++)
                    {
                        if (item == alphabets[i])
                        {
                            nums[i] += 1;
                        }
                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 1 && nums[i] != 0)
                    {
                        counter += 1;
                    }
                }
                return counter;
            }
            else
                return 0;
        }
    }
}
