using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string ans = "";
                if (i % 3 == 0)
                    ans += "Fizz";
                if (i % 5 == 0)
                    ans += "Buzz";
                if (ans == "")
                    ans = i.ToString();
                Console.WriteLine(ans);
            }
        }
    }
}
