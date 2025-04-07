using System;

namespace LAB1_1
{
    internal class ex3
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập nhiệt độ (độ C): ");
                double doC = Convert.ToDouble(Console.ReadLine());

                double doF = (doC * 9 / 5) + 32;

                Console.WriteLine($"Nhiệt độ {doC} độ C bằng {doF} độ F");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập nhiệt độ là một số!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}