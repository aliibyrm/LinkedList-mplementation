using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev
{
    public class Liste : LinkedList
    {
        public override void AradanSil(int indis)
        {
            bool sonuc = false;
            if (head == null)
            {
                sonuc = true;
            }
            else if (head.next == null && indis==0)
            {
                sonuc = true;
                head = null;
            }
            else if (head.next != null && indis == 0)
            {
                sonuc = true;
                BastanSil();
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;

                while (temp.next != null)
                {
                    if(i==indis)
                    {
                        sonuc = true;
                        temp2.next = temp.next;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == indis)
                {
                    sonuc = true;
                    temp2.next = null;
                    i++;                
                }
            }
        }

        public override void ArayaEkle(int indis, int data)
        {
            Node eleman = new Node(data);
            bool sonuc = false;
            if(head==null&&indis==0)
            { head = eleman;
                sonuc = true;
            }
            if(indis==0)
            {
                BasaEkle(data);
                sonuc = true;
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while(temp.next!=null)
                {
                    if(i==indis)
                    {
                        sonuc = true;
                        temp2.next = eleman;
                        eleman.next = temp;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if(i==indis)
                {
                    sonuc = true;
                    temp2.next = eleman;
                    eleman.next = temp;
                }
            }
        }

        public override void BasaEkle(int data)
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = eleman;
                ;
            }
            else
            {
                eleman.next = head;
                head = eleman;
                
            }
        }

        public override void BastanSil()
        {
            if (head == null)
            {
                
            }
            else
            {
                head = head.next;
               
            }
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = head;
            while (item != null)
            {
                temp += "-->" + item.data;
                item = item.next;
            }
            return temp;
        }

        public override void Reverse(ref Node head)
        {
            Node currNode = head;
            Node nextNode= null;
            Node prevNode = null;
            while (currNode.next!=null)
            {
                nextNode = currNode.next;
                currNode.next = prevNode;
                prevNode = currNode;
                currNode = nextNode;

            }
            currNode.next = prevNode;
            head = currNode;
        }

        public override void SonaEkle(int data)
        {
            Node eleman = new Node(data);
            if (head == null)
            {
                head = eleman;
                
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
            }
        }

        public override void SondanSil()
        {
            if (head == null)
            {
              
            }
            else if (head.next == null)
            {
                head = null;
                
            }
            else
            {
                Node temp = head;
                Node temp2 = temp;

                while (temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                temp2.next = null;
            }
        }      
    }
}
