using System;

namespace LAB1_1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ tiếng Việt

            while (true)
            {
                Console.WriteLine("Chọn bài tập (1-10), hoặc nhập 0 để thoát:");
                Console.Write("Nhập số bài: ");
                string input = Console.ReadLine();

                if (input == "0") break; // Thoát chương trình

                switch (input)
                {
                    case "1":
                        ex1.Run();
                        break;
                    case "2":
                        ex2.Run();
                        break;
                    case "3":
                        ex3.Run();
                        break;
                    case "4":
                        ex4.Run();
                        break;
                    case "5":
                        ex5.Run();
                        break;
                    case "6":
                        ex6.Run();
                        break;
                    case "7":
                        ex7.Run();
                        break;
                    case "8":
                        ex8.Run();
                        break;
                    case "9":
                        ex9.Run();
                        break;
                    case "10":
                        ex10.Run();
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn bài từ 1 đến 10!");
                        break;
                }

                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
                Console.Clear(); // Xóa màn hình để chọn bài mới
            }
        }
    }
}