using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//Xử lý hiển thị tiếng Việt trên console//

            Console.Write("Họ và tên: ");//Hiển thị thông báo yêu cầu nhập họ và tên//
            string hoTen = Console.ReadLine();//Nhập họ và tên từ bàn phím//
            Console.Write("Năm sinh: ");//Hiển thị thông báo yêu cầu nhập năm sinh//
            int namSinh;//Khai báo biến namSinh để lưu năm sinh//
            if (!int.TryParse(Console.ReadLine(), out namSinh))//Kiểm tra xem người dùng có nhập đúng định dạng số nguyên không//
            {
                Console.WriteLine("Năm sinh không hợp lệ.");//Hiển thị thông báo lỗi nếu năm sinh không hợp lệ//
                return;//Kết thúc chương trình nếu năm sinh không hợp lệ//
            }
            int tuoi = DateTime.Now.Year - namSinh;//Tính tuổi gần đúng bằng cách lấy năm hiện tại trừ đi năm sinh//
            Console.WriteLine("Xin chào {0}, tuổi gần đúng: {1}", hoTen, tuoi);//Hiển thị thông báo chào mừng và tuổi gần đúng//
        }
    }
}
