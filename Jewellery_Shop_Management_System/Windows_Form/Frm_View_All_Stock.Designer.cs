namespace Jewellery_Shop_Management_System
{
    partial class Frm_View_All_Stock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_All_Stock = new System.Windows.Forms.Label();
            this.gb_Product_ID = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.gb_View = new System.Windows.Forms.GroupBox();
            this.dgv_Stock_View = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productWeightAndPriceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewellery_Shop_Management_System_DBDataSet1 = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet1();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            this.product_Weight_And_Price_DetailsTableAdapter = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet1TableAdapters.Product_Weight_And_Price_DetailsTableAdapter();
            this.pnl_Header.SuspendLayout();
            this.gb_Product_ID.SuspendLayout();
            this.gb_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productWeightAndPriceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_All_Stock);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 57);
            this.pnl_Header.TabIndex = 6;
            // 
            // btn_X
            // 
            this.btn_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_X.BackColor = System.Drawing.Color.Black;
            this.btn_X.FlatAppearance.BorderSize = 0;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.Red;
            this.btn_X.Location = new System.Drawing.Point(814, 7);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(54, 39);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // lbl_All_Stock
            // 
            this.lbl_All_Stock.AutoSize = true;
            this.lbl_All_Stock.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_All_Stock.Location = new System.Drawing.Point(363, 14);
            this.lbl_All_Stock.Name = "lbl_All_Stock";
            this.lbl_All_Stock.Size = new System.Drawing.Size(132, 32);
            this.lbl_All_Stock.TabIndex = 0;
            this.lbl_All_Stock.Text = "All Stock";
            // 
            // gb_Product_ID
            // 
            this.gb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product_ID.Controls.Add(this.btn_Search);
            this.gb_Product_ID.Controls.Add(this.tb_Product_Name);
            this.gb_Product_ID.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_ID.Controls.Add(this.tb_Product_ID);
            this.gb_Product_ID.Controls.Add(this.lbl_ID);
            this.gb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_ID.Location = new System.Drawing.Point(12, 63);
            this.gb_Product_ID.Name = "gb_Product_ID";
            this.gb_Product_ID.Size = new System.Drawing.Size(850, 104);
            this.gb_Product_ID.TabIndex = 7;
            this.gb_Product_ID.TabStop = false;
            this.gb_Product_ID.Text = "Product ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(742, 40);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(102, 33);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_Name.Enabled = false;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(498, 46);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(218, 25);
            this.tb_Product_Name.TabIndex = 27;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(350, 47);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(142, 24);
            this.lbl_Product_Name.TabIndex = 26;
            this.lbl_Product_Name.Text = "Product Name";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(130, 46);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(193, 25);
            this.tb_Product_ID.TabIndex = 4;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(9, 47);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(115, 24);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Product ID ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_View
            // 
            this.gb_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_View.Controls.Add(this.dgv_Stock_View);
            this.gb_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_View.Location = new System.Drawing.Point(12, 173);
            this.gb_View.Name = "gb_View";
            this.gb_View.Size = new System.Drawing.Size(856, 241);
            this.gb_View.TabIndex = 8;
            this.gb_View.TabStop = false;
            this.gb_View.Text = "Stock View";
            // 
            // dgv_Stock_View
            // 
            this.dgv_Stock_View.AllowUserToAddRows = false;
            this.dgv_Stock_View.AllowUserToDeleteRows = false;
            this.dgv_Stock_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Stock_View.AutoGenerateColumns = false;
            this.dgv_Stock_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stock_View.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Stock_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Stock_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Stock_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.netWtDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.purityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currentStockDataGridViewTextBoxColumn});
            this.dgv_Stock_View.DataSource = this.productWeightAndPriceDetailsBindingSource;
            this.dgv_Stock_View.Location = new System.Drawing.Point(6, 21);
            this.dgv_Stock_View.Name = "dgv_Stock_View";
            this.dgv_Stock_View.ReadOnly = true;
            this.dgv_Stock_View.Size = new System.Drawing.Size(844, 214);
            this.dgv_Stock_View.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netWtDataGridViewTextBoxColumn
            // 
            this.netWtDataGridViewTextBoxColumn.DataPropertyName = "Net_Wt";
            this.netWtDataGridViewTextBoxColumn.HeaderText = "Net_Wt";
            this.netWtDataGridViewTextBoxColumn.Name = "netWtDataGridViewTextBoxColumn";
            this.netWtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purityDataGridViewTextBoxColumn
            // 
            this.purityDataGridViewTextBoxColumn.DataPropertyName = "Purity";
            this.purityDataGridViewTextBoxColumn.HeaderText = "Purity";
            this.purityDataGridViewTextBoxColumn.Name = "purityDataGridViewTextBoxColumn";
            this.purityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentStockDataGridViewTextBoxColumn
            // 
            this.currentStockDataGridViewTextBoxColumn.DataPropertyName = "Current_Stock";
            this.currentStockDataGridViewTextBoxColumn.HeaderText = "Current_Stock";
            this.currentStockDataGridViewTextBoxColumn.Name = "currentStockDataGridViewTextBoxColumn";
            this.currentStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productWeightAndPriceDetailsBindingSource
            // 
            this.productWeightAndPriceDetailsBindingSource.DataMember = "Product_Weight_And_Price_Details";
            this.productWeightAndPriceDetailsBindingSource.DataSource = this.jewellery_Shop_Management_System_DBDataSet1;
            // 
            // jewellery_Shop_Management_System_DBDataSet1
            // 
            this.jewellery_Shop_Management_System_DBDataSet1.DataSetName = "Jewellery_Shop_Management_System_DBDataSet1";
            this.jewellery_Shop_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Refresh_Grid
            // 
            this.btn_Refresh_Grid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Refresh_Grid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh_Grid.FlatAppearance.BorderSize = 0;
            this.btn_Refresh_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh_Grid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(341, 420);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(180, 33);
            this.btn_Refresh_Grid.TabIndex = 20;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // product_Weight_And_Price_DetailsTableAdapter
            // 
            this.product_Weight_And_Price_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_View_All_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.gb_View);
            this.Controls.Add(this.gb_Product_ID);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_View_All_Stock";
            this.Text = "View All Stock";
            this.Load += new System.EventHandler(this.Frm_View_All_Stock_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Product_ID.ResumeLayout(false);
            this.gb_Product_ID.PerformLayout();
            this.gb_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productWeightAndPriceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_All_Stock;
        private System.Windows.Forms.GroupBox gb_Product_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_View;
        private System.Windows.Forms.DataGridView dgv_Stock_View;
        private System.Windows.Forms.Button btn_Refresh_Grid;
        private Jewellery_Shop_Management_System_DBDataSet1 jewellery_Shop_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource productWeightAndPriceDetailsBindingSource;
        private Jewellery_Shop_Management_System_DBDataSet1TableAdapters.Product_Weight_And_Price_DetailsTableAdapter product_Weight_And_Price_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStockDataGridViewTextBoxColumn;
    }
}