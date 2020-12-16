
namespace acartuz
{
    partial class borclulistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borclulistele));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_firmaadi = new System.Windows.Forms.Label();
            this.label_borclufirmaborcmiktari = new System.Windows.Forms.Label();
            this.textbox_borcluborcodememiktari = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nakit = new System.Windows.Forms.RadioButton();
            this.rb_havele_eft = new System.Windows.Forms.RadioButton();
            this.textbox_borcluborceklememiktari = new System.Windows.Forms.TextBox();
            this.textbox_borcluborcyapilmaturu = new System.Windows.Forms.TextBox();
            this.textbox_borcluaciklama = new System.Windows.Forms.TextBox();
            this.buton_islemigerceklestir = new custombutton.mycustombutton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Coral;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borçlu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1199, 334);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borçlu Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Borçlu Firma Borç Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Borç Ödeme Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Borç Ekleme Miktarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Borç Ödeme Türü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Borç Yapılma Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Açıklama:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_firmaadi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_borclufirmaborcmiktari, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textbox_borcluborcodememiktari, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textbox_borcluborceklememiktari, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textbox_borcluborcyapilmaturu, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textbox_borcluaciklama, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(451, 421);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 281);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label_firmaadi
            // 
            this.label_firmaadi.AutoSize = true;
            this.label_firmaadi.Location = new System.Drawing.Point(153, 0);
            this.label_firmaadi.Name = "label_firmaadi";
            this.label_firmaadi.Size = new System.Drawing.Size(0, 13);
            this.label_firmaadi.TabIndex = 13;
            // 
            // label_borclufirmaborcmiktari
            // 
            this.label_borclufirmaborcmiktari.AutoSize = true;
            this.label_borclufirmaborcmiktari.ForeColor = System.Drawing.Color.White;
            this.label_borclufirmaborcmiktari.Location = new System.Drawing.Point(153, 35);
            this.label_borclufirmaborcmiktari.Name = "label_borclufirmaborcmiktari";
            this.label_borclufirmaborcmiktari.Size = new System.Drawing.Size(13, 13);
            this.label_borclufirmaborcmiktari.TabIndex = 11;
            this.label_borclufirmaborcmiktari.Text = "0";
            // 
            // textbox_borcluborcodememiktari
            // 
            this.textbox_borcluborcodememiktari.Location = new System.Drawing.Point(153, 73);
            this.textbox_borcluborcodememiktari.Name = "textbox_borcluborcodememiktari";
            this.textbox_borcluborcodememiktari.Size = new System.Drawing.Size(144, 20);
            this.textbox_borcluborcodememiktari.TabIndex = 12;
            this.textbox_borcluborcodememiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_borcluborcodememiktari_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nakit);
            this.groupBox1.Controls.Add(this.rb_havele_eft);
            this.groupBox1.Location = new System.Drawing.Point(153, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rb_nakit
            // 
            this.rb_nakit.AutoSize = true;
            this.rb_nakit.ForeColor = System.Drawing.Color.White;
            this.rb_nakit.Location = new System.Drawing.Point(7, 44);
            this.rb_nakit.Name = "rb_nakit";
            this.rb_nakit.Size = new System.Drawing.Size(50, 17);
            this.rb_nakit.TabIndex = 1;
            this.rb_nakit.TabStop = true;
            this.rb_nakit.Text = "Nakit";
            this.rb_nakit.UseVisualStyleBackColor = true;
            // 
            // rb_havele_eft
            // 
            this.rb_havele_eft.AutoSize = true;
            this.rb_havele_eft.ForeColor = System.Drawing.Color.White;
            this.rb_havele_eft.Location = new System.Drawing.Point(7, 20);
            this.rb_havele_eft.Name = "rb_havele_eft";
            this.rb_havele_eft.Size = new System.Drawing.Size(84, 17);
            this.rb_havele_eft.TabIndex = 0;
            this.rb_havele_eft.TabStop = true;
            this.rb_havele_eft.Text = "Havale/EFT";
            this.rb_havele_eft.UseVisualStyleBackColor = true;
            // 
            // textbox_borcluborceklememiktari
            // 
            this.textbox_borcluborceklememiktari.Location = new System.Drawing.Point(153, 178);
            this.textbox_borcluborceklememiktari.Name = "textbox_borcluborceklememiktari";
            this.textbox_borcluborceklememiktari.Size = new System.Drawing.Size(144, 20);
            this.textbox_borcluborceklememiktari.TabIndex = 14;
            this.textbox_borcluborceklememiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_borcluborceklememiktari_KeyPress);
            // 
            // textbox_borcluborcyapilmaturu
            // 
            this.textbox_borcluborcyapilmaturu.Location = new System.Drawing.Point(153, 213);
            this.textbox_borcluborcyapilmaturu.Name = "textbox_borcluborcyapilmaturu";
            this.textbox_borcluborcyapilmaturu.Size = new System.Drawing.Size(144, 20);
            this.textbox_borcluborcyapilmaturu.TabIndex = 15;
            // 
            // textbox_borcluaciklama
            // 
            this.textbox_borcluaciklama.Location = new System.Drawing.Point(153, 248);
            this.textbox_borcluaciklama.Multiline = true;
            this.textbox_borcluaciklama.Name = "textbox_borcluaciklama";
            this.textbox_borcluaciklama.Size = new System.Drawing.Size(144, 30);
            this.textbox_borcluaciklama.TabIndex = 16;
            // 
            // buton_islemigerceklestir
            // 
            this.buton_islemigerceklestir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_islemigerceklestir.FlatAppearance.BorderSize = 2;
            this.buton_islemigerceklestir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_islemigerceklestir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_islemigerceklestir.ForeColor = System.Drawing.Color.White;
            this.buton_islemigerceklestir.Location = new System.Drawing.Point(482, 708);
            this.buton_islemigerceklestir.Name = "buton_islemigerceklestir";
            this.buton_islemigerceklestir.Size = new System.Drawing.Size(232, 33);
            this.buton_islemigerceklestir.TabIndex = 13;
            this.buton_islemigerceklestir.Text = "İşlemi Gerçekleştir";
            this.buton_islemigerceklestir.UseVisualStyleBackColor = false;
            this.buton_islemigerceklestir.Click += new System.EventHandler(this.buton_islemigerceklestir_Click);
            // 
            // borclulistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1223, 753);
            this.Controls.Add(this.buton_islemigerceklestir);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "borclulistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borçlu Listele - Ödeme Al";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.borclulistele_FormClosing);
            this.Load += new System.EventHandler(this.borclulistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_borclufirmaborcmiktari;
        private System.Windows.Forms.TextBox textbox_borcluborcodememiktari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nakit;
        private System.Windows.Forms.RadioButton rb_havele_eft;
        private System.Windows.Forms.TextBox textbox_borcluborceklememiktari;
        private System.Windows.Forms.TextBox textbox_borcluborcyapilmaturu;
        private System.Windows.Forms.TextBox textbox_borcluaciklama;
        private System.Windows.Forms.Label label_firmaadi;
        private custombutton.mycustombutton buton_islemigerceklestir;
    }
}