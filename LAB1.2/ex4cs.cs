using System;

namespace LAB1_2
{
    internal class ex4
    {
        
        static int? TimSoLonThuHai(int[] arr)
        {
            if (arr.Length < 2) return null; 

            int max = int.MinValue;
            int thuHai = int.MinValue;

            foreach (int num in arr)
            {
                if (num > max)
                {
                    thuHai = max;
                    max = num;
                }
                else if (num < max && num > thuHai)
                {
                    thuHai = num;
                }
            }

            return thuHai == int.MinValue ? null : thuHai;
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

                int? soLonThuHai = TimSoLonThuHai(arr);
                if (soLonThuHai.HasValue)
                {
                    Console.WriteLine($"Số lớn thứ hai trong mảng là: {soLonThuHai}");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy số lớn thứ hai!");
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