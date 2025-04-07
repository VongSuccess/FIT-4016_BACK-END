using System;

namespace LAB1_1
{
    internal class ex9
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập một số nguyên dương: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương!");
                    return;
                }

                long giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    // Kiểm tra tràn số
                    if (giaiThua > long.MaxValue / i)
                    {
                        Console.WriteLine("Giai thừa vượt quá giới hạn của kiểu long!");
                        return;
                    }
                    giaiThua *= i;
                }

                Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
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