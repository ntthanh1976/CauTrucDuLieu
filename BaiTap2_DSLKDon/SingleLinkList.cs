using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_DSLKDon
{
    class Node
    {
        private float info;
        private Node next;

        public Node(float x)
        {
            info = x;
            next = null;
        }

        public float Info
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
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }

       //phuong thuc them nut moi vao dau xau
        public void AddHead(float x)
        {
            Node p = new Node(x); //cap phat nut moi
            p.Next = Head;
            Head = p;
        }
        //phuong thuc duyet danh sach (Xuat danh sach)
        public void ProcessList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.Info}  "); //xuat gia tri cua nut
                p = p.Next;
            }
        }

        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null) {
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

    }
}
