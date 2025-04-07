using System;

namespace LAB1_1
{
    internal class ex2
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập chiều dài: ");
                double chieuDai = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập chiều rộng: ");
                double chieuRong = Convert.ToDouble(Console.ReadLine());

                double dienTich = chieuDai * chieuRong;

                Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập chiều dài và chiều rộng là số!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}