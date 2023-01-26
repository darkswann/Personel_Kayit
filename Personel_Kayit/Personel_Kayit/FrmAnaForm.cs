using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("BLABLA");

        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            comboSehir.Text = "";
            radioBekar.Checked = false;
            radioEvli.Checked = false;
            txtMeslek.Text = "";
            maskMaas.Text = "";
            txtAd.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriDataSet2.Tbl_Personel);
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMeslek,PerMaas,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboSehir.Text);
            komut.Parameters.AddWithValue("@p4", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p5", maskMaas.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Eklendi");

        }

        private void radioEvli_CheckedChanged(object sender, EventArgs e)
        {
            if(radioEvli.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioBekar_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBekar.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void bttnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void bttnİstatik_Click(object sender, EventArgs e)
        {
            Frmistatistik frm = new Frmistatistik();
            frm.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            maskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void bttnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmgrafik = new FrmGrafikler();
            frmgrafik.Show();
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerDurum=@a4,PerMeslek=@a5,PerMaas=@a6 where Perid=@a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a5", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a6", maskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Güncellendi");
        }
    }
}
