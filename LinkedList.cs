using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev
{
    public abstract class LinkedList
    {
        public Node head;
        public abstract void BasaEkle(int data);
        public abstract void SonaEkle(int data);
        public abstract void BastanSil();
        public abstract void SondanSil();
        public abstract string DisplayElements();
        public abstract void ArayaEkle(int indis,int data);
        public abstract void AradanSil(int indis);
        public abstract void Reverse(ref Node head);
    }
}
