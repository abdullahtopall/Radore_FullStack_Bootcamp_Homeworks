namespace odev2_odeme_form
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
            label2 = new Label();
            lblSonuc = new Label();
            cmbOdemeTipi = new ComboBox();
            btnOdemeYap = new Button();
            txtTutar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Tutar:";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(40, 317);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 2;
            lblSonuc.Text = "Sonuç:";
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Location = new Point(287, 51);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(151, 28);
            cmbOdemeTipi.TabIndex = 3;
            cmbOdemeTipi.SelectedIndexChanged += cmbOdemeTipi_SelectedIndexChanged;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(287, 219);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(151, 29);
            btnOdemeYap.TabIndex = 5;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(287, 130);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(151, 27);
            txtTutar.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 481);
            Controls.Add(txtTutar);
            Controls.Add(btnOdemeYap);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(lblSonuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSonuc;
        private ComboBox cmbOdemeTipi;
        private Button btnOdemeYap;
        private TextBox txtTutar;
    }
}
