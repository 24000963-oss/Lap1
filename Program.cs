using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h;//Khai báo biến r và h để lưu bán kính và chiều cao//
            Console.Write("Bán kính r = ");//Hiển thị thông báo yêu cầu nhập bán kính//
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0) return;//Kiểm tra xem người dùng có nhập đúng định dạng số thực và bán kính có lớn hơn 0 không, nếu không thì kết thúc chương trình//
            Console.Write("Chiều cao h = ");//Hiển thị thông báo yêu cầu nhập chiều cao//
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0) return;//Kiểm tra xem người dùng có nhập đúng định dạng số thực và chiều cao có lớn hơn 0 không, nếu không thì kết thúc chương trình//
            double dienTichXQ = 2 * Math.PI * r * h;//Tính diện tích xung quanh của hình trụ bằng công thức 2πrh//
            double theTich = Math.PI * r * r * h;//Tính thể tích của hình trụ bằng công thức πr²h//
            Console.WriteLine("Sxq = {0:N2}; V = {1:N2}", dienTichXQ, theTich);//Hiển thị kết quả diện tích xung quanh và thể tích của hình trụ với 2 chữ số thập phân//

        }
    }
}
