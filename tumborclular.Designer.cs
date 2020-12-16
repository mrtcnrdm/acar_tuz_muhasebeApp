
namespace acartuz
{
    partial class tumborclular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tumborclular));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buton_geri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1196, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // buton_geri
            // 
            this.buton_geri.BackColor = System.Drawing.Color.Transparent;
            this.buton_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buton_geri.BackgroundImage")));
            this.buton_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buton_geri.FlatAppearance.BorderSize = 0;
            this.buton_geri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buton_geri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buton_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_geri.Location = new System.Drawing.Point(25, 25);
            this.buton_geri.Name = "buton_geri";
            this.buton_geri.Size = new System.Drawing.Size(50, 50);
            this.buton_geri.TabIndex = 1;
            this.buton_geri.UseVisualStyleBackColor = false;
            this.buton_geri.Click += new System.EventHandler(this.buton_geri_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 559);
            this.panel1.TabIndex = 2;
            // 
            // tumborclular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1241, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buton_geri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tumborclular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Borçlular";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tumborclular_FormClosing);
            this.Load += new System.EventHandler(this.tumborclular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buton_geri;
        private System.Windows.Forms.Panel panel1;
    }
}