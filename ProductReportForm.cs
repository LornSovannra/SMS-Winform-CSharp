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
    public partial class ProductReportForm : Form
    {
        OracleConnection conn = DBConnection.Connect();

        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            string select_sql = "SELECT * FROM tblProducts ORDER BY ProductID";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Products");
            CrystalReport crpt = new CrystalReport();
            crpt.SetDataSource(ds.Tables["Products"]);

            crpt.Parameter_ProductName.CurrentValues.Clear();
            crpt.Parameter_ProductName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ProductName", crpt.Parameter_ProductName.CurrentValues);

            crystalReportViewerProduct.ReportSource = crpt;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string select_sql = "SELECT * FROM tblProducts ORDER BY ProductID";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Products");
            CrystalReport crpt = new CrystalReport();
            crpt.SetDataSource(ds.Tables["Products"]);

            crpt.Parameter_ProductName.CurrentValues.Clear();
            crpt.Parameter_ProductName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ProductName", crpt.Parameter_ProductName.CurrentValues);

            crystalReportViewerProduct.ReportSource = crpt;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShowReport.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
