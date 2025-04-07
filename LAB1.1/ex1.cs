using System;

namespace LAB1_1
{
    internal class ex1
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập tên của bạn: ");
                string ten = Console.ReadLine();

                Console.Write("Nhập tuổi của bạn: ");
                int tuoi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập tuổi là một số nguyên!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}