using System;

namespace LAB1_1
{
    internal class ex5
    {
        public static void Run()
        {
            try
            {
                Console.Write("Nhập số thứ nhất: ");
                double so1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập số thứ hai: ");
                double so2 = Convert.ToDouble(Console.ReadLine());

                double tong = so1 + so2;
                double tich = so1 * so2;

                Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
                Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập số hợp lệ!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}