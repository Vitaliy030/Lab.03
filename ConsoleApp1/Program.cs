using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть рядок символiв:");
            string s = Console.ReadLine();

            char[] s0 = { ' ', '*', '+', '-', '/', '.', ',', '?', '!' };
            int t = 0;
            foreach (char a in s)
                foreach (char b in s0)
                    if (a == b)
                        t++;
            int[] h = new int[t+2];
            int i = -1;
            int j = 0;
            foreach (char a in s)
            {
                ++i;
                foreach (char b in s0)
                    if (a == b)
                    {
                        h[j] = i;
                        ++j;
                    }
            }
            if (j != 0)
            {
                if (h[j - 1] + 1 < s.Length)
                    h[j] = s.Length;
            }
            else
                h[0] = s.Length;
            int[] v = new int[t+1];
            int k = 0;
            i = 0;
            j = 0;
            foreach (char a in s)
            {
                ++k;
                ++i;
                if (i == h[j])
                {
                    v[j] = k;
                    ++j;
                    k = -1;
                }
            }
            k = 0;
            for (int i1 = 0; i1 < j; ++i1)
                if (v[i1] % 2 != 0)
                    ++k;
            Console.WriteLine("\nКiлькiсть слiв, якi мають непарну довжину: " + k + "\n");

            s = s.Replace(" ", "").Replace("*", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").ToUpper();
            char[] x = new char[s.Length];
            k = 0;
            i = -1;
            bool f = true;
            x[0] = s[0];
            foreach (char a in s)
            {
                ++i;
                foreach (char b in s)
                    if (a == b)
                        ++k;
                if (i == 0)
                    Console.WriteLine("Частота входження лiтери ({0}): " + k, a);
                else
                {
                    for (int i1 = 0; i1 < i + 1; ++i1)
                        if (a != x[i1])
                            f = true;
                        else
                        {
                            f = false;
                            break;
                        }
                    if (f)
                    {
                        x[i] = a;
                        Console.WriteLine("Частота входження лiтери ({0}): " + k, a);
                    }
                }
                k = 0;
            }

        }
    }
}
