namespace odev2_attributes_windows_form
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
            lblAdi = new Label();
            lblSoyadi = new Label();
            lblBolum = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtBolum = new TextBox();
            btnKayit = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Location = new Point(140, 91);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(32, 20);
            lblAdi.TabIndex = 0;
            lblAdi.Text = "Adı";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Location = new Point(140, 190);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(54, 20);
            lblSoyadi.TabIndex = 1;
            lblSoyadi.Text = "Soyadı";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(140, 307);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(52, 20);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Bölüm";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(347, 84);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(125, 27);
            txtAdi.TabIndex = 3;
            txtAdi.TextChanged += textBox1_TextChanged;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(347, 183);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(125, 27);
            txtSoyadi.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(347, 300);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 5;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(391, 384);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(81, 29);
            btnKayit.TabIndex = 6;
            btnKayit.Text = "Kayıt";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(144, 470);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(49, 20);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 588);
            Controls.Add(lblSonuc);
            Controls.Add(btnKayit);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyadi);
            Controls.Add(lblAdi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdi;
        private Label lblSoyadi;
        private Label lblBolum;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private TextBox txtBolum;
        private Button btnKayit;
        private Label lblSonuc;
    }
}
