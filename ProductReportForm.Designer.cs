
namespace SalesMGS
{
    partial class ProductReportForm
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
            this.crystalReportViewerProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewerProduct
            // 
            this.crystalReportViewerProduct.ActiveViewIndex = -1;
            this.crystalReportViewerProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewerProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerProduct.Location = new System.Drawing.Point(0, 44);
            this.crystalReportViewerProduct.Name = "crystalReportViewerProduct";
            this.crystalReportViewerProduct.Size = new System.Drawing.Size(1224, 769);
            this.crystalReportViewerProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Product";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(137, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(956, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowReport.Location = new System.Drawing.Point(1099, 12);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(113, 26);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 813);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewerProduct);
            this.Name = "ProductReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductReportForm";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowReport;
    }
}