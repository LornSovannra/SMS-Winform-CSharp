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
    public partial class RestoreProductForm : Form
    {
        OracleConnection conn;

        public RestoreProductForm()
        {
            InitializeComponent();
        }

        private void RestoreProductForm_Load(object sender, EventArgs e)
        {
            conn = DBConnection.Connect();
            LoadData(1);
        }

        void LoadData(int isDeleted)
        {
            btnRestore.Enabled = false;

            OracleCommand select_cmd = new OracleCommand("SelectProduct", conn);
            select_cmd.CommandType = CommandType.StoredProcedure;
            select_cmd.Parameters.Add("vIsDeleted", isDeleted);
            OracleDataAdapter adapt = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dgvRetoreProduct.DataSource = dt;
            dgvRetoreProduct.ClearSelection();

            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            dgvRetoreProduct.RowTemplate.Height = 80;
            imgcolumn = (DataGridViewImageColumn)dgvRetoreProduct.Columns[9];
            imgcolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        string ProductID;
        string ProductName;

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRestore.Enabled = true;

            ProductID = dgvRetoreProduct.CurrentRow.Cells[0].Value.ToString();
            ProductName = dgvRetoreProduct.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnRestoreAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to restore all?", "RESTORE ALL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleCommand restore_all_cmd = new OracleCommand("RestoreAllProduct", conn);
                    restore_all_cmd.CommandType = CommandType.StoredProcedure;

                    if (restore_all_cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Records restored to Database!", "RESTORED ALL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(1);
                    }
                    else
                    {
                        MessageBox.Show("Fail to restore!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to restore, " + ProductName + "?", "RESTORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleCommand delete_cmd = new OracleCommand("DeleteProduct", conn);
                    delete_cmd.CommandType = CommandType.StoredProcedure;
                    delete_cmd.Parameters.Add("vProductID", Int32.Parse(ProductID));
                    delete_cmd.Parameters.Add("vIsDeleted", Int32.Parse("0"));

                    if (delete_cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("One record has restored to Database!", "RESTORED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(1);
                    }
                    else
                    {
                        MessageBox.Show("Fail to restore!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
