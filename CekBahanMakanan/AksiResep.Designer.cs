namespace CekBahanMakanan
{
    partial class AksiResep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTambahResep = new System.Windows.Forms.ListView();
            this.lblAksiResep = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIsiResep = new System.Windows.Forms.Label();
            this.lblJudulResep = new System.Windows.Forms.Label();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTambahResep
            // 
            this.listViewTambahResep.Location = new System.Drawing.Point(36, 133);
            this.listViewTambahResep.Name = "listViewTambahResep";
            this.listViewTambahResep.Size = new System.Drawing.Size(500, 210);
            this.listViewTambahResep.TabIndex = 8;
            this.listViewTambahResep.UseCompatibleStateImageBehavior = false;
            // 
            // lblAksiResep
            // 
            this.lblAksiResep.AutoSize = true;
            this.lblAksiResep.BackColor = System.Drawing.Color.Transparent;
            this.lblAksiResep.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAksiResep.ForeColor = System.Drawing.Color.White;
            this.lblAksiResep.Location = new System.Drawing.Point(32, 25);
            this.lblAksiResep.Name = "lblAksiResep";
            this.lblAksiResep.Size = new System.Drawing.Size(88, 21);
            this.lblAksiResep.TabIndex = 9;
            this.lblAksiResep.Text = "x Resep";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblIsiResep
            // 
            this.lblIsiResep.AutoSize = true;
            this.lblIsiResep.BackColor = System.Drawing.Color.Transparent;
            this.lblIsiResep.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsiResep.ForeColor = System.Drawing.Color.White;
            this.lblIsiResep.Location = new System.Drawing.Point(33, 115);
            this.lblIsiResep.Name = "lblIsiResep";
            this.lblIsiResep.Size = new System.Drawing.Size(74, 15);
            this.lblIsiResep.TabIndex = 11;
            this.lblIsiResep.Text = "Isi Resep";
            // 
            // lblJudulResep
            // 
            this.lblJudulResep.AutoSize = true;
            this.lblJudulResep.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulResep.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulResep.ForeColor = System.Drawing.Color.White;
            this.lblJudulResep.Location = new System.Drawing.Point(33, 62);
            this.lblJudulResep.Name = "lblJudulResep";
            this.lblJudulResep.Size = new System.Drawing.Size(96, 15);
            this.lblJudulResep.TabIndex = 12;
            this.lblJudulResep.Text = "Judul Resep";
            // 
            // btnSelesai
            // 
            this.btnSelesai.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.ForeColor = System.Drawing.Color.DimGray;
            this.btnSelesai.Location = new System.Drawing.Point(436, 359);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(100, 30);
            this.btnSelesai.TabIndex = 13;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.DimGray;
            this.btnHapus.Location = new System.Drawing.Point(314, 359);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // AksiResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lblJudulResep);
            this.Controls.Add(this.lblIsiResep);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAksiResep);
            this.Controls.Add(this.listViewTambahResep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AksiResep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTambahResep;
        private System.Windows.Forms.Label lblAksiResep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIsiResep;
        private System.Windows.Forms.Label lblJudulResep;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapus;
    }
}