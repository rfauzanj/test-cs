using System.IO;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int akumulasiNg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
            label2.BackColor = Color.Green;
            label3.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.Green)
            {
                label1.BackColor = Color.Red;
            }
            else
            {
                label1.BackColor = Color.Green;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.BackColor == Color.Green)
            {
                label2.BackColor = Color.Red;
            }
            else
            {
                label2.BackColor = Color.Green;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.Green)
            {
                label3.BackColor = Color.Red;
            }
            else
            {
                label3.BackColor = Color.Green;
            }
        }

        private void cek_Click(object sender, EventArgs e)
        {
            int jumlahMerah = 0;

            if (label1.BackColor == Color.Red)
            {
                jumlahMerah++;
                akumulasiNg++;
            }

            if (label2.BackColor == Color.Red)
            {
                jumlahMerah++;
                akumulasiNg++;
            }

            if (label3.BackColor == Color.Red)
            {
                jumlahMerah++;
                akumulasiNg++;
            }

            lblTotalNG.Text = $"TOTAL NG = {jumlahMerah}";
            ngHarian.Text = $"TOTAL NG HARIAN = {akumulasiNg}";


            //if (label1.BackColor == Color.Green && label2.BackColor == Color.Green && label3.BackColor == Color.Green)
            //{
            //    MessageBox.Show("Semua Label Berwarna Hijau");
            //}
            //else
            //{
            //    MessageBox.Show("Ada Label yang Tidak Berwarna Hijau");
            //}

            string waktuSekarang = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string status;
            if (jumlahMerah == 0)
            {
                status = "OK";
            }
            else
            {
                status = $"NG ({jumlahMerah})";
            }

            // format pesan log yang akan dimasukan ke list
            string logMessage = $"[{waktuSekarang}] Pengecekan Selesai - Status: {status}";
            lstRiwayat.Items.Add(logMessage);

            // (Opsional) Membuat ListBox selalu scroll otomatis ke item paling bawah/terbaru
            lstRiwayat.TopIndex = lstRiwayat.Items.Count - 1;

        }
        private void chkAuto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAuto.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        Random sensorSimulasi = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int suhuSekarang = sensorSimulasi.Next(20, 100);

            prgSuhu.Value = suhuSekarang;
            lblSuhu.Text = $"Suhu Mesin: {suhuSekarang}°C";

            if (suhuSekarang > 85)
            {
                lblSuhu.BackColor = Color.Red;
            }
            else
            {
                lblSuhu.BackColor = Color.Green;
            }

            cek.PerformClick();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (lstRiwayat.Items.Count == 0)
            {
                MessageBox.Show("Tidak ada data log yang bisa diekspor!", "Peringatan");
                return;
            }

            // 1. Buat List (mirip Array di JS) untuk menampung data yang terstruktur
            // Kita menggunakan tipe 'object' agar bisa membuat objek tanpa kelas khusus
            var logList = new System.Collections.Generic.List<object>();

            // 2. Masukkan setiap baris di ListBox ke dalam List sebagai sebuah Objek
            foreach (var item in lstRiwayat.Items)
            {
                // Membuat objek anonim (mirip object { } di JavaScript)
                logList.Add(new
                {
                    Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    LogMessage = item.ToString()
                });
            }

            string jsonString = JsonSerializer.Serialize(logList, new JsonSerializerOptions { WriteIndented = true });

            string waktuFile = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string namaFile = $"Laporan_Mesin{waktuFile}.json";
            File.WriteAllText(namaFile, jsonString);

            MessageBox.Show($"File berhasil disimpan dengan nama: {namaFile}", "Export Sukses");
        }
    }
}
