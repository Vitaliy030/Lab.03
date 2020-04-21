using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("D:\\ІТ\\Програмування\\Програми\\Lab.3\\ConsoleApp3\\input.txt");
            string s = f.ReadLine();
            f.Close();
            s = s.Trim();
            char[] s0 = {'.', ',', '?', '!' };

            int t0 = 0;
            bool t = true;
            bool a = true;
            while (a)
            {
                for (int i = 0; i < s.Length; ++i)
                    if (char.IsWhiteSpace(s[i]))
                        if (i + 1 < s.Length)
                        {
                            if (char.IsWhiteSpace(s[i + 1]))
                            {
                                s = s.Remove(i + 1, 1);
                                ++i;
                            }
                            else
                            {
                                for (int j = 0; j < 4; ++j)
                                    if (i + 1 < s.Length)
                                        if (s[i + 1] == s0[j])
                                        {
                                            s = s.Remove(i, 1);
                                            ++i;
                                        }
                            }
                        }

                int[] h = new int[s.Length];
                int r = 0;
                for (int i = 0; i < s.Length; ++i)
                    if (char.IsWhiteSpace(s[i]))
                    {
                        h[r] = i;
                        r++;
                    }
                for (int i = 0; i < r; ++i)
                    if (h[i] + 1 != h[i + 1])
                        t = false;
                    else
                    {
                        a = true;
                        t = true;
                        break;
                    }

                if (!t)
                {
                    t = true;
                    ++t0;
                    if (t0 == 2)
                        a = false;
                }
            }

            File.WriteAllText(Path.Combine("D:\\ІТ\\Програмування\\Програми\\Lab.3\\ConsoleApp3", "output.txt"), s);
            Console.WriteLine("З тексту видалено всi непотрiбнi пробiли.");
        }
    }
}
