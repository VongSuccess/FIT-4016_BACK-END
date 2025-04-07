using System;

namespace LAB1_1
{
    internal class ex10
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập một số nguyên: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 2)
                {
                    Console.WriteLine($"{n} không phải là số nguyên tố!");
                    return;
                }

                bool laSoNguyenTo = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }

                if (laSoNguyenTo)
                {
                    Console.WriteLine($"{n} là số nguyên tố!");
                }
                else
                {
                    Console.WriteLine($"{n} không phải là số nguyên tố!");
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