using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_DSLKDon
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList l = new SingleLinkList();
            NhapDanhSach(l);
            Console.WriteLine("Danh sach vua tao:");
            l.ProcessList();
        
            Node max = l.findMax();
            Console.WriteLine($"\nNut co gia tri lon nhat: {max.Info}");
           
            float tbc = l.Avg();
            Console.WriteLine($"\nGia tri trung binh cac nut: {tbc}");
            Console.ReadLine();

        }

        static void NhapDanhSach(SingleLinkList l)
        {
            string chon = "y";
            float x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut:");
                x = float.Parse(Console.ReadLine());
                l.AddHead(x);
                Console.Write("Tiep tuc (y/n)?");
                chon = Console.ReadLine();
            }
        }
    }
}
