using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            var alphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray();
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
                Console.WriteLine(counter);
                Console.ReadLine();
            }
            else
                Console.WriteLine(0);
                Console.ReadLine();

        }
    }
}
