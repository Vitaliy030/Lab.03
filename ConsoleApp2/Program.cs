using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("D:\\ІТ\\Програмування\\Програми\\Lab.3\\ConsoleApp2\\111.txt");
            string s = f.ReadLine();
            int i = -1;
            int j = 0;

            string x1;
            int x0;
            int sum = 0;
            int k = 0;
            foreach (char a in s)
            {
                ++i;
                ++j;
                if (char.IsWhiteSpace(a) || i == s.Length - 1)
                {
                    char[] x = s.ToCharArray(k, j);
                    x1 = new string(x);
                    x0 = Convert.ToInt32(x1);
                    sum += x0;
                    j = 0;
                    k = i + 1;
                }
            }
            Console.WriteLine("Сума елементiв масиву: " + sum);
        }
    }
}
