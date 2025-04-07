using System;

namespace LAB1_2
{
    internal class ex5
    {
       
        static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Run()
        {
            try
            {
                Console.Write("Nhập số a: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập số b: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");
                HoanVi(ref a, ref b);
                Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập số nguyên hợp lệ!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}