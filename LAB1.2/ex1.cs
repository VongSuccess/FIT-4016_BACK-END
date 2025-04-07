using System;

namespace LAB1_2
{
    internal class ex1
    {
        
        static int TinhTongSoChan(int[] arr)
        {
            int tong = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    tong += num;
                }
            }
            return tong;
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

                int tongSoChan = TinhTongSoChan(arr);
                Console.WriteLine($"Tổng các số chẵn trong mảng là: {tongSoChan}");
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