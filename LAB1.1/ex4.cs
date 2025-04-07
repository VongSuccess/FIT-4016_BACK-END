using System;

namespace LAB1_1
{
    internal class ex4
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập một số nguyên: ");
                int so = Convert.ToInt32(Console.ReadLine());

                if (so % 2 == 0)
                {
                    Console.WriteLine($"{so} là số chẵn!");
                }
                else
                {
                    Console.WriteLine($"{so} là số lẻ!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}