using System;
using System.Collections.Generic;


namespace laba7
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            Console.WriteLine("Заповнiть лiст значеннями 1 та 0 (Iнше значення зупинить заповнення)");
            string n = "0";
            while(n == "0" || n == "1")
            {
                n = Console.ReadLine();
                if (n == "0" || n == "1") nums.Add((int) Convert.ToInt32(n));
            }
            int count_zero = 0;
            int count_one = 0;
            foreach (int x in nums)
            {
                if (x == 0) count_zero++;
                else count_one++;
            }
            Console.WriteLine($"Нулiв - {count_zero}, одиниць - {count_one}");
            int[] A = nums.ToArray();
            foreach (int x in A) Console.Write(x + " ");
        }
    }
}
