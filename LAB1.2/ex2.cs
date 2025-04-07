using System;

namespace LAB1_2
{
    internal class ex2
    {
        
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void Run()
        {
            try
            {
                Console.Write("Nhập số lượng phần tử của mảng: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Số lượng phần tử phải lớn hơn 0!");
                    return;
                }

                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Các số nguyên tố trong mảng:");
                bool coSoNguyenTo = false;
                for (int i = 0; i < n; i++)
                {
                    if (LaSoNguyenTo(arr[i]))
                    {
                        Console.WriteLine($"Chỉ số: {i}, Giá trị: {arr[i]}");
                        coSoNguyenTo = true;
                    }
                }

                if (!coSoNguyenTo)
                {
                    Console.WriteLine("Không có số nguyên tố trong mảng!");
                }
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