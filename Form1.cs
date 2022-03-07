using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listeGorBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            MessageBox.Show(list.DisplayElements());
        }

        private void basaEkleBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            list.BasaEkle(100);
            MessageBox.Show("100 elemanı başa eklendi"+list.DisplayElements());
        }

        private void sonaEkleBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            list.SonaEkle(100);
            MessageBox.Show("100 elemanı sona eklendi" + list.DisplayElements());
        }

        private void bastanSilBtn_Click(object sender, EventArgs e)
        {

            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            list.BastanSil();
            MessageBox.Show("1 elemanı baştan silindi" + list.DisplayElements());
        }

        private void sondanSilBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            list.SondanSil();
            MessageBox.Show("5 elemanı sondan silindi" + list.DisplayElements());
        }

        private void arayaEkleBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            list.ArayaEkle(2, 100);
            MessageBox.Show("2. indise 100 elemanı eklendi" + list.DisplayElements());
        }

        private void aradanSilBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            list.AradanSil(3);
            MessageBox.Show("3. indisteki 4 elemanı silindi" + list.DisplayElements());
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            Liste list = new Liste();
            list.BasaEkle(5);
            list.BasaEkle(4);
            list.BasaEkle(3);
            list.BasaEkle(2);
            list.BasaEkle(1);
            MessageBox.Show("Listenin ilk hali:"+list.DisplayElements());
            list.Reverse(ref list.head);
            MessageBox.Show("Reverse işlemi"+list.DisplayElements());
        }
    }
}
