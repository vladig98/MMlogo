using System;
using System.Linq;

namespace MMLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 0;
            int limit = (int)Math.Ceiling(n / 2.0);
            int k = 1;

            for (int i = n; i >= 0; i--)
            {
                string dashBeginning = new string('-', i);
                string starsBeginning = i < limit ? new string('*', n) : new string('*', n + j);
                string dashMiddle = i < limit ? null : new string('-', n - j);
                string starsBetweenStars = i < limit ? new string('*', i + j + 2) : null;
                string dashMiddleMiddle = new string('-', i * 2);
                string dashesBetweenStars = i < limit ? new string('-', k) : null;
                k = i < limit ? k + 2 : k;
                string beginning = dashBeginning + starsBeginning + dashesBetweenStars + starsBetweenStars + dashesBetweenStars + dashMiddle + starsBeginning;
                string end = string.Join("", beginning.ToCharArray().Reverse());
                Console.WriteLine(beginning + dashMiddleMiddle + end);
                j = i < limit ? j - 1 : j + 2;
            }
        }
    }
}
