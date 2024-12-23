using System;

class Program
{
    static void Main()
    {
        // Nhập hai số từ người dùng
        Console.Write("Nhập số thứ nhất: ");
        int soThuNhat = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int soThuHai = Convert.ToInt32(Console.ReadLine());

        // Tính tổng của hai số
        int tong = soThuNhat + soThuHai;

        // Lấy dư khi chia tổng cho 10
        int du = tong % 10;

        // In kết quả ra màn hình
        Console.WriteLine("Tổng của hai số là: " + tong);
        Console.WriteLine("Dư khi chia tổng cho 10 là: " + du);

        Console.ReadLine(); // Để chương trình không đóng ngay sau khi in kết quả
    }

   
} 
