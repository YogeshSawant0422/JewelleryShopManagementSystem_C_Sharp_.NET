namespace Jewellery_Shop_Management_System
{
    partial class Frm_Add_Stock
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_Add_Stock = new System.Windows.Forms.Label();
            this.pnl_Add_Stock = new System.Windows.Forms.Panel();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Product_Info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.cmb_Sub_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.gb_Add_Stock = new System.Windows.Forms.GroupBox();
            this.tlp_Add_Stock = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Current_Stock = new System.Windows.Forms.Label();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.lbl_Add_Quantity = new System.Windows.Forms.Label();
            this.tb_Add_Quantity = new System.Windows.Forms.TextBox();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Add_Stock.SuspendLayout();
            this.gb_Product_Details.SuspendLayout();
            this.tlp_Product_Info.SuspendLayout();
            this.gb_Add_Stock.SuspendLayout();
            this.tlp_Add_Stock.SuspendLayout();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Add_Stock);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 57);
            this.pnl_Header.TabIndex = 4;
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
            // lbl_Add_Stock
            // 
            this.lbl_Add_Stock.AutoSize = true;
            this.lbl_Add_Stock.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Stock.Location = new System.Drawing.Point(367, 14);
            this.lbl_Add_Stock.Name = "lbl_Add_Stock";
            this.lbl_Add_Stock.Size = new System.Drawing.Size(150, 32);
            this.lbl_Add_Stock.TabIndex = 0;
            this.lbl_Add_Stock.Text = "Add Stock";
            // 
            // pnl_Add_Stock
            // 
            this.pnl_Add_Stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Add_Stock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Add_Stock.Controls.Add(this.tlp_Buttons);
            this.pnl_Add_Stock.Controls.Add(this.gb_Add_Stock);
            this.pnl_Add_Stock.Controls.Add(this.gb_Product_Details);
            this.pnl_Add_Stock.Location = new System.Drawing.Point(96, 63);
            this.pnl_Add_Stock.Name = "pnl_Add_Stock";
            this.pnl_Add_Stock.Size = new System.Drawing.Size(676, 386);
            this.pnl_Add_Stock.TabIndex = 5;
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product_Details.Controls.Add(this.tlp_Product_Info);
            this.gb_Product_Details.Location = new System.Drawing.Point(28, 19);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(626, 188);
            this.gb_Product_Details.TabIndex = 0;
            this.gb_Product_Details.TabStop = false;
            // 
            // tlp_Product_Info
            // 
            this.tlp_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Product_Info.ColumnCount = 6;
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.34375F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.4375F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21875F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.4375F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21875F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.34375F));
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_ID, 1, 0);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_ID, 2, 0);
            this.tlp_Product_Info.Controls.Add(this.btn_Search, 3, 0);
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_Name, 1, 1);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_Name, 2, 1);
            this.tlp_Product_Info.Controls.Add(this.lbl_Category, 1, 2);
            this.tlp_Product_Info.Controls.Add(this.cmb_Category, 2, 2);
            this.tlp_Product_Info.Controls.Add(this.lbl_Sub_Category, 1, 3);
            this.tlp_Product_Info.Controls.Add(this.cmb_Sub_Category, 2, 3);
            this.tlp_Product_Info.Controls.Add(this.lbl_Date, 3, 1);
            this.tlp_Product_Info.Controls.Add(this.dtp_Date, 4, 1);
            this.tlp_Product_Info.Location = new System.Drawing.Point(35, 19);
            this.tlp_Product_Info.Name = "tlp_Product_Info";
            this.tlp_Product_Info.RowCount = 4;
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.Size = new System.Drawing.Size(557, 155);
            this.tlp_Product_Info.TabIndex = 0;
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(16, 7);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(124, 24);
            this.lbl_Product_ID.TabIndex = 5;
            this.lbl_Product_ID.Text = "Product ID ";
            this.lbl_Product_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(146, 6);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(128, 25);
            this.tb_Product_ID.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(280, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 31);
            this.btn_Search.TabIndex = 33;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(16, 45);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(124, 24);
            this.lbl_Product_Name.TabIndex = 34;
            this.lbl_Product_Name.Text = "Prod. Name ";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(146, 44);
            this.tb_Product_Name.MaxLength = 20;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(128, 25);
            this.tb_Product_Name.TabIndex = 2;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(16, 83);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(124, 24);
            this.lbl_Category.TabIndex = 36;
            this.lbl_Category.Text = "Category  ";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(146, 81);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(128, 27);
            this.cmb_Category.TabIndex = 3;
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Category.Location = new System.Drawing.Point(16, 125);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(124, 19);
            this.lbl_Sub_Category.TabIndex = 38;
            this.lbl_Sub_Category.Text = "Sub Category  ";
            this.lbl_Sub_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Sub_Category
            // 
            this.cmb_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sub_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sub_Category.FormattingEnabled = true;
            this.cmb_Sub_Category.Location = new System.Drawing.Point(146, 121);
            this.cmb_Sub_Category.Name = "cmb_Sub_Category";
            this.cmb_Sub_Category.Size = new System.Drawing.Size(128, 27);
            this.cmb_Sub_Category.TabIndex = 4;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(280, 45);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(124, 24);
            this.lbl_Date.TabIndex = 40;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(410, 41);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(128, 32);
            this.dtp_Date.TabIndex = 5;
            // 
            // gb_Add_Stock
            // 
            this.gb_Add_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Add_Stock.Controls.Add(this.tlp_Add_Stock);
            this.gb_Add_Stock.Location = new System.Drawing.Point(28, 213);
            this.gb_Add_Stock.Name = "gb_Add_Stock";
            this.gb_Add_Stock.Size = new System.Drawing.Size(626, 122);
            this.gb_Add_Stock.TabIndex = 1;
            this.gb_Add_Stock.TabStop = false;
            // 
            // tlp_Add_Stock
            // 
            this.tlp_Add_Stock.ColumnCount = 7;
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.267003F));
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.92192F));
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.67758F));
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.267003F));
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.92192F));
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.67758F));
            this.tlp_Add_Stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.267003F));
            this.tlp_Add_Stock.Controls.Add(this.lbl_Current_Stock, 1, 1);
            this.tlp_Add_Stock.Controls.Add(this.tb_Current_Stock, 2, 1);
            this.tlp_Add_Stock.Controls.Add(this.lbl_Add_Quantity, 4, 1);
            this.tlp_Add_Stock.Controls.Add(this.tb_Add_Quantity, 5, 1);
            this.tlp_Add_Stock.Location = new System.Drawing.Point(6, 16);
            this.tlp_Add_Stock.Name = "tlp_Add_Stock";
            this.tlp_Add_Stock.RowCount = 3;
            this.tlp_Add_Stock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.06779F));
            this.tlp_Add_Stock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.93221F));
            this.tlp_Add_Stock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlp_Add_Stock.Size = new System.Drawing.Size(614, 90);
            this.tlp_Add_Stock.TabIndex = 0;
            // 
            // lbl_Current_Stock
            // 
            this.lbl_Current_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Current_Stock.AutoSize = true;
            this.lbl_Current_Stock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock.Location = new System.Drawing.Point(16, 35);
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            this.lbl_Current_Stock.Size = new System.Drawing.Size(134, 22);
            this.lbl_Current_Stock.TabIndex = 6;
            this.lbl_Current_Stock.Text = "Current Stock";
            this.lbl_Current_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Current_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Current_Stock.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(156, 33);
            this.tb_Current_Stock.MaxLength = 5;
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(139, 25);
            this.tb_Current_Stock.TabIndex = 6;
            // 
            // lbl_Add_Quantity
            // 
            this.lbl_Add_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Add_Quantity.AutoSize = true;
            this.lbl_Add_Quantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Quantity.Location = new System.Drawing.Point(314, 34);
            this.lbl_Add_Quantity.Name = "lbl_Add_Quantity";
            this.lbl_Add_Quantity.Size = new System.Drawing.Size(134, 24);
            this.lbl_Add_Quantity.TabIndex = 12;
            this.lbl_Add_Quantity.Text = "Add Quantity";
            this.lbl_Add_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Add_Quantity
            // 
            this.tb_Add_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Add_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Add_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Quantity.Location = new System.Drawing.Point(454, 33);
            this.tb_Add_Quantity.MaxLength = 5;
            this.tb_Add_Quantity.Name = "tb_Add_Quantity";
            this.tb_Add_Quantity.Size = new System.Drawing.Size(139, 25);
            this.tb_Add_Quantity.TabIndex = 7;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tlp_Buttons.ColumnCount = 3;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.34483F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.31034F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.34483F));
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Save, 2, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(118, 340);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(425, 42);
            this.tlp_Buttons.TabIndex = 9;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(3, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(122, 33);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(298, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 33);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // Frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Add_Stock);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Add_Stock";
            this.Text = "Add Stock";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Add_Stock.ResumeLayout(false);
            this.gb_Product_Details.ResumeLayout(false);
            this.tlp_Product_Info.ResumeLayout(false);
            this.tlp_Product_Info.PerformLayout();
            this.gb_Add_Stock.ResumeLayout(false);
            this.tlp_Add_Stock.ResumeLayout(false);
            this.tlp_Add_Stock.PerformLayout();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Add_Stock;
        private System.Windows.Forms.Panel pnl_Add_Stock;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Product_Info;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Sub_Category;
        private System.Windows.Forms.ComboBox cmb_Sub_Category;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox gb_Add_Stock;
        private System.Windows.Forms.TableLayoutPanel tlp_Add_Stock;
        private System.Windows.Forms.Label lbl_Current_Stock;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.Label lbl_Add_Quantity;
        private System.Windows.Forms.TextBox tb_Add_Quantity;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
    }
}