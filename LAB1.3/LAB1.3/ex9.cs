using System;
using System.Collections.Generic;

namespace LAB1_3
{
    // Lớp KhachHang để quản lý thông tin hộ sử dụng điện
    class KhachHang
    {
        public string HoTenChuHo { get; set; }
        public string SoNha { get; set; }
        public string MaSoCongTo { get; set; }

        public KhachHang()
        {
            HoTenChuHo = "";
            SoNha = "";
            MaSoCongTo = "";
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên chủ hộ: ");
            HoTenChuHo = Console.ReadLine();
            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhập mã số công tơ: ");
            MaSoCongTo = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên chủ hộ: {HoTenChuHo}, Số nhà: {SoNha}, Mã số công tơ: {MaSoCongTo}");
        }
    }

    // Lớp BienLai để quản lý biên lai tiền điện
    class BienLai
    {
        public KhachHang HoSuDung { get; set; }
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public double SoTienPhaiTra { get; set; }

        public BienLai()
        {
            HoSuDung = new KhachHang();
            ChiSoCu = 0;
            ChiSoMoi = 0;
            SoTienPhaiTra = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin hộ sử dụng điện:");
            HoSuDung.Nhap();
            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
            TinhTien();
        }

        public void TinhTien()
        {
            int soDien = ChiSoMoi - ChiSoCu;
            if (soDien < 50)
            {
                SoTienPhaiTra = soDien * 1250;
            }
            else if (soDien < 100)
            {
                SoTienPhaiTra = soDien * 1500;
            }
            else
            {
                SoTienPhaiTra = soDien * 2000;
            }
        }

        public void HienThi()
        {
            HoSuDung.HienThi();
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, Chỉ số mới: {ChiSoMoi}, Số tiền phải trả: {SoTienPhaiTra} VNĐ");
        }
    }

    // Lớp QuanLyBienLai để quản lý danh sách biên lai
    class QuanLyBienLai
    {
        private List<BienLai> danhSachBienLai = new List<BienLai>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số lượng hộ sử dụng điện: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin biên lai thứ {i + 1}:");
                BienLai bienLai = new BienLai();
                bienLai.Nhap();
                danhSachBienLai.Add(bienLai);
            }
        }

        public void HienThiDanhSach()
        {
            if (danhSachBienLai.Count == 0)
            {
                Console.WriteLine("Danh sách biên lai trống!");
                return;
            }

            Console.WriteLine("Danh sách biên lai:");
            foreach (var bienLai in danhSachBienLai)
            {
                bienLai.HienThi();
                Console.WriteLine("-------------------");
            }
        }
    }

    internal class ex9
    {
        public static void Run()
        {
            QuanLyBienLai qlBienLai = new QuanLyBienLai();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nQuản lý biên lai tiền điện:");
                    Console.WriteLine("1. Nhập danh sách biên lai");
                    Console.WriteLine("2. Hiển thị danh sách biên lai");
                    Console.WriteLine("3. Thoát");
                    Console.Write("Chọn chức năng: ");
                    int chon = int.Parse(Console.ReadLine());

                    switch (chon)
                    {
                        case 1:
                            qlBienLai.NhapDanhSach();
                            break;
                        case 2:
                            qlBienLai.HienThiDanhSach();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Chức năng không hợp lệ!");
                            break;
                    }
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
}