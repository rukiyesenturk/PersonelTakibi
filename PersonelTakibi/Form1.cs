using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Kaydet()
        {
            Bilgiler b = new Bilgiler();
            b.Tc1 = txttc.Text;
            b.Ad1 = txtad.Text;
            b.Soyad1 = txtsoyad.Text;
            b.DogumTarihi1 = datedogum.Value;
            b.Telefon = mtelefon.Text;
            b.Email = txtemail.Text;
            b.Adres = txtadres.Text;
            b.İseBaslama = dateisebaslama.Value;
            b.Unvan = txtunvan.Text;


            string[] bilgiler = { b.Tc1, b.Ad1, b.Soyad1, b.DogumTarihi1.ToString(), b.Telefon, b.Email, b.Adres, b.İseBaslama.ToString(), b.Unvan };
            ListViewItem lvi = new ListViewItem(bilgiler);
            if (b.hata == 0)
            {
                listView1.Items.Add(lvi);
                Bilgiler.Temizle(this.Controls);
                lvi.Tag = b;
            }
        }
        public void Guncelle()
        {
            guncellenecek.Tc1 = txttc.Text;
            guncellenecek.Ad1 = txtad.Text;
            guncellenecek.Soyad1 = txtsoyad.Text;
            guncellenecek.DogumTarihi1 = datedogum.Value;
            guncellenecek.Telefon = mtelefon.Text;
            guncellenecek.Email = txtemail.Text;
            guncellenecek.Adres = txtadres.Text;
            guncellenecek.İseBaslama = dateisebaslama.Value;
            guncellenecek.Unvan = txtunvan.Text;

            string[] guncelbilgi = { guncellenecek.Tc1, guncellenecek.Ad1, guncellenecek.Soyad1, guncellenecek.DogumTarihi1.ToString(), guncellenecek.Telefon, guncellenecek.Email, guncellenecek.Adres, guncellenecek.İseBaslama.ToString(), guncellenecek.Unvan };
            ListViewItem lvi = new ListViewItem(guncelbilgi);
            lvi.Tag = guncellenecek;
            int index = listView1.SelectedItems[0].Index;
            if(guncellenecek.hata == 1)
            {
                listView1.Items.RemoveAt(index);
                listView1.Items.Insert(index, lvi);
                Bilgiler.Temizle(this.Controls);
        }
    }
        private void btnekle_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        

        private void btnsil_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        Bilgiler guncellenecek;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                guncellenecek = (Bilgiler)listView1.SelectedItems[0].Tag;
                txttc.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtad.Text= listView1.SelectedItems[0].SubItems[1].Text;
                txtsoyad.Text= listView1.SelectedItems[0].SubItems[2].Text;
                datedogum.Value= Convert.ToDateTime(listView1.SelectedItems[0].SubItems[3].Text);
                mtelefon.Text= listView1.SelectedItems[0].SubItems[4].Text;
                txtemail.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtadres.Text= listView1.SelectedItems[0].SubItems[6].Text;
                dateisebaslama.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[7].Text);
                txtunvan.Text = listView1.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {

        }
    }
}
