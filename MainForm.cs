using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesMGS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslUsername.Text = UserLogin.getEmployeeName();
            tsslUserType.Text = UserLogin.getUserType();
            tsslDate.Text = DateTime.Now.ToString("D");
            tsslTime.Text = DateTime.Now.ToString("T");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString("T");
        }

        private void OpenForm(Form form, string title)
        {
            bool isOpen = false;
            foreach (Form forms in Application.OpenForms)
            {
                if (forms.Text == title)
                {
                    isOpen = true;
                    form.Focus();
                }
            }

            if (isOpen == false)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void ctsmiCategory_Click(object sender, EventArgs e)
        {
            OpenForm(new CategoryForm(), "CATEGORY");
        }

        private void ptsmiProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductForm(), "PRODUCT");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout from this account?", "You're going to logout from this account!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm f = new LoginForm();
                this.Close();
                f.Show();
            }
        }
    }
}
