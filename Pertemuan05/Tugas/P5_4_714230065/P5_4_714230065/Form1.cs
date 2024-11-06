using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230065
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkTenis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string olahraga = "";
            if (checkSepakBola.Checked)
                olahraga += "Sepak Bola, ";
            if (checkBasket.Checked)
                olahraga += "Basket, ";
            if (checkRenang.Checked)
                olahraga += "Renang, ";
            if (checkBuluTangkis.Checked)
                olahraga += "Bulu Tangkis, ";
            if (checkTenis.Checked)
                olahraga += "Tenis, ";
            if (checkVoli.Checked)
                olahraga += "Voli, ";
            if (checkYoga.Checked)
                olahraga += "Yoga, ";
            if (checkPanahan.Checked)
                olahraga += "Panahan, ";

            // Menghapus koma dan spasi terakhir
            if (olahraga.EndsWith(", "))
                olahraga = olahraga.Substring(0, olahraga.Length - 2);

            if (string.IsNullOrEmpty(olahraga))
            {
                MessageBox.Show(
                "Harap pilih setidaknya satu olahraga!",
                "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seninRabu.Checked == true)
            {
                jadwal = "Senin s/d Rabu, 14.00-16.00";
            }
            else if (selasaKamis.Checked == true)
            {
                jadwal = "Senin s/d Rabu, 14.00-16.00";
            }
            else if (sabtuMinggu.Checked == true)
            {
                jadwal = "Senin s/d Rabu, 14.00-16.00";
            }
            else if (minngu.Checked == true)
            {
                jadwal = "Senin s/d Rabu, 14.00-16.00";
            }

            if (string.IsNullOrEmpty(jadwal))
            {
                MessageBox.Show(
                "Harap memilih salah satu dari pilihan jadwal",
                "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Nama: " + nama1.Text +
                "\nJenis Kelamin: " + PilihJk.Text +
                "\nTanggal Lahir: " + dateTimePicker1.Text +
                "\nKelas Olahraga : " + olahraga +
                "\nJadwal: " + jadwal,
                "Pendaftaran ULBI SPORT SCHOOL",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
