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
using System.IO;
using SalesMGS.Properties;

namespace SalesMGS
{
    public partial class ProductForm : Form
    {
        OracleConnection conn;
        string CategoryID;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            conn = DBConnection.Connect();
            LoadData(0);
            ComboBoxShowCategory();
        }

        void LoadData(int isDeleted)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            OracleCommand select_cmd = new OracleCommand("SelectProduct", conn);
            select_cmd.CommandType = CommandType.StoredProcedure;
            select_cmd.Parameters.Add("vIsDeleted", isDeleted);
            OracleDataAdapter adapt = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dgvProduct.DataSource = dt;
            dgvProduct.ClearSelection();

            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            dgvProduct.RowTemplate.Height = 80;
            imgcolumn = (DataGridViewImageColumn)dgvProduct.Columns[9];
            imgcolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //Invisible column isDeleted
            dgvProduct.Columns[10].Visible = false;
        }

        public void ComboBoxShowCategory()
        {
            OracleCommand select_cmd = new OracleCommand("SelectCategory", conn);
            select_cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapt = new OracleDataAdapter(select_cmd);

            string select_sql = "SELECT CategoryID, CategoryName FROM tblCategories";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbCategoryID.Items.Add(dr["CategoryName"].ToString());
                cbCategoryID.DisplayMember = (dr["CategoryName"].ToString());
                cbCategoryID.ValueMember = (dr["CategoryID"].ToString());
            }
        }

        private void cbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string select_sql = "SELECT CategoryID FROM tblCategories WHERE CategoryName = '" + cbCategoryID.SelectedItem + "'";
                OracleCommand select_cmd = new OracleCommand(select_sql, conn);
                OracleDataReader dr = select_cmd.ExecuteReader();

                while (dr.Read())
                {
                    CategoryID = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                form.Show();
            }
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
                    dgvProduct.Enabled = false;
                }
                else if (btnAddNew.Text == "Save")
                {
                    MemoryStream ms = new MemoryStream();
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);

                    string insert_sql = "INSERT INTO tblProducts(ProductName, Description, CategoryID, Barcode, ExpireDate, Qty, UnitPriceIn, UnitPriceOut, ProductImage, IsDeleted)" +
                                        "VALUES(:1, :2, :3, :4, :5, :6, :7, :8, :9, :10)";
                    OracleCommand cmd_insert = new OracleCommand(insert_sql, conn);
                    cmd_insert.Parameters.Add(new OracleParameter("1", txtProductName.Text));
                    cmd_insert.Parameters.Add(new OracleParameter("2", rtbDescription.Text));
                    cmd_insert.Parameters.Add(new OracleParameter("3", Int32.Parse(CategoryID)));
                    cmd_insert.Parameters.Add(new OracleParameter("4", txtBarcode.Text));
                    cmd_insert.Parameters.Add(new OracleParameter("5", dtpExpireDate.Value));
                    cmd_insert.Parameters.Add(new OracleParameter("6", Int32.Parse(txtQty.Text)));
                    cmd_insert.Parameters.Add(new OracleParameter("7", Decimal.Parse(txtUnitPriceIn.Text)));
                    cmd_insert.Parameters.Add(new OracleParameter("8", Decimal.Parse(txtUnitPriceOut.Text)));
                    cmd_insert.Parameters.Add(new OracleParameter("9", ms.ToArray()));
                    cmd_insert.Parameters.Add(new OracleParameter("10", Int32.Parse("0")));

                    if (cmd_insert.ExecuteNonQuery() > 0)
                    {
                        btnAddNew.Text = "Add New";
                        btnUpdate.Enabled = true;
                        btnDelete.Text = "Delete";
                        dgvProduct.Enabled = true;
                        LoadData(0);

                        MessageBox.Show("One record has added to database!", "ADDED", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Are you sure to update, " + txtProductName.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string update_sql = "UPDATE tblProducts SET ProductName = :1, Description = :2, CategoryID = :3, Barcode = :4, ExpireDate = :5, Qty = :6, UnitPriceIn = :7," +
                                        "UnitPriceOut = :8, ProductImage = :9 WHERE ProductID = :10";
                    OracleCommand update_cmd = new OracleCommand(update_sql, conn);
                    update_cmd.Parameters.Add("1", txtProductName.Text);
                    update_cmd.Parameters.Add("2", rtbDescription.Text);
                    update_cmd.Parameters.Add("3", Int32.Parse(CategoryID));
                    update_cmd.Parameters.Add("4", txtBarcode.Text);
                    update_cmd.Parameters.Add("5", dtpExpireDate.Value);
                    update_cmd.Parameters.Add("6", Int32.Parse(txtQty.Text));
                    update_cmd.Parameters.Add("7", Decimal.Parse(txtUnitPriceIn.Text));
                    update_cmd.Parameters.Add("8", Decimal.Parse(txtUnitPriceOut.Text));

                    MemoryStream ms = new MemoryStream();
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat);
                    update_cmd.Parameters.Add("9", OracleDbType.Blob).Value = ms.ToArray();

                    update_cmd.Parameters.Add("10", Int32.Parse(txtProductID.Text));

                    if(update_cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(0);
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
                    dgvProduct.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtProductName.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OracleCommand delete_cmd = new OracleCommand("DeleteProduct", conn);
                        delete_cmd.CommandType = CommandType.StoredProcedure;
                        delete_cmd.Parameters.Add("vProductID", Int32.Parse(txtProductID.Text));
                        delete_cmd.Parameters.Add("vIsDeleted", Int32.Parse("1"));

                        if (delete_cmd.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("One record has deleted from Database!", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(0);
                        }
                        else
                        {
                            MessageBox.Show("Fail to delete!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            OpenForm(new RestoreProductForm(), "RESTORE PRODUCT");
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            ofdPhoto.FilterIndex = 4;
            ofdPhoto.Filter = ("Images | *.png; *.jpg; *.jpeg; *.bmp;");
            ofdPhoto.FileName = string.Empty;

            if (ofdPhoto.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.Image = Image.FromFile(ofdPhoto.FileName);
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pbProductImage.Image = Resources.product_default;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtProductID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            rtbDescription.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            
            CategoryID = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            cbCategoryID.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();

            txtBarcode.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            dtpExpireDate.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
            txtQty.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
            txtUnitPriceIn.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
            txtUnitPriceOut.Text = dgvProduct.CurrentRow.Cells[8].Value.ToString();

            //get and show image
            byte[] img = (byte[])dgvProduct.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(img);
            pbProductImage.Image = Image.FromStream(ms);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ProductReportForm f = new ProductReportForm();
            f.ShowDialog();
        }
    }
}