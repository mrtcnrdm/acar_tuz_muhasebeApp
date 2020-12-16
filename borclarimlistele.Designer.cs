namespace acartuz
{
    partial class borclarimlistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borclarimlistele));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_nakit = new System.Windows.Forms.RadioButton();
            this.rb_havaleeft = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_odememiktari = new System.Windows.Forms.TextBox();
            this.textbox_eklenecekborc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_firmaadi = new System.Windows.Forms.Label();
            this.label_borcmiktari = new System.Windows.Forms.Label();
            this.buton_islemigerceklestir = new custombutton.mycustombutton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(652, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 500);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borçlu Olduğum Firma/Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borç Miktarım:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödeme Türü:";
            // 
            // rb_nakit
            // 
            this.rb_nakit.AutoSize = true;
            this.rb_nakit.ForeColor = System.Drawing.Color.White;
            this.rb_nakit.Location = new System.Drawing.Point(6, 19);
            this.rb_nakit.Name = "rb_nakit";
            this.rb_nakit.Size = new System.Drawing.Size(57, 17);
            this.rb_nakit.TabIndex = 7;
            this.rb_nakit.TabStop = true;
            this.rb_nakit.Text = "NAKIT";
            this.rb_nakit.UseVisualStyleBackColor = true;
            // 
            // rb_havaleeft
            // 
            this.rb_havaleeft.AutoSize = true;
            this.rb_havaleeft.ForeColor = System.Drawing.Color.White;
            this.rb_havaleeft.Location = new System.Drawing.Point(69, 19);
            this.rb_havaleeft.Name = "rb_havaleeft";
            this.rb_havaleeft.Size = new System.Drawing.Size(92, 17);
            this.rb_havaleeft.TabIndex = 8;
            this.rb_havaleeft.TabStop = true;
            this.rb_havaleeft.Text = "HAVALE/EFT";
            this.rb_havaleeft.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ödeme Miktarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(167, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Eklenecek Borç:";
            // 
            // textbox_odememiktari
            // 
            this.textbox_odememiktari.Location = new System.Drawing.Point(334, 272);
            this.textbox_odememiktari.Name = "textbox_odememiktari";
            this.textbox_odememiktari.Size = new System.Drawing.Size(155, 20);
            this.textbox_odememiktari.TabIndex = 13;
            this.textbox_odememiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_odememiktari_KeyPress);
            // 
            // textbox_eklenecekborc
            // 
            this.textbox_eklenecekborc.Location = new System.Drawing.Point(334, 304);
            this.textbox_eklenecekborc.Name = "textbox_eklenecekborc";
            this.textbox_eklenecekborc.Size = new System.Drawing.Size(155, 20);
            this.textbox_eklenecekborc.TabIndex = 14;
            this.textbox_eklenecekborc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_eklenecekborc_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_havaleeft);
            this.groupBox1.Controls.Add(this.rb_nakit);
            this.groupBox1.Location = new System.Drawing.Point(332, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 48);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // textbox_aciklama
            // 
            this.textbox_aciklama.Location = new System.Drawing.Point(334, 341);
            this.textbox_aciklama.Multiline = true;
            this.textbox_aciklama.Name = "textbox_aciklama";
            this.textbox_aciklama.Size = new System.Drawing.Size(155, 48);
            this.textbox_aciklama.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(170, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(781, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Borç Listesi";
            // 
            // label_firmaadi
            // 
            this.label_firmaadi.AutoSize = true;
            this.label_firmaadi.Location = new System.Drawing.Point(335, 161);
            this.label_firmaadi.Name = "label_firmaadi";
            this.label_firmaadi.Size = new System.Drawing.Size(0, 13);
            this.label_firmaadi.TabIndex = 23;
            // 
            // label_borcmiktari
            // 
            this.label_borcmiktari.AutoSize = true;
            this.label_borcmiktari.ForeColor = System.Drawing.Color.White;
            this.label_borcmiktari.Location = new System.Drawing.Point(335, 192);
            this.label_borcmiktari.Name = "label_borcmiktari";
            this.label_borcmiktari.Size = new System.Drawing.Size(13, 13);
            this.label_borcmiktari.TabIndex = 24;
            this.label_borcmiktari.Text = "0";
            // 
            // buton_islemigerceklestir
            // 
            this.buton_islemigerceklestir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_islemigerceklestir.FlatAppearance.BorderSize = 2;
            this.buton_islemigerceklestir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_islemigerceklestir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_islemigerceklestir.ForeColor = System.Drawing.Color.White;
            this.buton_islemigerceklestir.Location = new System.Drawing.Point(210, 415);
            this.buton_islemigerceklestir.Name = "buton_islemigerceklestir";
            this.buton_islemigerceklestir.Size = new System.Drawing.Size(225, 47);
            this.buton_islemigerceklestir.TabIndex = 25;
            this.buton_islemigerceklestir.Text = "İşlemi Gerçekleştir";
            this.buton_islemigerceklestir.UseVisualStyleBackColor = false;
            this.buton_islemigerceklestir.Click += new System.EventHandler(this.buton_odemeyapborcekle_Click);
            // 
            // borclarimlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.buton_islemigerceklestir);
            this.Controls.Add(this.label_borcmiktari);
            this.Controls.Add(this.label_firmaadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_aciklama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textbox_eklenecekborc);
            this.Controls.Add(this.textbox_odememiktari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "borclarimlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borçlarım";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.borclarimlistele_FormClosing);
            this.Load += new System.EventHandler(this.borclarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_nakit;
        private System.Windows.Forms.RadioButton rb_havaleeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_odememiktari;
        private System.Windows.Forms.TextBox textbox_eklenecekborc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_firmaadi;
        private System.Windows.Forms.Label label_borcmiktari;
        private custombutton.mycustombutton buton_islemigerceklestir;
    }
}