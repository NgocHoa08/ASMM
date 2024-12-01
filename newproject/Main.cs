using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject
{
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private Form formbo;
        private void opencon(Form Con) {
            if(formbo!= null)
            {
                formbo.Close();
            }
            formbo = Con;
            Con.TopLevel = false;
            Con.FormBorderStyle = FormBorderStyle.None;
            Con.Dock = DockStyle.Fill;
            panel1.Controls.Add(Con);
            panel1.Tag = Con;
            Con.BringToFront();
            Con.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opencon(new Employee());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pichome.Visible = true;
            picmana.Visible = false;
            picpro.Visible = false;
            if (formbo != null)
            {
                formbo.Close();
            }
        }

        private void quầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picmana.Visible = true;
            picpro.Visible = false;
            pichome.Visible = false;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opencon(new Customer());
        }

        private void áoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opencon(new Shirt());
        }

        private void giàyDépToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opencon(new Static());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void hỗTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menu3_Click(object sender, EventArgs e)
        {
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcs function = new Funcs();
            function.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncEpl FuncEpl = new FuncEpl();
            FuncEpl.ShowDialog();
        }

        private void trousersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funPRD funtPRD = new funPRD();
            funtPRD.ShowDialog();
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void shoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menufun_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opencon(new Product());
        }
    }
}
