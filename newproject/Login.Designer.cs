namespace newproject
{
    partial class Login
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btcreate = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcf = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.Label();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(629, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Turn off Show Password:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btcreate
            // 
            this.btcreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcreate.Location = new System.Drawing.Point(629, 111);
            this.btcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(194, 69);
            this.btcreate.TabIndex = 8;
            this.btcreate.Text = "Create Account";
            this.btcreate.UseVisualStyleBackColor = true;
            this.btcreate.Visible = false;
            this.btcreate.Click += new System.EventHandler(this.btcreate_Click);
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.Location = new System.Drawing.Point(629, 21);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(194, 69);
            this.btlogin.TabIndex = 6;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(629, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "You do not have an account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblcf
            // 
            this.lblcf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcf.AutoSize = true;
            this.lblcf.Location = new System.Drawing.Point(19, 111);
            this.lblcf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcf.Name = "lblcf";
            this.lblcf.Size = new System.Drawing.Size(118, 20);
            this.lblcf.TabIndex = 7;
            this.lblcf.Text = "ConForm Pass:";
            this.lblcf.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pass Word:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Name:";
            // 
            // txtcf
            // 
            this.txtcf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcf.Location = new System.Drawing.Point(167, 111);
            this.txtcf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcf.MaxLength = 50;
            this.txtcf.Name = "txtcf";
            this.txtcf.PasswordChar = '*';
            this.txtcf.Size = new System.Drawing.Size(423, 26);
            this.txtcf.TabIndex = 12;
            this.txtcf.Visible = false;
            this.txtcf.TextChanged += new System.EventHandler(this.txtcf_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.Location = new System.Drawing.Point(167, 64);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 50;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(423, 26);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtname.Location = new System.Drawing.Point(167, 21);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.MaxLength = 50;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(423, 26);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtcusid
            // 
            this.txtcusid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcusid.Location = new System.Drawing.Point(167, 154);
            this.txtcusid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcusid.MaxLength = 50;
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(423, 26);
            this.txtcusid.TabIndex = 2;
            this.txtcusid.Visible = false;
            this.txtcusid.TextChanged += new System.EventHandler(this.txtcusid_TextChanged);
            // 
            // Customer
            // 
            this.Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(34, 154);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(103, 20);
            this.Customer.TabIndex = 7;
            this.Customer.Text = "Customer ID:";
            this.Customer.Visible = false;
            // 
            // txtcusname
            // 
            this.txtcusname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcusname.Location = new System.Drawing.Point(166, 203);
            this.txtcusname.Margin = new System.Windows.Forms.Padding(4);
            this.txtcusname.MaxLength = 50;
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(423, 26);
            this.txtcusname.TabIndex = 3;
            this.txtcusname.Visible = false;
            this.txtcusname.TextChanged += new System.EventHandler(this.txtcusname_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Name:";
            this.label3.Visible = false;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtphone.Location = new System.Drawing.Point(166, 249);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.MaxLength = 50;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(423, 26);
            this.txtphone.TabIndex = 4;
            this.txtphone.Visible = false;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone:";
            this.label4.Visible = false;
            // 
            // txtadd
            // 
            this.txtadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtadd.Location = new System.Drawing.Point(166, 304);
            this.txtadd.Margin = new System.Windows.Forms.Padding(4);
            this.txtadd.MaxLength = 50;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(423, 26);
            this.txtadd.TabIndex = 5;
            this.txtadd.Visible = false;
            this.txtadd.TextChanged += new System.EventHandler(this.txtadd_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address:";
            this.label5.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 395);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btcreate);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.lblcf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcusname);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.txtcf);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcf;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label5;
    }
}