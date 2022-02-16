
namespace SalesMGS
{
    partial class RestoreProductForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.dgvRetoreProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetoreProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(826, 38);
            this.txtSearch.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "SEARCH";
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Location = new System.Drawing.Point(978, 12);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(109, 38);
            this.btnRestoreAll.TabIndex = 32;
            this.btnRestoreAll.Text = "Retore All";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(1103, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(109, 38);
            this.btnRestore.TabIndex = 33;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // dgvRetoreProduct
            // 
            this.dgvRetoreProduct.AllowUserToAddRows = false;
            this.dgvRetoreProduct.AllowUserToDeleteRows = false;
            this.dgvRetoreProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRetoreProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRetoreProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetoreProduct.Location = new System.Drawing.Point(16, 89);
            this.dgvRetoreProduct.Name = "dgvRetoreProduct";
            this.dgvRetoreProduct.ReadOnly = true;
            this.dgvRetoreProduct.Size = new System.Drawing.Size(1196, 482);
            this.dgvRetoreProduct.TabIndex = 34;
            this.dgvRetoreProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // RestoreProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 583);
            this.Controls.Add(this.dgvRetoreProduct);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Name = "RestoreProductForm";
            this.Text = "RESTORE PRODUCT";
            this.Load += new System.EventHandler(this.RestoreProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetoreProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.DataGridView dgvRetoreProduct;
    }
}