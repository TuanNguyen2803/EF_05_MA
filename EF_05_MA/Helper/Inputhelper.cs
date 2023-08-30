using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EF_05_MA.Helper
{
    internal class Inputhelper
    {
        public static int InputInt(string ms, string err)
        {
            int n;
            bool ok = true;
            do
            {
                Console.WriteLine(ms);
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return n;
        }
        public static string InputStr(string ms, string err, int min, int max)
        {
            string str;
            bool ok = false;

            do
            {
                Console.WriteLine(ms);
                str = Console.ReadLine();

                if (str.Length >= min && str.Length <= max)
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine(err);
                }

            } while (!ok);

            return str;
        }
        public static double InputDouble(string ms, string err)
        {
            double d;
            bool ok = true;
            do
            {
                Console.WriteLine(ms);
                ok = double.TryParse(Console.ReadLine(), out d);

                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return d;
        }
    }
}
