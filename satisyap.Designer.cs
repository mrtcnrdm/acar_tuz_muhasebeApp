namespace acartuz
{
    partial class satisyap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisyap));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_urunadi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_urunfiyati = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_urunkdv = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_urunadet = new System.Windows.Forms.TextBox();
            this.textbox_satinalanfirmaadi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_zorunlu1 = new System.Windows.Forms.Label();
            this.buton_Satisigerceklestir = new custombutton.mycustombutton();
            this.buton_temizle = new custombutton.mycustombutton();
            this.label_zorunlu2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(376, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 446);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(651, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünün Adı:";
            // 
            // label_urunadi
            // 
            this.label_urunadi.AutoSize = true;
            this.label_urunadi.Location = new System.Drawing.Point(122, 0);
            this.label_urunadi.Name = "label_urunadi";
            this.label_urunadi.Size = new System.Drawing.Size(0, 13);
            this.label_urunadi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürünün Adeti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ürünün Fiyatı:";
            // 
            // label_urunfiyati
            // 
            this.label_urunfiyati.AutoSize = true;
            this.label_urunfiyati.Location = new System.Drawing.Point(122, 105);
            this.label_urunfiyati.Name = "label_urunfiyati";
            this.label_urunfiyati.Size = new System.Drawing.Size(0, 13);
            this.label_urunfiyati.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ürünün KDV\'si:";
            // 
            // label_urunkdv
            // 
            this.label_urunkdv.AutoSize = true;
            this.label_urunkdv.Location = new System.Drawing.Point(122, 140);
            this.label_urunkdv.Name = "label_urunkdv";
            this.label_urunkdv.Size = new System.Drawing.Size(0, 13);
            this.label_urunkdv.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Satın Alan Firma Adı:";
            // 
            // textbox_urunadet
            // 
            this.textbox_urunadet.Location = new System.Drawing.Point(122, 73);
            this.textbox_urunadet.Name = "textbox_urunadet";
            this.textbox_urunadet.Size = new System.Drawing.Size(114, 20);
            this.textbox_urunadet.TabIndex = 13;
            this.textbox_urunadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_urunadet_KeyPress);
            // 
            // textbox_satinalanfirmaadi
            // 
            this.textbox_satinalanfirmaadi.Location = new System.Drawing.Point(122, 178);
            this.textbox_satinalanfirmaadi.Name = "textbox_satinalanfirmaadi";
            this.textbox_satinalanfirmaadi.Size = new System.Drawing.Size(114, 20);
            this.textbox_satinalanfirmaadi.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_urunadi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textbox_satinalanfirmaadi, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textbox_urunadet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_urunkdv, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_urunfiyati, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 213);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label_zorunlu1
            // 
            this.label_zorunlu1.AutoSize = true;
            this.label_zorunlu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zorunlu1.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu1.Location = new System.Drawing.Point(251, 328);
            this.label_zorunlu1.Name = "label_zorunlu1";
            this.label_zorunlu1.Size = new System.Drawing.Size(87, 16);
            this.label_zorunlu1.TabIndex = 20;
            this.label_zorunlu1.Text = "*Zorunlu Alan";
            // 
            // buton_Satisigerceklestir
            // 
            this.buton_Satisigerceklestir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_Satisigerceklestir.FlatAppearance.BorderSize = 2;
            this.buton_Satisigerceklestir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_Satisigerceklestir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_Satisigerceklestir.ForeColor = System.Drawing.Color.White;
            this.buton_Satisigerceklestir.Location = new System.Drawing.Point(12, 375);
            this.buton_Satisigerceklestir.Name = "buton_Satisigerceklestir";
            this.buton_Satisigerceklestir.Size = new System.Drawing.Size(116, 49);
            this.buton_Satisigerceklestir.TabIndex = 21;
            this.buton_Satisigerceklestir.Text = "Satışı Gerçekleştir";
            this.buton_Satisigerceklestir.UseVisualStyleBackColor = false;
            this.buton_Satisigerceklestir.Click += new System.EventHandler(this.buton_satisyap_Click);
            // 
            // buton_temizle
            // 
            this.buton_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buton_temizle.FlatAppearance.BorderSize = 2;
            this.buton_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buton_temizle.ForeColor = System.Drawing.Color.White;
            this.buton_temizle.Location = new System.Drawing.Point(134, 375);
            this.buton_temizle.Name = "buton_temizle";
            this.buton_temizle.Size = new System.Drawing.Size(109, 49);
            this.buton_temizle.TabIndex = 22;
            this.buton_temizle.Text = "Temizle";
            this.buton_temizle.UseVisualStyleBackColor = false;
            this.buton_temizle.Click += new System.EventHandler(this.buton_temizle_Click);
            // 
            // label_zorunlu2
            // 
            this.label_zorunlu2.AutoSize = true;
            this.label_zorunlu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zorunlu2.ForeColor = System.Drawing.Color.Red;
            this.label_zorunlu2.Location = new System.Drawing.Point(254, 221);
            this.label_zorunlu2.Name = "label_zorunlu2";
            this.label_zorunlu2.Size = new System.Drawing.Size(87, 16);
            this.label_zorunlu2.TabIndex = 23;
            this.label_zorunlu2.Text = "*Zorunlu Alan";
            // 
            // satisyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.label_zorunlu2);
            this.Controls.Add(this.buton_temizle);
            this.Controls.Add(this.buton_Satisigerceklestir);
            this.Controls.Add(this.label_zorunlu1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "satisyap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.satisyap_FormClosing_1);
            this.Load += new System.EventHandler(this.satisyap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_urunadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_urunfiyati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_urunkdv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_urunadet;
        private System.Windows.Forms.TextBox textbox_satinalanfirmaadi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_zorunlu1;
        private custombutton.mycustombutton buton_Satisigerceklestir;
        private custombutton.mycustombutton buton_temizle;
        private System.Windows.Forms.Label label_zorunlu2;
    }
}