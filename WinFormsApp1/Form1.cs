using System.IO.Ports;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private class ModelData
        {
            public string NamaModel { get; set; }
            public List<bool> ItemStatuses { get; set; } = new List<bool>();
            public int AkumulasiNgModel { get; set; } = 0;
        }

        private List<ModelData> daftarModel = new List<ModelData>();
        private int modelAktifIndex = 0;
        int akumulasiNg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var model1 = new ModelData { NamaModel = "Model A-01 (4 item)" };
            for (int i = 0; i < 4; i++) model1.ItemStatuses.Add(true);
            daftarModel.Add(model1);

            var model2 = new ModelData { NamaModel = "Model B-02 (6 item)" };
            for (int i = 0; i < 6; i++) model2.ItemStatuses.Add(true);
            daftarModel.Add(model2);

            var model3 = new ModelData { NamaModel = "Model C-03 (10 item)" };
            for (int i = 0; i < 10; i++) model3.ItemStatuses.Add(true);
            daftarModel.Add(model3);

            cmbModel.Items.Clear();
            foreach (var model in daftarModel)
            {
                cmbModel.Items.Add(model.NamaModel);
            }

            cmbModel.SelectedIndex = 0;

            MuatTampilanModelAktif();
        }

        private void MuatTampilanModelAktif()
        {
            var model = daftarModel[modelAktifIndex];
            GroupBox1.Text = model.NamaModel;

            flowPanelItem.Controls.Clear();

            for (int i = 0; i < model.ItemStatuses.Count; i++)
            {
                Label lblItem = new Label();
                lblItem.Name = $"lblItem_{i}";
                lblItem.Text = $"Item {i + 1}";
                lblItem.Width = 60;
                lblItem.Height = 30;
                lblItem.TextAlign = ContentAlignment.MiddleCenter;
                lblItem.Font = new Font(this.Font, FontStyle.Bold);

                lblItem.BackColor = model.ItemStatuses[i] ? Color.Green : Color.Red;

                lblItem.Tag = i;

                lblItem.Click += LblItem_Click;
                flowPanelItem.Controls.Add(lblItem);
            }
            lblTotalNG.Text = $"TOTAL NG = ({model.NamaModel}) = 0";
        }

        private void LblItem_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            int indexItem = (int)clickedLabel.Tag;

            var model = daftarModel[modelAktifIndex];

            model.ItemStatuses[indexItem] = !model.ItemStatuses[indexItem];

            clickedLabel.BackColor = model.ItemStatuses[indexItem] ? Color.Green : Color.Red;
        }
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelAktifIndex = cmbModel.SelectedIndex;
            MuatTampilanModelAktif();
        }


        private void cek_Click(object sender, EventArgs e)
        {
            var model = daftarModel[modelAktifIndex];
            int jumlahMerah = 0;

            foreach (var statusOK in model.ItemStatuses)
            {
                if (!statusOK)
                {
                    jumlahMerah++;
                }
            }

            if (jumlahMerah > 0)
            {
                model.AkumulasiNgModel += jumlahMerah;
                akumulasiNg += jumlahMerah;
            }


            lblTotalNG.Text = $"TOTAL NG = ({model.NamaModel}) = {jumlahMerah}";
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
            string status = jumlahMerah == 0 ? "OK" : $"NG ({jumlahMerah})";

            string logMessage = $"[{waktuSekarang}] Pengecekan Selesai - Status: {status}";
            lstRiwayat.Items.Add(logMessage);
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
