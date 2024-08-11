namespace odev2_logger_windows_form
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
            label1 = new Label();
            cmbLogTipi = new ComboBox();
            label2 = new Label();
            txtDurum = new TextBox();
            btnKaydet = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 62);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Log Tipi";
            // 
            // cmbLogTipi
            // 
            cmbLogTipi.FormattingEnabled = true;
            cmbLogTipi.Items.AddRange(new object[] { "Seçiniz", "DbLog", "JsonLog", "XmlLog" });
            cmbLogTipi.Location = new Point(247, 54);
            cmbLogTipi.Name = "cmbLogTipi";
            cmbLogTipi.Size = new Size(151, 28);
            cmbLogTipi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 116);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Durum";
            label2.Click += label2_Click;
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(247, 113);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(151, 27);
            txtDurum.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(247, 188);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(151, 29);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(102, 298);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç:";
            lblSonuc.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnKaydet);
            Controls.Add(txtDurum);
            Controls.Add(label2);
            Controls.Add(cmbLogTipi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbLogTipi;
        private Label label2;
        private TextBox txtDurum;
        private Button btnKaydet;
        private Label lblSonuc;
    }
}
