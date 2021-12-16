using System;
namespace Palindrom

{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter string: ");

            string name = Console.ReadLine();
            if (isPalindrom(name))
            {

                Console.WriteLine($"Palindromi is - {name}");

            }

            else
            {

                Console.WriteLine($"Palindromi is not {name}");

            }

        }
        static bool isPalindrom(string text)
        {

            string reverse = Reverse(text);

            if (text == reverse)
            {

                return true;

            }

            return false;
        }
        static string Reverse(string text)
        {

            string reverse = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {

                reverse += text[i];

            }
            return reverse;
        }

    }

}
