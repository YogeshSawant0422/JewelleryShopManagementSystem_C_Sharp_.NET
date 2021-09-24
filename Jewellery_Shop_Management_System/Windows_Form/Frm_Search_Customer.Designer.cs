namespace Jewellery_Shop_Management_System
{
    partial class Frm_Manage_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_Manage_Customer = new System.Windows.Forms.Label();
            this.gb_Customer_Info = new System.Windows.Forms.GroupBox();
            this.tlp_Customer_Info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.billRecieptDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewellery_Shop_Management_System_DBDataSet3 = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet3();
            this.purchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewellery_Shop_Management_System_DBDataSet2 = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet2();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.purchase_DetailsTableAdapter = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet2TableAdapters.Purchase_DetailsTableAdapter();
            this.bill_Reciept_DetailsTableAdapter = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet3TableAdapters.Bill_Reciept_DetailsTableAdapter();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Customer_Details = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Bill_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Bill_Details = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jewellery_Shop_Management_System_DBDataSet4 = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet4();
            this.purchaseDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_DetailsTableAdapter1 = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet4TableAdapters.Purchase_DetailsTableAdapter();
            this.tlp_Manage_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Header.SuspendLayout();
            this.gb_Customer_Info.SuspendLayout();
            this.tlp_Customer_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billRecieptDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet2)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            this.gb_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Customer_Details)).BeginInit();
            this.gb_Bill_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource1)).BeginInit();
            this.tlp_Manage_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Manage_Customer);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(890, 57);
            this.pnl_Header.TabIndex = 3;
            // 
            // btn_X
            // 
            this.btn_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_X.BackColor = System.Drawing.Color.Black;
            this.btn_X.FlatAppearance.BorderSize = 0;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.Red;
            this.btn_X.Location = new System.Drawing.Point(830, 7);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(54, 39);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click_1);
            // 
            // lbl_Manage_Customer
            // 
            this.lbl_Manage_Customer.AutoSize = true;
            this.lbl_Manage_Customer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manage_Customer.Location = new System.Drawing.Point(326, 14);
            this.lbl_Manage_Customer.Name = "lbl_Manage_Customer";
            this.lbl_Manage_Customer.Size = new System.Drawing.Size(253, 32);
            this.lbl_Manage_Customer.TabIndex = 0;
            this.lbl_Manage_Customer.Text = "Manage Customer";
            // 
            // gb_Customer_Info
            // 
            this.gb_Customer_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Customer_Info.Controls.Add(this.tlp_Customer_Info);
            this.gb_Customer_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Info.Location = new System.Drawing.Point(10, 63);
            this.gb_Customer_Info.Name = "gb_Customer_Info";
            this.gb_Customer_Info.Size = new System.Drawing.Size(872, 115);
            this.gb_Customer_Info.TabIndex = 4;
            this.gb_Customer_Info.TabStop = false;
            this.gb_Customer_Info.Text = "Customer Info";
            // 
            // tlp_Customer_Info
            // 
            this.tlp_Customer_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Customer_Info.ColumnCount = 5;
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.32947F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.33411F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.18097F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16937F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.63805F));
            this.tlp_Customer_Info.Controls.Add(this.lbl_Customer_ID, 0, 0);
            this.tlp_Customer_Info.Controls.Add(this.tb_ID, 1, 0);
            this.tlp_Customer_Info.Controls.Add(this.btn_Search, 2, 0);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Name, 0, 1);
            this.tlp_Customer_Info.Controls.Add(this.tb_Name, 1, 1);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Mobile_Number, 3, 0);
            this.tlp_Customer_Info.Controls.Add(this.tb_Mobile_Number, 4, 0);
            this.tlp_Customer_Info.Controls.Add(this.tb_Date, 4, 1);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Date, 3, 1);
            this.tlp_Customer_Info.Location = new System.Drawing.Point(5, 18);
            this.tlp_Customer_Info.Name = "tlp_Customer_Info";
            this.tlp_Customer_Info.RowCount = 2;
            this.tlp_Customer_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tlp_Customer_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tlp_Customer_Info.Size = new System.Drawing.Size(862, 91);
            this.tlp_Customer_Info.TabIndex = 0;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(3, 11);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(152, 24);
            this.lbl_Customer_ID.TabIndex = 1;
            this.lbl_Customer_ID.Text = "Customer ID ";
            this.lbl_Customer_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(161, 10);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(221, 25);
            this.tb_ID.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(388, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 33);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(3, 56);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(152, 24);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(161, 56);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(221, 25);
            this.tb_Name.TabIndex = 4;
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(493, 11);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(142, 24);
            this.lbl_Mobile_Number.TabIndex = 22;
            this.lbl_Mobile_Number.Text = "Mo.No.";
            this.lbl_Mobile_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Mobile_Number.Enabled = false;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(641, 10);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(218, 25);
            this.tb_Mobile_Number.TabIndex = 23;
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Date.Enabled = false;
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.tb_Date.Location = new System.Drawing.Point(641, 56);
            this.tb_Date.MaxLength = 20;
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(218, 25);
            this.tb_Date.TabIndex = 27;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(493, 56);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(142, 24);
            this.lbl_Date.TabIndex = 26;
            this.lbl_Date.Text = "Purchase Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // billRecieptDetailsBindingSource
            // 
            this.billRecieptDetailsBindingSource.DataMember = "Bill_Reciept_Details";
            this.billRecieptDetailsBindingSource.DataSource = this.jewellery_Shop_Management_System_DBDataSet3;
            // 
            // jewellery_Shop_Management_System_DBDataSet3
            // 
            this.jewellery_Shop_Management_System_DBDataSet3.DataSetName = "Jewellery_Shop_Management_System_DBDataSet3";
            this.jewellery_Shop_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseDetailsBindingSource
            // 
            this.purchaseDetailsBindingSource.DataMember = "Purchase_Details";
            this.purchaseDetailsBindingSource.DataSource = this.jewellery_Shop_Management_System_DBDataSet2;
            // 
            // jewellery_Shop_Management_System_DBDataSet2
            // 
            this.jewellery_Shop_Management_System_DBDataSet2.DataSetName = "Jewellery_Shop_Management_System_DBDataSet2";
            this.jewellery_Shop_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Buttons.ColumnCount = 5;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.98608F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.772622F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.4942F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.728539F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45012F));
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 2, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(14, 455);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(862, 41);
            this.tlp_Buttons.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(310, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(244, 33);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Refresh Grid";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // purchase_DetailsTableAdapter
            // 
            this.purchase_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bill_Reciept_DetailsTableAdapter
            // 
            this.bill_Reciept_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Purchase_Details.Controls.Add(this.dgv_View_Customer_Details);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.Location = new System.Drawing.Point(3, 3);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(454, 259);
            this.gb_Purchase_Details.TabIndex = 6;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // dgv_View_Customer_Details
            // 
            this.dgv_View_Customer_Details.AllowUserToAddRows = false;
            this.dgv_View_Customer_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_Customer_Details.AutoGenerateColumns = false;
            this.dgv_View_Customer_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Customer_Details.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_View_Customer_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_View_Customer_Details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Customer_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_View_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Customer_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.purityDataGridViewTextBoxColumn,
            this.netWtDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgv_View_Customer_Details.DataSource = this.purchaseDetailsBindingSource;
            this.dgv_View_Customer_Details.Location = new System.Drawing.Point(3, 17);
            this.dgv_View_Customer_Details.Name = "dgv_View_Customer_Details";
            this.dgv_View_Customer_Details.ReadOnly = true;
            this.dgv_View_Customer_Details.RowHeadersVisible = false;
            this.dgv_View_Customer_Details.Size = new System.Drawing.Size(446, 236);
            this.dgv_View_Customer_Details.TabIndex = 1;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            this.subCategoryDataGridViewTextBoxColumn.DataPropertyName = "Sub_Category";
            this.subCategoryDataGridViewTextBoxColumn.HeaderText = "Sub_Category";
            this.subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            this.subCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purityDataGridViewTextBoxColumn
            // 
            this.purityDataGridViewTextBoxColumn.DataPropertyName = "Purity";
            this.purityDataGridViewTextBoxColumn.HeaderText = "Purity";
            this.purityDataGridViewTextBoxColumn.Name = "purityDataGridViewTextBoxColumn";
            this.purityDataGridViewTextBoxColumn.ReadOnly = true;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gb_Bill_Details
            // 
            this.gb_Bill_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Bill_Details.Controls.Add(this.dgv_Bill_Details);
            this.gb_Bill_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bill_Details.Location = new System.Drawing.Point(463, 3);
            this.gb_Bill_Details.Name = "gb_Bill_Details";
            this.gb_Bill_Details.Size = new System.Drawing.Size(418, 259);
            this.gb_Bill_Details.TabIndex = 7;
            this.gb_Bill_Details.TabStop = false;
            this.gb_Bill_Details.Text = "Bill Details";
            // 
            // dgv_Bill_Details
            // 
            this.dgv_Bill_Details.AllowUserToAddRows = false;
            this.dgv_Bill_Details.AllowUserToDeleteRows = false;
            this.dgv_Bill_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Bill_Details.AutoGenerateColumns = false;
            this.dgv_Bill_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill_Details.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Bill_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bill_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Bill_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.gSTDataGridViewTextBoxColumn,
            this.otherAmountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paymentModeDataGridViewTextBoxColumn});
            this.dgv_Bill_Details.DataSource = this.billRecieptDetailsBindingSource;
            this.dgv_Bill_Details.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_Bill_Details.Location = new System.Drawing.Point(4, 17);
            this.dgv_Bill_Details.Name = "dgv_Bill_Details";
            this.dgv_Bill_Details.ReadOnly = true;
            this.dgv_Bill_Details.RowHeadersVisible = false;
            this.dgv_Bill_Details.Size = new System.Drawing.Size(409, 236);
            this.dgv_Bill_Details.TabIndex = 2;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gSTDataGridViewTextBoxColumn
            // 
            this.gSTDataGridViewTextBoxColumn.DataPropertyName = "GST";
            this.gSTDataGridViewTextBoxColumn.HeaderText = "GST";
            this.gSTDataGridViewTextBoxColumn.Name = "gSTDataGridViewTextBoxColumn";
            this.gSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherAmountDataGridViewTextBoxColumn
            // 
            this.otherAmountDataGridViewTextBoxColumn.DataPropertyName = "Other_Amount";
            this.otherAmountDataGridViewTextBoxColumn.HeaderText = "Other_Amount";
            this.otherAmountDataGridViewTextBoxColumn.Name = "otherAmountDataGridViewTextBoxColumn";
            this.otherAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentModeDataGridViewTextBoxColumn
            // 
            this.paymentModeDataGridViewTextBoxColumn.DataPropertyName = "Payment_Mode";
            this.paymentModeDataGridViewTextBoxColumn.HeaderText = "Payment_Mode";
            this.paymentModeDataGridViewTextBoxColumn.Name = "paymentModeDataGridViewTextBoxColumn";
            this.paymentModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jewellery_Shop_Management_System_DBDataSet4
            // 
            this.jewellery_Shop_Management_System_DBDataSet4.DataSetName = "Jewellery_Shop_Management_System_DBDataSet4";
            this.jewellery_Shop_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseDetailsBindingSource1
            // 
            this.purchaseDetailsBindingSource1.DataMember = "Purchase_Details";
            this.purchaseDetailsBindingSource1.DataSource = this.jewellery_Shop_Management_System_DBDataSet4;
            // 
            // purchase_DetailsTableAdapter1
            // 
            this.purchase_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tlp_Manage_Customer
            // 
            this.tlp_Manage_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Manage_Customer.ColumnCount = 2;
            this.tlp_Manage_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Manage_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tlp_Manage_Customer.Controls.Add(this.gb_Bill_Details, 1, 0);
            this.tlp_Manage_Customer.Controls.Add(this.gb_Purchase_Details, 0, 0);
            this.tlp_Manage_Customer.Location = new System.Drawing.Point(4, 184);
            this.tlp_Manage_Customer.Name = "tlp_Manage_Customer";
            this.tlp_Manage_Customer.RowCount = 1;
            this.tlp_Manage_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Manage_Customer.Size = new System.Drawing.Size(884, 265);
            this.tlp_Manage_Customer.TabIndex = 7;
            // 
            // Frm_Manage_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Manage_Customer);
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.gb_Customer_Info);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Manage_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Customer";
            this.Load += new System.EventHandler(this.Frm_Manage_Customer_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Customer_Info.ResumeLayout(false);
            this.tlp_Customer_Info.ResumeLayout(false);
            this.tlp_Customer_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billRecieptDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet2)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            this.gb_Purchase_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Customer_Details)).EndInit();
            this.gb_Bill_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource1)).EndInit();
            this.tlp_Manage_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Manage_Customer;
        private System.Windows.Forms.GroupBox gb_Customer_Info;
        private System.Windows.Forms.TableLayoutPanel tlp_Customer_Info;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Refresh;
        private Jewellery_Shop_Management_System_DBDataSet2 jewellery_Shop_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource;
        private Jewellery_Shop_Management_System_DBDataSet2TableAdapters.Purchase_DetailsTableAdapter purchase_DetailsTableAdapter;
        private Jewellery_Shop_Management_System_DBDataSet3 jewellery_Shop_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource billRecieptDetailsBindingSource;
        private Jewellery_Shop_Management_System_DBDataSet3TableAdapters.Bill_Reciept_DetailsTableAdapter bill_Reciept_DetailsTableAdapter;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.DataGridView dgv_View_Customer_Details;
        private System.Windows.Forms.GroupBox gb_Bill_Details;
        private System.Windows.Forms.DataGridView dgv_Bill_Details;
        private Jewellery_Shop_Management_System_DBDataSet4 jewellery_Shop_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource1;
        private Jewellery_Shop_Management_System_DBDataSet4TableAdapters.Purchase_DetailsTableAdapter purchase_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tlp_Manage_Customer;

    }
}