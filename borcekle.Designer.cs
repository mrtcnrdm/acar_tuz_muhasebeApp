
namespace acartuz
{
    partial class borcekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borcekle));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_kaydetfirmaadi = new System.Windows.Forms.TextBox();
            this.textbox_kaydetborcmiktari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_guncellefirmaadi = new System.Windows.Forms.TextBox();
            this.textbox_guncelleborcmiktari = new System.Windows.Forms.TextBox();
            this.label_zorunlu1 = new System.Windows.Forms.Label();
            this.label_zorunlu2 = new System.Windows.Forms.Label();
            this.label_zorunlu3 = new System.Windows.Forms.Label();
            this.label_zorunlu4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buton_kaydet = new custombutton.mycustombutton();
            this.buton_guncelle = new custombutton.mycustombutton();
            this.buton_sil = new custombutton.mycustombutton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borçlu Olunan Firma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borç Miktarı:";
            // 
            // textbox_kaydetfirmaadi
            // 
            this.textbox_kaydetfirmaadi.Location = new System.Drawing.Point(307, 206);
            this.textbox_kaydetfirmaadi.Name = "textbox_kaydetfirmaadi";
            this.textbox_kaydetfirmaadi.Size = new System.Drawing.Size(161, 20);
            this.textbox_kaydetfirmaadi.TabIndex = 3;
            // 
            // textbox_kaydetborcmiktari
            // 
            this.textbox_kaydetborcmiktari.Location = new System.Drawing.Point(307, 250);
            this.textbox_kaydetborcmiktari.Name = "textbox_kaydetborcmiktari";
            this.textbox_kaydetborcmiktari.Size = new System.Drawing.Size(161, 20);
            this.textbox_kaydetborcmiktari.TabIndex = 4;
            this.textbox_kaydetborcmiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_kaydetborcmiktari_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(696, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 330);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(710, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Borçlu Olunan Firma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(710, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Borç Miktarı:";
            // 
            // textbox_guncellefirmaadi
            // 
            this.textbox_guncellefirmaadi.Location = new System.Drawing.Point(840, 446);
            this.textbox_guncellefirmaadi.Name = "textbox_guncellefirmaadi";
            this.textbox_guncellefirmaadi.Size = new System.Drawing.Size(183, 20);
            this.textbox_guncellefirmaadi.TabIndex = 9;
            // 
            // textbox_guncelleborcmiktari
            // 
            this.textbox_guncelleborcmiktari.Location = new System.Drawing.Point(840, 487);
            this.textbox_guncelleborcmiktari.Name = "textbox_guncelleborcmiktari";
            this.textbox_guncelleborcmiktari.Size = new System.Drawing.Size(183, 20);
            this.textbox_guncelleborcmiktari.TabIndex = 10;
            this.textbox_guncelleborcmiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_guncelleborcmiktari_KeyPress);
            // 
            // label_zorunlu1
            // 
            this.label_zorunlu1.AutoSize = true;
            this.label_zorunlu1.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu1.Location = new System.Drawing.Point(307, 187);
            this.label_zorunlu1.Name = "label_zorunlu1";
            this.label_zorunlu1.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu1.TabIndex = 13;
            this.label_zorunlu1.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu2
            // 
            this.label_zorunlu2.AutoSize = true;
            this.label_zorunlu2.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu2.Location = new System.Drawing.Point(310, 233);
            this.label_zorunlu2.Name = "label_zorunlu2";
            this.label_zorunlu2.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu2.TabIndex = 14;
            this.label_zorunlu2.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu3
            // 
            this.label_zorunlu3.AutoSize = true;
            this.label_zorunlu3.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu3.Location = new System.Drawing.Point(840, 427);
            this.label_zorunlu3.Name = "label_zorunlu3";
            this.label_zorunlu3.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu3.TabIndex = 15;
            this.label_zorunlu3.Text = "*Zorunlu Alan";
            // 
            // label_zorunlu4
            // 
            this.label_zorunlu4.AutoSize = true;
            this.label_zorunlu4.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu4.Location = new System.Drawing.Point(840, 473);
            this.label_zorunlu4.Name = "label_zorunlu4";
            this.label_zorunlu4.Size = new System.Drawing.Size(71, 13);
            this.label_zorunlu4.TabIndex = 16;
            this.label_zorunlu4.Text = "*Zorunlu Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(251, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yeni Borç Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(792, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Borçları Güncelle-Sil";
            // 
            // buton_kaydet
            // 
            this.buton_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_kaydet.FlatAppearance.BorderSize = 2;
            this.buton_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_kaydet.ForeColor = System.Drawing.Color.White;
            this.buton_kaydet.Location = new System.Drawing.Point(266, 289);
            this.buton_kaydet.Name = "buton_kaydet";
            this.buton_kaydet.Size = new System.Drawing.Size(83, 36);
            this.buton_kaydet.TabIndex = 19;
            this.buton_kaydet.Text = "Kaydet";
            this.buton_kaydet.UseVisualStyleBackColor = false;
            this.buton_kaydet.Click += new System.EventHandler(this.buton_kaydet_Click);
            // 
            // buton_guncelle
            // 
            this.buton_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_guncelle.FlatAppearance.BorderSize = 2;
            this.buton_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_guncelle.ForeColor = System.Drawing.Color.White;
            this.buton_guncelle.Location = new System.Drawing.Point(792, 527);
            this.buton_guncelle.Name = "buton_guncelle";
            this.buton_guncelle.Size = new System.Drawing.Size(92, 36);
            this.buton_guncelle.TabIndex = 20;
            this.buton_guncelle.Text = "Güncelle";
            this.buton_guncelle.UseVisualStyleBackColor = false;
            this.buton_guncelle.Click += new System.EventHandler(this.buton_guncelle_Click);
            // 
            // buton_sil
            // 
            this.buton_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_sil.FlatAppearance.BorderSize = 2;
            this.buton_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_sil.ForeColor = System.Drawing.Color.White;
            this.buton_sil.Location = new System.Drawing.Point(901, 527);
            this.buton_sil.Name = "buton_sil";
            this.buton_sil.Size = new System.Drawing.Size(92, 36);
            this.buton_sil.TabIndex = 21;
            this.buton_sil.Text = "Sil";
            this.buton_sil.UseVisualStyleBackColor = false;
            this.buton_sil.Click += new System.EventHandler(this.buton_sil_Click);
            // 
            // borcekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.buton_sil);
            this.Controls.Add(this.buton_guncelle);
            this.Controls.Add(this.buton_kaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_zorunlu4);
            this.Controls.Add(this.label_zorunlu3);
            this.Controls.Add(this.label_zorunlu2);
            this.Controls.Add(this.label_zorunlu1);
            this.Controls.Add(this.textbox_guncelleborcmiktari);
            this.Controls.Add(this.textbox_guncellefirmaadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbox_kaydetborcmiktari);
            this.Controls.Add(this.textbox_kaydetfirmaadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "borcekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.borcekle_FormClosing);
            this.Load += new System.EventHandler(this.borcekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_kaydetfirmaadi;
        private System.Windows.Forms.TextBox textbox_kaydetborcmiktari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_guncellefirmaadi;
        private System.Windows.Forms.TextBox textbox_guncelleborcmiktari;
        private System.Windows.Forms.Label label_zorunlu1;
        private System.Windows.Forms.Label label_zorunlu2;
        private System.Windows.Forms.Label label_zorunlu3;
        private System.Windows.Forms.Label label_zorunlu4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private custombutton.mycustombutton buton_kaydet;
        private custombutton.mycustombutton buton_guncelle;
        private custombutton.mycustombutton buton_sil;
    }
}