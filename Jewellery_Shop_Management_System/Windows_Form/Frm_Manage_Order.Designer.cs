namespace Jewellery_Shop_Management_System
{
    partial class Frm_Manage_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_Manage_Order = new System.Windows.Forms.Label();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Customer_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Remaining_Amount = new System.Windows.Forms.Label();
            this.tb_Remaining_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Order_Placed = new System.Windows.Forms.Label();
            this.gb_Order_Placed = new System.Windows.Forms.GroupBox();
            this.rb_Yes = new System.Windows.Forms.RadioButton();
            this.rb_No = new System.Windows.Forms.RadioButton();
            this.lbl_Total_Amount_Paid = new System.Windows.Forms.Label();
            this.gb_Total_Paid = new System.Windows.Forms.GroupBox();
            this.rb_Total_Paid_Yes = new System.Windows.Forms.RadioButton();
            this.rb_Total_Paid_No = new System.Windows.Forms.RadioButton();
            this.gb_View_Order_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Orders = new System.Windows.Forms.DataGridView();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            this.jewellery_Shop_Management_System_DBDataSet = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet();
            this.purchasedOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchased_Order_DetailsTableAdapter = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSetTableAdapters.Purchased_Order_DetailsTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPlacedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header.SuspendLayout();
            this.gb_Customer_Details.SuspendLayout();
            this.tlp_Customer_Details.SuspendLayout();
            this.gb_Order_Placed.SuspendLayout();
            this.gb_Total_Paid.SuspendLayout();
            this.gb_View_Order_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Orders)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedOrderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Manage_Order);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 57);
            this.pnl_Header.TabIndex = 5;
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
            // lbl_Manage_Order
            // 
            this.lbl_Manage_Order.AutoSize = true;
            this.lbl_Manage_Order.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manage_Order.Location = new System.Drawing.Point(326, 14);
            this.lbl_Manage_Order.Name = "lbl_Manage_Order";
            this.lbl_Manage_Order.Size = new System.Drawing.Size(198, 32);
            this.lbl_Manage_Order.TabIndex = 0;
            this.lbl_Manage_Order.Text = "Manage Order";
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Customer_Details.Controls.Add(this.tlp_Customer_Details);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.Location = new System.Drawing.Point(5, 61);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(865, 174);
            this.gb_Customer_Details.TabIndex = 7;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // tlp_Customer_Details
            // 
            this.tlp_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Customer_Details.ColumnCount = 7;
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9501188F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75961F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59615F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1639F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.50961F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.11539F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlp_Customer_Details.Controls.Add(this.lbl_ID, 1, 0);
            this.tlp_Customer_Details.Controls.Add(this.tb_ID, 2, 0);
            this.tlp_Customer_Details.Controls.Add(this.btn_Search, 3, 0);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Name, 4, 0);
            this.tlp_Customer_Details.Controls.Add(this.tb_Name, 5, 0);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Total_Amount, 1, 1);
            this.tlp_Customer_Details.Controls.Add(this.tb_Total_Amount, 2, 1);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Remaining_Amount, 1, 2);
            this.tlp_Customer_Details.Controls.Add(this.tb_Remaining_Amount, 2, 2);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Order_Placed, 4, 2);
            this.tlp_Customer_Details.Controls.Add(this.gb_Order_Placed, 5, 2);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Total_Amount_Paid, 4, 1);
            this.tlp_Customer_Details.Controls.Add(this.gb_Total_Paid, 5, 1);
            this.tlp_Customer_Details.Location = new System.Drawing.Point(6, 18);
            this.tlp_Customer_Details.Name = "tlp_Customer_Details";
            this.tlp_Customer_Details.RowCount = 3;
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.95833F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.04167F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_Customer_Details.Size = new System.Drawing.Size(853, 141);
            this.tlp_Customer_Details.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(10, 11);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(199, 24);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(215, 11);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(181, 25);
            this.tb_ID.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(402, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(86, 33);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(494, 11);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(147, 24);
            this.lbl_Name.TabIndex = 23;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(647, 11);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(177, 25);
            this.tb_Name.TabIndex = 24;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(10, 59);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(199, 24);
            this.lbl_Total_Amount.TabIndex = 33;
            this.lbl_Total_Amount.Text = "Total Amount";
            this.lbl_Total_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(215, 59);
            this.tb_Total_Amount.MaxLength = 7;
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(181, 25);
            this.tb_Total_Amount.TabIndex = 34;
            // 
            // lbl_Remaining_Amount
            // 
            this.lbl_Remaining_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Remaining_Amount.AutoSize = true;
            this.lbl_Remaining_Amount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining_Amount.Location = new System.Drawing.Point(10, 106);
            this.lbl_Remaining_Amount.Name = "lbl_Remaining_Amount";
            this.lbl_Remaining_Amount.Size = new System.Drawing.Size(199, 24);
            this.lbl_Remaining_Amount.TabIndex = 37;
            this.lbl_Remaining_Amount.Text = "Remaining Amount";
            this.lbl_Remaining_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Remaining_Amount
            // 
            this.tb_Remaining_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Remaining_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Remaining_Amount.Enabled = false;
            this.tb_Remaining_Amount.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remaining_Amount.Location = new System.Drawing.Point(215, 106);
            this.tb_Remaining_Amount.MaxLength = 7;
            this.tb_Remaining_Amount.Name = "tb_Remaining_Amount";
            this.tb_Remaining_Amount.Size = new System.Drawing.Size(181, 25);
            this.tb_Remaining_Amount.TabIndex = 38;
            // 
            // lbl_Order_Placed
            // 
            this.lbl_Order_Placed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Order_Placed.AutoSize = true;
            this.lbl_Order_Placed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Placed.Location = new System.Drawing.Point(494, 106);
            this.lbl_Order_Placed.Name = "lbl_Order_Placed";
            this.lbl_Order_Placed.Size = new System.Drawing.Size(147, 24);
            this.lbl_Order_Placed.TabIndex = 39;
            this.lbl_Order_Placed.Text = "Order Placed";
            this.lbl_Order_Placed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Order_Placed
            // 
            this.gb_Order_Placed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Order_Placed.Controls.Add(this.rb_Yes);
            this.gb_Order_Placed.Controls.Add(this.rb_No);
            this.gb_Order_Placed.Location = new System.Drawing.Point(647, 99);
            this.gb_Order_Placed.Name = "gb_Order_Placed";
            this.gb_Order_Placed.Size = new System.Drawing.Size(177, 39);
            this.gb_Order_Placed.TabIndex = 59;
            this.gb_Order_Placed.TabStop = false;
            // 
            // rb_Yes
            // 
            this.rb_Yes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Yes.AutoSize = true;
            this.rb_Yes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb_Yes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Yes.ForeColor = System.Drawing.Color.Black;
            this.rb_Yes.Location = new System.Drawing.Point(15, 12);
            this.rb_Yes.Name = "rb_Yes";
            this.rb_Yes.Size = new System.Drawing.Size(51, 22);
            this.rb_Yes.TabIndex = 49;
            this.rb_Yes.TabStop = true;
            this.rb_Yes.Text = "Yes";
            this.rb_Yes.UseVisualStyleBackColor = false;
            // 
            // rb_No
            // 
            this.rb_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_No.AutoSize = true;
            this.rb_No.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb_No.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_No.ForeColor = System.Drawing.Color.Black;
            this.rb_No.Location = new System.Drawing.Point(104, 12);
            this.rb_No.Name = "rb_No";
            this.rb_No.Size = new System.Drawing.Size(46, 22);
            this.rb_No.TabIndex = 48;
            this.rb_No.TabStop = true;
            this.rb_No.Text = "No";
            this.rb_No.UseVisualStyleBackColor = false;
            // 
            // lbl_Total_Amount_Paid
            // 
            this.lbl_Total_Amount_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Amount_Paid.AutoSize = true;
            this.lbl_Total_Amount_Paid.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount_Paid.Location = new System.Drawing.Point(494, 59);
            this.lbl_Total_Amount_Paid.Name = "lbl_Total_Amount_Paid";
            this.lbl_Total_Amount_Paid.Size = new System.Drawing.Size(147, 24);
            this.lbl_Total_Amount_Paid.TabIndex = 60;
            this.lbl_Total_Amount_Paid.Text = "Total Paid";
            this.lbl_Total_Amount_Paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Total_Paid
            // 
            this.gb_Total_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Total_Paid.Controls.Add(this.rb_Total_Paid_Yes);
            this.gb_Total_Paid.Controls.Add(this.rb_Total_Paid_No);
            this.gb_Total_Paid.Location = new System.Drawing.Point(647, 50);
            this.gb_Total_Paid.Name = "gb_Total_Paid";
            this.gb_Total_Paid.Size = new System.Drawing.Size(177, 43);
            this.gb_Total_Paid.TabIndex = 61;
            this.gb_Total_Paid.TabStop = false;
            // 
            // rb_Total_Paid_Yes
            // 
            this.rb_Total_Paid_Yes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Total_Paid_Yes.AutoSize = true;
            this.rb_Total_Paid_Yes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb_Total_Paid_Yes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Total_Paid_Yes.ForeColor = System.Drawing.Color.Black;
            this.rb_Total_Paid_Yes.Location = new System.Drawing.Point(15, 14);
            this.rb_Total_Paid_Yes.Name = "rb_Total_Paid_Yes";
            this.rb_Total_Paid_Yes.Size = new System.Drawing.Size(51, 22);
            this.rb_Total_Paid_Yes.TabIndex = 49;
            this.rb_Total_Paid_Yes.TabStop = true;
            this.rb_Total_Paid_Yes.Text = "Yes";
            this.rb_Total_Paid_Yes.UseVisualStyleBackColor = false;
            // 
            // rb_Total_Paid_No
            // 
            this.rb_Total_Paid_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Total_Paid_No.AutoSize = true;
            this.rb_Total_Paid_No.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb_Total_Paid_No.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Total_Paid_No.ForeColor = System.Drawing.Color.Black;
            this.rb_Total_Paid_No.Location = new System.Drawing.Point(104, 14);
            this.rb_Total_Paid_No.Name = "rb_Total_Paid_No";
            this.rb_Total_Paid_No.Size = new System.Drawing.Size(46, 22);
            this.rb_Total_Paid_No.TabIndex = 48;
            this.rb_Total_Paid_No.TabStop = true;
            this.rb_Total_Paid_No.Text = "No";
            this.rb_Total_Paid_No.UseVisualStyleBackColor = false;
            // 
            // gb_View_Order_Details
            // 
            this.gb_View_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_View_Order_Details.Controls.Add(this.dgv_View_Orders);
            this.gb_View_Order_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_View_Order_Details.Location = new System.Drawing.Point(5, 241);
            this.gb_View_Order_Details.Name = "gb_View_Order_Details";
            this.gb_View_Order_Details.Size = new System.Drawing.Size(865, 171);
            this.gb_View_Order_Details.TabIndex = 8;
            this.gb_View_Order_Details.TabStop = false;
            this.gb_View_Order_Details.Text = "View ";
            // 
            // dgv_View_Orders
            // 
            this.dgv_View_Orders.AllowUserToAddRows = false;
            this.dgv_View_Orders.AllowUserToDeleteRows = false;
            this.dgv_View_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_Orders.AutoGenerateColumns = false;
            this.dgv_View_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Orders.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_View_Orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_View_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.purityDataGridViewTextBoxColumn,
            this.netWtDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderPlacedDataGridViewTextBoxColumn});
            this.dgv_View_Orders.DataSource = this.purchasedOrderDetailsBindingSource;
            this.dgv_View_Orders.Location = new System.Drawing.Point(2, 21);
            this.dgv_View_Orders.Name = "dgv_View_Orders";
            this.dgv_View_Orders.ReadOnly = true;
            this.dgv_View_Orders.Size = new System.Drawing.Size(851, 143);
            this.dgv_View_Orders.TabIndex = 0;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Buttons.ColumnCount = 5;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.98608F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.772622F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.59861F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.728539F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45012F));
            this.tlp_Buttons.Controls.Add(this.btn_Update, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Refresh_Grid, 4, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(7, 417);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(862, 41);
            this.tlp_Buttons.TabIndex = 9;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(3, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(219, 34);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh_Grid
            // 
            this.btn_Refresh_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh_Grid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh_Grid.FlatAppearance.BorderSize = 0;
            this.btn_Refresh_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh_Grid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(635, 4);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(224, 33);
            this.btn_Refresh_Grid.TabIndex = 19;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // jewellery_Shop_Management_System_DBDataSet
            // 
            this.jewellery_Shop_Management_System_DBDataSet.DataSetName = "Jewellery_Shop_Management_System_DBDataSet";
            this.jewellery_Shop_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasedOrderDetailsBindingSource
            // 
            this.purchasedOrderDetailsBindingSource.DataMember = "Purchased_Order_Details";
            this.purchasedOrderDetailsBindingSource.DataSource = this.jewellery_Shop_Management_System_DBDataSet;
            // 
            // purchased_Order_DetailsTableAdapter
            // 
            this.purchased_Order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderPlacedDataGridViewTextBoxColumn
            // 
            this.orderPlacedDataGridViewTextBoxColumn.DataPropertyName = "Order_Placed";
            this.orderPlacedDataGridViewTextBoxColumn.HeaderText = "Order_Placed";
            this.orderPlacedDataGridViewTextBoxColumn.Name = "orderPlacedDataGridViewTextBoxColumn";
            this.orderPlacedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Manage_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.gb_View_Order_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Manage_Order";
            this.Text = "Manage Order";
            this.Load += new System.EventHandler(this.Frm_Manage_Order_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Customer_Details.ResumeLayout(false);
            this.tlp_Customer_Details.ResumeLayout(false);
            this.tlp_Customer_Details.PerformLayout();
            this.gb_Order_Placed.ResumeLayout(false);
            this.gb_Order_Placed.PerformLayout();
            this.gb_Total_Paid.ResumeLayout(false);
            this.gb_Total_Paid.PerformLayout();
            this.gb_View_Order_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Orders)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedOrderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Manage_Order;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.GroupBox gb_View_Order_Details;
        private System.Windows.Forms.DataGridView dgv_View_Orders;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh_Grid;
        private System.Windows.Forms.TableLayoutPanel tlp_Customer_Details;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Remaining_Amount;
        private System.Windows.Forms.TextBox tb_Remaining_Amount;
        private System.Windows.Forms.Label lbl_Order_Placed;
        private System.Windows.Forms.GroupBox gb_Order_Placed;
        private System.Windows.Forms.RadioButton rb_Yes;
        private System.Windows.Forms.RadioButton rb_No;
        private System.Windows.Forms.Label lbl_Total_Amount_Paid;
        private System.Windows.Forms.GroupBox gb_Total_Paid;
        private System.Windows.Forms.RadioButton rb_Total_Paid_Yes;
        private System.Windows.Forms.RadioButton rb_Total_Paid_No;
        private Jewellery_Shop_Management_System_DBDataSet jewellery_Shop_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource purchasedOrderDetailsBindingSource;
        private Jewellery_Shop_Management_System_DBDataSetTableAdapters.Purchased_Order_DetailsTableAdapter purchased_Order_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPlacedDataGridViewTextBoxColumn;
    }
}