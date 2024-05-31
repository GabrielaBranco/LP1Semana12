using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                bool isPalindrome = CheckPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        public static bool CheckPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Missing input!");
            }
            if (input.Length < 2)
            {
                return true;
            }

            bool IsPalindrome(string word)
            {
                int start = 0;
                int end = word.Length - 1;

                while (start < end)
                {
                    if (word[start] != word[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }

            return IsPalindrome(input);
        }
    }
}
