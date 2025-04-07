using System;

namespace LAB1_1
{
    internal class ex7
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập một năm: ");
                int nam = Convert.ToInt32(Console.ReadLine());

                bool laNamNhuan = false;

                if (nam % 4 == 0)
                {
                    if (nam % 100 == 0)
                    {
                        if (nam % 400 == 0)
                        {
                            laNamNhuan = true;
                        }
                    }
                    else
                    {
                        laNamNhuan = true;
                    }
                }

                if (laNamNhuan)
                {
                    Console.WriteLine($"{nam} là năm nhuận!");
                }
                else
                {
                    Console.WriteLine($"{nam} không phải là năm nhuận!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập năm là một số nguyên!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}