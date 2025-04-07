using System;

namespace LAB1_2
{
    internal class ex6
    {
        // Hàm sắp xếp mảng tăng dần (Bubble Sort)
        static void SapXepTangDan(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
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

                double[] arr = new double[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Mảng trước khi sắp xếp:");
                Console.WriteLine(string.Join(" ", arr));

                SapXepTangDan(arr);

                Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
                Console.WriteLine(string.Join(" ", arr));
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