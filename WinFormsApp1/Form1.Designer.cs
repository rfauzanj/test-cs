namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cek = new Button();
            lblTotalNG = new Label();
            ngHarian = new Label();
            lstRiwayat = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            chkAuto = new CheckBox();
            prgSuhu = new ProgressBar();
            lblSuhu = new Label();
            btnExport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(26, 48);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "item1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(132, 48);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "item2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(238, 48);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "item3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // cek
            // 
            cek.Location = new Point(26, 149);
            cek.Name = "cek";
            cek.Size = new Size(75, 23);
            cek.TabIndex = 5;
            cek.Text = "cek";
            cek.UseVisualStyleBackColor = true;
            cek.Click += cek_Click;
            // 
            // lblTotalNG
            // 
            lblTotalNG.AutoSize = true;
            lblTotalNG.Location = new Point(26, 234);
            lblTotalNG.Name = "lblTotalNG";
            lblTotalNG.Size = new Size(81, 15);
            lblTotalNG.TabIndex = 7;
            lblTotalNG.Text = "TOTAL NG = 0";
            // 
            // ngHarian
            // 
            ngHarian.Location = new Point(26, 249);
            ngHarian.Name = "ngHarian";
            ngHarian.Size = new Size(359, 23);
            ngHarian.TabIndex = 9;
            ngHarian.Text = "TOTAL NG HARIAN = 0";
            // 
            // lstRiwayat
            // 
            lstRiwayat.FormattingEnabled = true;
            lstRiwayat.Location = new Point(26, 275);
            lstRiwayat.Name = "lstRiwayat";
            lstRiwayat.Size = new Size(312, 94);
            lstRiwayat.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // chkAuto
            // 
            chkAuto.Location = new Point(128, 149);
            chkAuto.Name = "chkAuto";
            chkAuto.Size = new Size(104, 24);
            chkAuto.TabIndex = 0;
            chkAuto.Text = "Auto Check";
            chkAuto.CheckedChanged += chkAuto_CheckedChanged_1;
            // 
            // prgSuhu
            // 
            prgSuhu.Location = new Point(227, 150);
            prgSuhu.Name = "prgSuhu";
            prgSuhu.Size = new Size(100, 23);
            prgSuhu.TabIndex = 11;
            // 
            // lblSuhu
            // 
            lblSuhu.AutoSize = true;
            lblSuhu.Location = new Point(227, 131);
            lblSuhu.Name = "lblSuhu";
            lblSuhu.Size = new Size(94, 15);
            lblSuhu.TabIndex = 12;
            lblSuhu.Text = "Suhu Mesin: 0°C";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(344, 275);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 13;
            btnExport.Text = "Export Log";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 383);
            Controls.Add(btnExport);
            Controls.Add(lblSuhu);
            Controls.Add(prgSuhu);
            Controls.Add(chkAuto);
            Controls.Add(lstRiwayat);
            Controls.Add(ngHarian);
            Controls.Add(lblTotalNG);
            Controls.Add(cek);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button cek;
        private Label lblTotalNG;
        private Label ngHarian;
        private ListBox lstRiwayat;
        private System.Windows.Forms.Timer timer1;
        private CheckBox chkAuto;
        private ProgressBar prgSuhu;
        private Label lblSuhu;
        private Button btnExport;
    }
}
