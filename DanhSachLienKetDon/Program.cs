using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
    //dinh nghia cau truc 1 node cua DSLK Don luu tru gia tri so nguyen
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }

        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }

    //dinh nghia cau truc DSLK don
    class SingleLinkList {
        private Node Head;
        public SingleLinkList() {
            Head = null;
        }

        //------cac thao tac tren danh sach lien ket don--------
        //phuong thuc them nut moi vao dau xau
        public void AddHead(int x)
        {
            Node p = new Node(x); //cap phat nut moi
            p.Next = Head;
            Head = p;
        }
        //phuong thuc them nut moi vao cuoi xau
        public void AddLast(int x)
        {
            Node p = new Node(x);
            if (Head == null) //dslk rong
            {
                Head = p;
            }
            else {
                Node q = Head;
                //xac dinh nut cuoi xau 
                while (q.Next != null) {
                    q = q.Next;
                }
                //moc noi nut moi vao nut cuoi
                q.Next = p;
            }
        }
        //phuong thuc xoa nut dau xau
        public void DeleteHead() {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }
        //phuong thuc xoa nut cuoi xau
        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null; //nut tam de xac dinh nut truoc p
                //duyet danh sach de tim nut cuoi
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }

        //phuong thuc xoa nut co gia x
        public void DeleteNode(int x)
        {
            if (Head != null) //danh sach co phan tu
            {
                Node p = Head;
                Node q = null; //nut tam de xac dinh nut truoc p
                //duyet danh sach de tim nut co gia tri can xoa
                while (p != null && p.Info != x)
                {
                    q = p;
                    p = p.Next;
                }
                //xoa nut p
                if (p != null) //tim thay nut can xoa
                {
                    if (p == Head)
                        DeleteHead();
                    else
                    {
                        q.Next = p.Next;
                        p.Next = null;
                    }
                }    
            }
        }

        //tim nut co gia tri lon nhat
        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }

        //tinh gia tri trung binh cac nut cua danh sach
        public float Avg()
        {
            float sum = 0;
            int count = 0;
            Node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;

                p = p.Next;
            }
            return sum / count;
        }

        //phuong thuc duyet danh sach (Xuat danh sach)
        public void ProcessList() {
            Node p = Head;
            while (p != null) 
            {
                Console.Write($"{p.Info}  "); //xuat gia tri cua nut
                p = p.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList l = new SingleLinkList();
            NhapDanhSach(l);
            //l.AddHead(6);
            //l.AddHead(5);
            //l.AddHead(7);
            //l.AddLast(9);
            Console.WriteLine("Danh sach lien ket duoc tao:");
            l.ProcessList();
           
            
            l.DeleteHead();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut dau:");
            l.ProcessList();

            l.DeleteLast();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut cuoi:");
            l.ProcessList();

            Console.Write("\nNhap gia x can xoa:");
            int x = int.Parse(Console.ReadLine());
            l.DeleteNode(x);
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut co gia tri x:");
            l.ProcessList();


            Console.WriteLine($"\nNut co gia tri lon nhat: {l.findMax().Info}");
            Console.WriteLine($"\nGia tri trung binh cac nut: {l.Avg()}");


            Console.ReadLine();

        }
        static void NhapDanhSach(SingleLinkList l) {
            string chon = "y";
            int x;
            while (chon!="n") {
                Console.Write("Nhap gia tri nut:");
                x = int.Parse(Console.ReadLine());
                l.AddLast(x);
                Console.Write("Tiep tuc (y/n)?");
                chon = Console.ReadLine();               
            }
        }
    }
}
