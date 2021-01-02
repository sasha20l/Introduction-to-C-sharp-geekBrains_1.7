using System;


namespace geekBrains_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 3;
            bool flag = false;

            for (int i = 0; i < nums; i++)
            {
                nums += i + (i * 2);
            }
            if (flag) Console.WriteLine(nums);
            else Console.WriteLine("Тут ничего нет");
            Console.ReadKey();
        }
    }
}
