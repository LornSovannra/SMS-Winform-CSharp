
namespace SalesMGS
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUnitPriceIn = new System.Windows.Forms.TextBox();
            this.txtUnitPriceOut = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.btnRemovePhoto = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ofdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category ID";
            // 
            // cbCategoryID
            // 
            this.cbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryID.FormattingEnabled = true;
            this.cbCategoryID.Location = new System.Drawing.Point(129, 96);
            this.cbCategoryID.Name = "cbCategoryID";
            this.cbCategoryID.Size = new System.Drawing.Size(175, 28);
            this.cbCategoryID.TabIndex = 3;
            this.cbCategoryID.SelectedIndexChanged += new System.EventHandler(this.cbCategoryID_SelectedIndexChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(129, 23);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(175, 26);
            this.txtProductID.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(129, 59);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(175, 26);
            this.txtProductName.TabIndex = 2;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(129, 132);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(175, 26);
            this.txtBarcode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Expire Date";
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.CustomFormat = "dd-MMM-yy";
            this.dtpExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireDate.Location = new System.Drawing.Point(441, 23);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(200, 26);
            this.dtpExpireDate.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(441, 61);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 26);
            this.txtQty.TabIndex = 6;
            // 
            // txtUnitPriceIn
            // 
            this.txtUnitPriceIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceIn.Location = new System.Drawing.Point(441, 99);
            this.txtUnitPriceIn.Name = "txtUnitPriceIn";
            this.txtUnitPriceIn.Size = new System.Drawing.Size(176, 26);
            this.txtUnitPriceIn.TabIndex = 7;
            // 
            // txtUnitPriceOut
            // 
            this.txtUnitPriceOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceOut.Location = new System.Drawing.Point(441, 134);
            this.txtUnitPriceOut.Name = "txtUnitPriceOut";
            this.txtUnitPriceOut.Size = new System.Drawing.Size(176, 26);
            this.txtUnitPriceOut.TabIndex = 8;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(668, 47);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(200, 107);
            this.rtbDescription.TabIndex = 9;
            this.rtbDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Unit Price In";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Unit Price Out";
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(895, 125);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(95, 32);
            this.btnSelectPhoto.TabIndex = 10;
            this.btnSelectPhoto.Text = "Select Photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // btnRemovePhoto
            // 
            this.btnRemovePhoto.Location = new System.Drawing.Point(996, 125);
            this.btnRemovePhoto.Name = "btnRemovePhoto";
            this.btnRemovePhoto.Size = new System.Drawing.Size(91, 32);
            this.btnRemovePhoto.TabIndex = 11;
            this.btnRemovePhoto.Text = "Remove Photo";
            this.btnRemovePhoto.UseVisualStyleBackColor = true;
            this.btnRemovePhoto.Click += new System.EventHandler(this.btnRemovePhoto_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1117, 19);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(91, 32);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1117, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 32);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1117, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(1117, 125);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 32);
            this.btnRestore.TabIndex = 15;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(107, 191);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(534, 28);
            this.txtSearch.TabIndex = 16;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(16, 225);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1192, 346);
            this.dgvProduct.TabIndex = 30;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // ofdPhoto
            // 
            this.ofdPhoto.FileName = "openFileDialog1";
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.White;
            this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductImage.Image = global::SalesMGS.Properties.Resources.product_default;
            this.pbProductImage.Location = new System.Drawing.Point(895, 23);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(192, 96);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 21;
            this.pbProductImage.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(623, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(623, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "$";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1117, 163);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(91, 32);
            this.btnReport.TabIndex = 33;
            this.btnReport.Text = "Make Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 583);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnRemovePhoto);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.txtUnitPriceOut);
            this.Controls.Add(this.txtUnitPriceIn);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.dtpExpireDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.cbCategoryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRODUCT";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoryID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUnitPriceIn;
        private System.Windows.Forms.TextBox txtUnitPriceOut;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Button btnRemovePhoto;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.OpenFileDialog ofdPhoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReport;
    }
}