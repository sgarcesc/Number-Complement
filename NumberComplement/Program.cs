using System;

namespace NumberComplement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int res;
            int _n;
            _n = Convert.ToInt32(Console.ReadLine());

            res = GetIntegerComplement(_n);
            Console.WriteLine(res);
        }

        public static int GetIntegerComplement(int n)
        {
            var bits = Convert.ToString(n, 2);
            var complement = new string[bits.Length];
            for (var i =0; i < bits.Length; i++)
            {
                complement[i] = bits[i].Equals('0') ? "1" : "0";
            }
            return Convert.ToInt32(string.Join("", complement), 2);
        }
    }
}