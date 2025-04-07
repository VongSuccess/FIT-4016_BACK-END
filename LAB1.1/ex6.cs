using System;

namespace LAB1_1
{
    internal class ex6
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập một số: ");
                double so = Convert.ToDouble(Console.ReadLine());

                if (so > 0)
                {
                    Console.WriteLine($"{so} là số dương!");
                }
                else if (so < 0)
                {
                    Console.WriteLine($"{so} là số âm!");
                }
                else
                {
                    Console.WriteLine($"{so} là số không!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}