namespace newproject
{
    partial class Product
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
            this.btbuy = new System.Windows.Forms.Button();
            this.btrfesh = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtsr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btbuy
            // 
            this.btbuy.Location = new System.Drawing.Point(592, 4);
            this.btbuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btbuy.Name = "btbuy";
            this.btbuy.Size = new System.Drawing.Size(115, 39);
            this.btbuy.TabIndex = 18;
            this.btbuy.Text = "Buy";
            this.btbuy.UseVisualStyleBackColor = true;
            this.btbuy.Click += new System.EventHandler(this.button4_Click);
            // 
            // btrfesh
            // 
            this.btrfesh.Location = new System.Drawing.Point(736, 4);
            this.btrfesh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btrfesh.Name = "btrfesh";
            this.btrfesh.Size = new System.Drawing.Size(115, 39);
            this.btrfesh.TabIndex = 17;
            this.btrfesh.Text = "Refesh";
            this.btrfesh.UseVisualStyleBackColor = true;
            this.btrfesh.Click += new System.EventHandler(this.button3_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(459, 3);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(115, 39);
            this.btsearch.TabIndex = 16;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsr
            // 
            this.txtsr.Location = new System.Drawing.Point(65, 9);
            this.txtsr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsr.Name = "txtsr";
            this.txtsr.Size = new System.Drawing.Size(343, 26);
            this.txtsr.TabIndex = 15;
            this.txtsr.TextChanged += new System.EventHandler(this.txtsr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Input:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 831);
            this.dataGridView1.TabIndex = 12;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "Trên 50",
            "Dưới 100",
            "Cao dần",
            "Thấp dần"});
            this.cbb1.Location = new System.Drawing.Point(858, 9);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(121, 28);
            this.cbb1.TabIndex = 19;
            this.cbb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 879);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.btbuy);
            this.Controls.Add(this.btrfesh);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbuy;
        private System.Windows.Forms.Button btrfesh;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb1;
    }
}