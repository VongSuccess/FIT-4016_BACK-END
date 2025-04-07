using System;

namespace LAB1_1
{
    internal class ex8
    {
        public static void Run()
        {
            Console.WriteLine("Bảng cửu chương từ 1 đến 10:");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}