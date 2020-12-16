
namespace acartuz
{
    partial class tumborclarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tumborclarim));
            this.buton_geridon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buton_geridon
            // 
            this.buton_geridon.BackColor = System.Drawing.Color.Transparent;
            this.buton_geridon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buton_geridon.BackgroundImage")));
            this.buton_geridon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buton_geridon.FlatAppearance.BorderSize = 0;
            this.buton_geridon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buton_geridon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buton_geridon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_geridon.Location = new System.Drawing.Point(25, 25);
            this.buton_geridon.Name = "buton_geridon";
            this.buton_geridon.Size = new System.Drawing.Size(50, 50);
            this.buton_geridon.TabIndex = 25;
            this.buton_geridon.UseVisualStyleBackColor = false;
            this.buton_geridon.Click += new System.EventHandler(this.buton_geridon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(354, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 607);
            this.dataGridView1.TabIndex = 26;
            // 
            // tumborclarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buton_geridon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tumborclarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Borçlarım";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tumborclarim_FormClosing_1);
            this.Load += new System.EventHandler(this.tumborclarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buton_geridon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}