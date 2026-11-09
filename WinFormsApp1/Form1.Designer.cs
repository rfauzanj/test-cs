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
            cek = new Button();
            lblTotalNG = new Label();
            ngHarian = new Label();
            lstRiwayat = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            chkAuto = new CheckBox();
            prgSuhu = new ProgressBar();
            lblSuhu = new Label();
            btnExport = new Button();
            GroupBox1 = new GroupBox();
            cmbModel = new ComboBox();
            flowPanelItem = new FlowLayoutPanel();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cek
            // 
            cek.Location = new Point(25, 202);
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
            chkAuto.Location = new Point(127, 202);
            chkAuto.Name = "chkAuto";
            chkAuto.Size = new Size(104, 24);
            chkAuto.TabIndex = 0;
            chkAuto.Text = "Auto Check";
            chkAuto.CheckedChanged += chkAuto_CheckedChanged_1;
            // 
            // prgSuhu
            // 
            prgSuhu.Location = new Point(226, 203);
            prgSuhu.Name = "prgSuhu";
            prgSuhu.Size = new Size(100, 23);
            prgSuhu.TabIndex = 11;
            // 
            // lblSuhu
            // 
            lblSuhu.AutoSize = true;
            lblSuhu.Location = new Point(226, 184);
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
            // GroupBox1
            // 
            GroupBox1.Controls.Add(flowPanelItem);
            GroupBox1.Location = new Point(26, 66);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(312, 115);
            GroupBox1.TabIndex = 14;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Model 1";
            // 
            // cmbModel
            // 
            cmbModel.AllowDrop = true;
            cmbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModel.FormattingEnabled = true;
            cmbModel.ImeMode = ImeMode.NoControl;
            cmbModel.Location = new Point(26, 37);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 15;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // flowPanelItem
            // 
            flowPanelItem.AutoScroll = true;
            flowPanelItem.Location = new Point(6, 15);
            flowPanelItem.Name = "flowPanelItem";
            flowPanelItem.Size = new Size(294, 94);
            flowPanelItem.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 383);
            Controls.Add(cmbModel);
            Controls.Add(GroupBox1);
            Controls.Add(btnExport);
            Controls.Add(lblSuhu);
            Controls.Add(prgSuhu);
            Controls.Add(chkAuto);
            Controls.Add(lstRiwayat);
            Controls.Add(ngHarian);
            Controls.Add(lblTotalNG);
            Controls.Add(cek);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cek;
        private Label lblTotalNG;
        private Label ngHarian;
        private ListBox lstRiwayat;
        private System.Windows.Forms.Timer timer1;
        private CheckBox chkAuto;
        private ProgressBar prgSuhu;
        private Label lblSuhu;
        private Button btnExport;
        private GroupBox GroupBox1;
        private ComboBox cmbModel;
        private FlowLayoutPanel flowPanelItem;
    }
}
