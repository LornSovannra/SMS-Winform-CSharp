using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SalesMGS
{
    public partial class LoginForm : Form
    {
        OracleConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = DBConnection.Connect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please enter username", "Require Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter password", "Require Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else
                {
                    string sql = "SELECT * FROM tblEmployees WHERE USERNAME = '" + txtUsername.Text + "' AND PASSWORD = '" + txtPassword.Text + "'";
                    OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        //Invoke class from UserLogin Class
                        //Save User Login Info
                        UserLogin.setEmployeeID(dt.Rows[0]["EmployeeID"].ToString());
                        UserLogin.setEmployeeName(dt.Rows[0]["EmployeeName"].ToString());
                        UserLogin.setUserTyoe(dt.Rows[0]["UserType"].ToString());

                        //Show MainForm
                        MainForm frm = new MainForm();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong credential!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
