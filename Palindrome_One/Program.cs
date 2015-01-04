using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_One
{
    class Palindrom
    {
        public static bool IsPulindrome(string word)
        {
            int minLength = 0;
            int maxLength = word.Length - 1;
            while (true)
            {
                if (minLength > maxLength)
                {
                    return true;
                }
                char a = word[minLength];
                char b = word[maxLength];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                minLength++;
                maxLength--;
            }
        }
        static void Main(string[] args)
        {
            string[] palindromeWord = { "Alula", "Anana","Level","Dhaka","Devoved","Evitetive","History","Apple","" };
            foreach (string word in palindromeWord)
            {
                if (IsPulindrome(word))
                {
                    Console.WriteLine(word + "\tIs a palindrome word");
                }
                else
                {
                    Console.WriteLine(word  + "\tIs not a palindrome word");
                }
            }
            Console.ReadKey();
        }
    }
}
