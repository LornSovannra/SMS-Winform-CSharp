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
    public partial class CategoryForm : Form
    {
        OracleConnection conn;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            conn = DBConnection.Connect();
            LoadData();
        }

        void LoadData()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            OracleCommand select_cmd = new OracleCommand("SelectCategory", conn);
            select_cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapt = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dgvCategory.DataSource = dt;
            dgvCategory.ClearSelection();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAddNew.Text == "Add New")
                {
                    btnAddNew.Text = "Save";
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = true;
                    btnDelete.Text = "Cancel";
                    dgvCategory.Enabled = false;
                }
                else if (btnAddNew.Text == "Save")
                {
                    OracleCommand cmd_insert = new OracleCommand("InsertCategory", conn);
                    cmd_insert.CommandType = CommandType.StoredProcedure;
                    cmd_insert.Parameters.Add(new OracleParameter("vCategoryName", txtCategoryName.Text));
                    cmd_insert.Parameters.Add(new OracleParameter("vDescription", rtbDescription.Text));
                    cmd_insert.Parameters.Add(new OracleParameter("vCreateDate", DateTime.Now.ToString("dd-MMMM-yy")));
                    cmd_insert.Parameters.Add(new OracleParameter("vCreateBy", UserLogin.getEmployeeName()));

                    if (cmd_insert.ExecuteNonQuery() == -1)
                    {
                        btnAddNew.Text = "Add New";
                        btnUpdate.Enabled = true;
                        btnDelete.Text = "Delete";
                        dgvCategory.Enabled = true;
                        LoadData();

                        MessageBox.Show("One record has added to database!", "ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update, " + txtCategoryName.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleCommand update_cmd = new OracleCommand("UpdateCategory", conn);
                    update_cmd.CommandType = CommandType.StoredProcedure;
                    update_cmd.Parameters.Add("vCategoryID", Int32.Parse(txtCategoryID.Text));
                    update_cmd.Parameters.Add("vCategoryName", txtCategoryName.Text);
                    update_cmd.Parameters.Add("vDescription", rtbDescription.Text);
                    update_cmd.Parameters.Add("vUpdateDate", DateTime.Now.ToString("dd-MMMM-yy"));
                    update_cmd.Parameters.Add("vUpdateBy", UserLogin.getEmployeeName());
                    

                    if (update_cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Record updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Fail to updated", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDelete.Text == "Cancel")
                {
                    btnAddNew.Text = "Add New";
                    btnDelete.Enabled = false;
                    btnDelete.Text = "Delete";
                    dgvCategory.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtCategoryName.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OracleCommand delete_cmd = new OracleCommand("DeleteCategory", conn);
                        delete_cmd.CommandType = CommandType.StoredProcedure;
                        delete_cmd.Parameters.Add("vCategoryID", Int32.Parse(txtCategoryID.Text));

                        if (delete_cmd.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("One record has deleted from Database!", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Fail to delete!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtCategoryID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            rtbDescription.Text = dgvCategory.CurrentRow.Cells[2].Value.ToString();
        }
    }
}