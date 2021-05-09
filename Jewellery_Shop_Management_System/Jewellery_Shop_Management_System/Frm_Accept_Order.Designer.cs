namespace Jewellery_Shop_Management_System
{
    partial class Frm_Accept_Order
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
            this.lbl_Accept_Order = new System.Windows.Forms.Label();
            this.tlp_Order_ID = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_ID = new System.Windows.Forms.Label();
            this.rb_New_Customer = new System.Windows.Forms.RadioButton();
            this.rb_Old_Customer = new System.Windows.Forms.RadioButton();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Customer_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Order_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.cmb_Sub_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tlp_Dgv = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Accept_Order = new System.Windows.Forms.DataGridView();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.tlp_Order_ID.SuspendLayout();
            this.gb_Customer_Details.SuspendLayout();
            this.tlp_Customer_Details.SuspendLayout();
            this.gb_Order_Details.SuspendLayout();
            this.tlp_Order_Details.SuspendLayout();
            this.tlp_Dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accept_Order)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Accept_Order);
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
            // lbl_Accept_Order
            // 
            this.lbl_Accept_Order.AutoSize = true;
            this.lbl_Accept_Order.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Accept_Order.Location = new System.Drawing.Point(326, 14);
            this.lbl_Accept_Order.Name = "lbl_Accept_Order";
            this.lbl_Accept_Order.Size = new System.Drawing.Size(188, 32);
            this.lbl_Accept_Order.TabIndex = 0;
            this.lbl_Accept_Order.Text = "Accept Order";
            // 
            // tlp_Order_ID
            // 
            this.tlp_Order_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Order_ID.ColumnCount = 7;
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_Order_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlp_Order_ID.Controls.Add(this.lbl_Order_ID, 1, 0);
            this.tlp_Order_ID.Controls.Add(this.rb_New_Customer, 3, 0);
            this.tlp_Order_ID.Controls.Add(this.rb_Old_Customer, 5, 0);
            this.tlp_Order_ID.Location = new System.Drawing.Point(3, 59);
            this.tlp_Order_ID.Name = "tlp_Order_ID";
            this.tlp_Order_ID.RowCount = 1;
            this.tlp_Order_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Order_ID.Size = new System.Drawing.Size(868, 34);
            this.tlp_Order_ID.TabIndex = 5;
            // 
            // lbl_Order_ID
            // 
            this.lbl_Order_ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Order_ID.AutoSize = true;
            this.lbl_Order_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_ID.Location = new System.Drawing.Point(48, 8);
            this.lbl_Order_ID.Name = "lbl_Order_ID";
            this.lbl_Order_ID.Size = new System.Drawing.Size(108, 18);
            this.lbl_Order_ID.TabIndex = 0;
            this.lbl_Order_ID.Text = "Order ID : 1001";
            // 
            // rb_New_Customer
            // 
            this.rb_New_Customer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_New_Customer.AutoSize = true;
            this.rb_New_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_New_Customer.Location = new System.Drawing.Point(321, 6);
            this.rb_New_Customer.Name = "rb_New_Customer";
            this.rb_New_Customer.Size = new System.Drawing.Size(132, 22);
            this.rb_New_Customer.TabIndex = 1;
            this.rb_New_Customer.TabStop = true;
            this.rb_New_Customer.Text = "NEW Customer\r\n";
            this.rb_New_Customer.UseVisualStyleBackColor = true;
            // 
            // rb_Old_Customer
            // 
            this.rb_Old_Customer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_Old_Customer.AutoSize = true;
            this.rb_Old_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Old_Customer.Location = new System.Drawing.Point(594, 6);
            this.rb_Old_Customer.Name = "rb_Old_Customer";
            this.rb_Old_Customer.Size = new System.Drawing.Size(127, 22);
            this.rb_Old_Customer.TabIndex = 2;
            this.rb_Old_Customer.TabStop = true;
            this.rb_Old_Customer.Text = "OLD Customer\r\n";
            this.rb_Old_Customer.UseVisualStyleBackColor = true;
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Customer_Details.Controls.Add(this.tlp_Customer_Details);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.Location = new System.Drawing.Point(3, 98);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(865, 112);
            this.gb_Customer_Details.TabIndex = 6;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // tlp_Customer_Details
            // 
            this.tlp_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Customer_Details.ColumnCount = 9;
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.014425F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97672F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02065F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97672F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97672F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0218F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97672F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0218F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.014425F));
            this.tlp_Customer_Details.Controls.Add(this.lbl_ID, 1, 0);
            this.tlp_Customer_Details.Controls.Add(this.tb_ID, 2, 0);
            this.tlp_Customer_Details.Controls.Add(this.btn_Search, 3, 0);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Name, 1, 1);
            this.tlp_Customer_Details.Controls.Add(this.tb_Name, 2, 1);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Address, 4, 1);
            this.tlp_Customer_Details.Controls.Add(this.tb_Address, 5, 1);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Mobile_Number, 6, 1);
            this.tlp_Customer_Details.Controls.Add(this.tb_Mobile_Number, 7, 1);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Date, 6, 0);
            this.tlp_Customer_Details.Controls.Add(this.dtp_Date, 7, 0);
            this.tlp_Customer_Details.Location = new System.Drawing.Point(6, 16);
            this.tlp_Customer_Details.Name = "tlp_Customer_Details";
            this.tlp_Customer_Details.RowCount = 2;
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Customer_Details.Size = new System.Drawing.Size(853, 90);
            this.tlp_Customer_Details.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(11, 10);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(87, 24);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(104, 10);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(147, 25);
            this.tb_ID.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(257, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 33);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(11, 55);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(87, 24);
            this.lbl_Name.TabIndex = 23;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(104, 55);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(147, 25);
            this.tb_Name.TabIndex = 24;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(350, 55);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(87, 24);
            this.lbl_Address.TabIndex = 25;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(443, 55);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(147, 25);
            this.tb_Address.TabIndex = 26;
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(596, 55);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(87, 24);
            this.lbl_Mobile_Number.TabIndex = 27;
            this.lbl_Mobile_Number.Text = "Mo.No.";
            this.lbl_Mobile_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(689, 55);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(147, 25);
            this.tb_Mobile_Number.TabIndex = 28;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(596, 10);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(87, 24);
            this.lbl_Date.TabIndex = 29;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(689, 6);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(147, 32);
            this.dtp_Date.TabIndex = 30;
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Order_Details.Controls.Add(this.tlp_Order_Details);
            this.gb_Order_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Details.Location = new System.Drawing.Point(3, 212);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(868, 148);
            this.gb_Order_Details.TabIndex = 7;
            this.gb_Order_Details.TabStop = false;
            this.gb_Order_Details.Text = "Order Details";
            // 
            // tlp_Order_Details
            // 
            this.tlp_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Order_Details.ColumnCount = 7;
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.440476F));
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.40476F));
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.952381F));
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.40476F));
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.952381F));
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.40476F));
            this.tlp_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.440476F));
            this.tlp_Order_Details.Controls.Add(this.lbl_Category, 1, 0);
            this.tlp_Order_Details.Controls.Add(this.cmb_Category, 1, 1);
            this.tlp_Order_Details.Controls.Add(this.lbl_Sub_Category, 3, 0);
            this.tlp_Order_Details.Controls.Add(this.cmb_Sub_Category, 3, 1);
            this.tlp_Order_Details.Controls.Add(this.lbl_Product, 5, 0);
            this.tlp_Order_Details.Controls.Add(this.cmb_Product, 5, 1);
            this.tlp_Order_Details.Controls.Add(this.lbl_Quantity, 1, 2);
            this.tlp_Order_Details.Controls.Add(this.tb_Quantity, 1, 3);
            this.tlp_Order_Details.Controls.Add(this.lbl_Price, 3, 2);
            this.tlp_Order_Details.Controls.Add(this.tb_Price, 3, 3);
            this.tlp_Order_Details.Controls.Add(this.btn_Add, 5, 3);
            this.tlp_Order_Details.Location = new System.Drawing.Point(6, 21);
            this.tlp_Order_Details.Name = "tlp_Order_Details";
            this.tlp_Order_Details.RowCount = 4;
            this.tlp_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Order_Details.Size = new System.Drawing.Size(853, 121);
            this.tlp_Order_Details.TabIndex = 0;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(66, 3);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(202, 24);
            this.lbl_Category.TabIndex = 7;
            this.lbl_Category.Text = "Category  ";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(66, 33);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(202, 24);
            this.cmb_Category.TabIndex = 22;
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Category.Location = new System.Drawing.Point(324, 3);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(202, 24);
            this.lbl_Sub_Category.TabIndex = 23;
            this.lbl_Sub_Category.Text = "Sub Category  ";
            this.lbl_Sub_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Sub_Category
            // 
            this.cmb_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sub_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sub_Category.FormattingEnabled = true;
            this.cmb_Sub_Category.Location = new System.Drawing.Point(324, 33);
            this.cmb_Sub_Category.Name = "cmb_Sub_Category";
            this.cmb_Sub_Category.Size = new System.Drawing.Size(202, 24);
            this.cmb_Sub_Category.TabIndex = 24;
            // 
            // lbl_Product
            // 
            this.lbl_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(582, 3);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(202, 24);
            this.lbl_Product.TabIndex = 25;
            this.lbl_Product.Text = "Product  ";
            this.lbl_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Product
            // 
            this.cmb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Product.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(582, 33);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(202, 24);
            this.cmb_Product.TabIndex = 26;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(66, 63);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(202, 24);
            this.lbl_Quantity.TabIndex = 27;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(66, 93);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(202, 25);
            this.tb_Quantity.TabIndex = 28;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(324, 63);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(202, 24);
            this.lbl_Price.TabIndex = 29;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Price
            // 
            this.tb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(324, 93);
            this.tb_Price.MaxLength = 7;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(202, 25);
            this.tb_Price.TabIndex = 30;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(646, 93);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(138, 25);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // tlp_Dgv
            // 
            this.tlp_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Dgv.ColumnCount = 1;
            this.tlp_Dgv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Dgv.Controls.Add(this.dgv_Accept_Order, 0, 0);
            this.tlp_Dgv.Location = new System.Drawing.Point(9, 366);
            this.tlp_Dgv.Name = "tlp_Dgv";
            this.tlp_Dgv.RowCount = 1;
            this.tlp_Dgv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Dgv.Size = new System.Drawing.Size(853, 54);
            this.tlp_Dgv.TabIndex = 8;
            // 
            // dgv_Accept_Order
            // 
            this.dgv_Accept_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Accept_Order.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Accept_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Accept_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accept_Order.Location = new System.Drawing.Point(3, 3);
            this.dgv_Accept_Order.Name = "dgv_Accept_Order";
            this.dgv_Accept_Order.Size = new System.Drawing.Size(847, 48);
            this.dgv_Accept_Order.TabIndex = 0;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tlp_Buttons.ColumnCount = 3;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.47863F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.52137F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Next, 2, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(146, 422);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Size = new System.Drawing.Size(606, 35);
            this.tlp_Buttons.TabIndex = 9;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(3, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 29);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(454, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(149, 29);
            this.btn_Next.TabIndex = 14;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // Frm_Accept_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.tlp_Dgv);
            this.Controls.Add(this.gb_Order_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Controls.Add(this.tlp_Order_ID);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Accept_Order";
            this.Text = "Accept Order";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.tlp_Order_ID.ResumeLayout(false);
            this.tlp_Order_ID.PerformLayout();
            this.gb_Customer_Details.ResumeLayout(false);
            this.tlp_Customer_Details.ResumeLayout(false);
            this.tlp_Customer_Details.PerformLayout();
            this.gb_Order_Details.ResumeLayout(false);
            this.tlp_Order_Details.ResumeLayout(false);
            this.tlp_Order_Details.PerformLayout();
            this.tlp_Dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accept_Order)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Accept_Order;
        private System.Windows.Forms.TableLayoutPanel tlp_Order_ID;
        private System.Windows.Forms.Label lbl_Order_ID;
        private System.Windows.Forms.RadioButton rb_New_Customer;
        private System.Windows.Forms.RadioButton rb_Old_Customer;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Customer_Details;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Order_Details;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Sub_Category;
        private System.Windows.Forms.ComboBox cmb_Sub_Category;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TableLayoutPanel tlp_Dgv;
        private System.Windows.Forms.DataGridView dgv_Accept_Order;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Next;
    }
}