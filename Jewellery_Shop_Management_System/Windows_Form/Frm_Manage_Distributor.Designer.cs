namespace Jewellery_Shop_Management_System
{
    partial class Frm_Manage_Distributor
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
            this.lbl_Manage_Distributor = new System.Windows.Forms.Label();
            this.gb_Distributor_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Distibutor_ID = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Shop_Name = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Shop_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Distributor_ID = new System.Windows.Forms.TextBox();
            this.tb_Dist_Name = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.gb_Stock_Added_By_Distributor = new System.Windows.Forms.GroupBox();
            this.tlp_Product_Info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.btn_Search_Product = new System.Windows.Forms.Button();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.tb_Sub_Category = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Net_Wt = new System.Windows.Forms.Label();
            this.lbl_Current_Stock = new System.Windows.Forms.Label();
            this.lbl_Add_Stock = new System.Windows.Forms.Label();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.cmb_Net_Wt = new System.Windows.Forms.ComboBox();
            this.tb_Add_Stock = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Distributor_Details.SuspendLayout();
            this.tlp_Distibutor_ID.SuspendLayout();
            this.gb_Stock_Added_By_Distributor.SuspendLayout();
            this.tlp_Product_Info.SuspendLayout();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Manage_Distributor);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 49);
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
            this.btn_X.Location = new System.Drawing.Point(811, 4);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(54, 39);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // lbl_Manage_Distributor
            // 
            this.lbl_Manage_Distributor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Manage_Distributor.AutoSize = true;
            this.lbl_Manage_Distributor.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manage_Distributor.Location = new System.Drawing.Point(334, 9);
            this.lbl_Manage_Distributor.Name = "lbl_Manage_Distributor";
            this.lbl_Manage_Distributor.Size = new System.Drawing.Size(273, 32);
            this.lbl_Manage_Distributor.TabIndex = 0;
            this.lbl_Manage_Distributor.Text = "Manage Distributor ";
            // 
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Distributor_Details.Controls.Add(this.tlp_Distibutor_ID);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Distributor_Details.Location = new System.Drawing.Point(2, 57);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(865, 114);
            this.gb_Distributor_Details.TabIndex = 5;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "Distributor Details";
            // 
            // tlp_Distibutor_ID
            // 
            this.tlp_Distibutor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Distibutor_ID.ColumnCount = 7;
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.298643F));
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.70136F));
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.7F));
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tlp_Distibutor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.3F));
            this.tlp_Distibutor_ID.Controls.Add(this.dtp_Date, 5, 0);
            this.tlp_Distibutor_ID.Controls.Add(this.tb_Shop_Name, 5, 1);
            this.tlp_Distibutor_ID.Controls.Add(this.lbl_Date, 4, 0);
            this.tlp_Distibutor_ID.Controls.Add(this.lbl_Shop_Name, 4, 1);
            this.tlp_Distibutor_ID.Controls.Add(this.btn_Search, 3, 0);
            this.tlp_Distibutor_ID.Controls.Add(this.tb_Distributor_ID, 2, 0);
            this.tlp_Distibutor_ID.Controls.Add(this.tb_Dist_Name, 2, 1);
            this.tlp_Distibutor_ID.Controls.Add(this.lbl_Distributor_ID, 1, 0);
            this.tlp_Distibutor_ID.Controls.Add(this.lbl_Name, 1, 1);
            this.tlp_Distibutor_ID.Location = new System.Drawing.Point(6, 19);
            this.tlp_Distibutor_ID.Name = "tlp_Distibutor_ID";
            this.tlp_Distibutor_ID.RowCount = 2;
            this.tlp_Distibutor_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Distibutor_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlp_Distibutor_ID.Size = new System.Drawing.Size(853, 85);
            this.tlp_Distibutor_ID.TabIndex = 1;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(646, 7);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(191, 28);
            this.dtp_Date.TabIndex = 59;
            // 
            // tb_Shop_Name
            // 
            this.tb_Shop_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Shop_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Shop_Name.Enabled = false;
            this.tb_Shop_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.tb_Shop_Name.Location = new System.Drawing.Point(646, 51);
            this.tb_Shop_Name.MaxLength = 20;
            this.tb_Shop_Name.Name = "tb_Shop_Name";
            this.tb_Shop_Name.Size = new System.Drawing.Size(191, 25);
            this.tb_Shop_Name.TabIndex = 40;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Date.Location = new System.Drawing.Point(474, 10);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(166, 22);
            this.lbl_Date.TabIndex = 35;
            this.lbl_Date.Text = "Stock Added Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Shop_Name
            // 
            this.lbl_Shop_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Shop_Name.AutoSize = true;
            this.lbl_Shop_Name.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Shop_Name.Location = new System.Drawing.Point(474, 53);
            this.lbl_Shop_Name.Name = "lbl_Shop_Name";
            this.lbl_Shop_Name.Size = new System.Drawing.Size(166, 22);
            this.lbl_Shop_Name.TabIndex = 39;
            this.lbl_Shop_Name.Text = "Shop Name";
            this.lbl_Shop_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(358, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 33);
            this.btn_Search.TabIndex = 37;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Distributor_ID
            // 
            this.tb_Distributor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Distributor_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Distributor_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_ID.Location = new System.Drawing.Point(130, 9);
            this.tb_Distributor_ID.MaxLength = 5;
            this.tb_Distributor_ID.Name = "tb_Distributor_ID";
            this.tb_Distributor_ID.Size = new System.Drawing.Size(222, 25);
            this.tb_Distributor_ID.TabIndex = 6;
            this.tb_Distributor_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Distributor_ID_KeyPress);
            // 
            // tb_Dist_Name
            // 
            this.tb_Dist_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Dist_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Dist_Name.Enabled = false;
            this.tb_Dist_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dist_Name.Location = new System.Drawing.Point(130, 51);
            this.tb_Dist_Name.MaxLength = 20;
            this.tb_Dist_Name.Name = "tb_Dist_Name";
            this.tb_Dist_Name.Size = new System.Drawing.Size(222, 25);
            this.tb_Dist_Name.TabIndex = 58;
            // 
            // lbl_Distributor_ID
            // 
            this.lbl_Distributor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Distributor_ID.AutoSize = true;
            this.lbl_Distributor_ID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Distributor_ID.Location = new System.Drawing.Point(14, 10);
            this.lbl_Distributor_ID.Name = "lbl_Distributor_ID";
            this.lbl_Distributor_ID.Size = new System.Drawing.Size(110, 22);
            this.lbl_Distributor_ID.TabIndex = 5;
            this.lbl_Distributor_ID.Text = "Dist.ID ";
            this.lbl_Distributor_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Name.Location = new System.Drawing.Point(14, 53);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(110, 22);
            this.lbl_Name.TabIndex = 41;
            this.lbl_Name.Text = "Dist.Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Stock_Added_By_Distributor
            // 
            this.gb_Stock_Added_By_Distributor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Stock_Added_By_Distributor.Controls.Add(this.tlp_Product_Info);
            this.gb_Stock_Added_By_Distributor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock_Added_By_Distributor.Location = new System.Drawing.Point(8, 178);
            this.gb_Stock_Added_By_Distributor.Name = "gb_Stock_Added_By_Distributor";
            this.gb_Stock_Added_By_Distributor.Size = new System.Drawing.Size(859, 218);
            this.gb_Stock_Added_By_Distributor.TabIndex = 15;
            this.gb_Stock_Added_By_Distributor.TabStop = false;
            this.gb_Stock_Added_By_Distributor.Text = "Stock Added By Distributor";
            // 
            // tlp_Product_Info
            // 
            this.tlp_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Product_Info.ColumnCount = 5;
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.23952F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.92848F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62452F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.2682F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_ID, 0, 0);
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_Name, 0, 1);
            this.tlp_Product_Info.Controls.Add(this.lbl_Category, 0, 2);
            this.tlp_Product_Info.Controls.Add(this.lbl_Sub_Category, 0, 3);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_ID, 1, 0);
            this.tlp_Product_Info.Controls.Add(this.btn_Search_Product, 2, 0);
            this.tlp_Product_Info.Controls.Add(this.tb_Category, 1, 2);
            this.tlp_Product_Info.Controls.Add(this.tb_Sub_Category, 1, 3);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_Name, 1, 1);
            this.tlp_Product_Info.Controls.Add(this.lbl_Net_Wt, 2, 1);
            this.tlp_Product_Info.Controls.Add(this.lbl_Current_Stock, 2, 2);
            this.tlp_Product_Info.Controls.Add(this.lbl_Add_Stock, 2, 3);
            this.tlp_Product_Info.Controls.Add(this.tb_Current_Stock, 3, 2);
            this.tlp_Product_Info.Controls.Add(this.cmb_Net_Wt, 3, 1);
            this.tlp_Product_Info.Controls.Add(this.tb_Add_Stock, 3, 3);
            this.tlp_Product_Info.Controls.Add(this.lbl_Unit, 4, 1);
            this.tlp_Product_Info.Location = new System.Drawing.Point(10, 24);
            this.tlp_Product_Info.Name = "tlp_Product_Info";
            this.tlp_Product_Info.RowCount = 4;
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Product_Info.Size = new System.Drawing.Size(835, 188);
            this.tlp_Product_Info.TabIndex = 1;
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(21, 11);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(115, 24);
            this.lbl_Product_ID.TabIndex = 5;
            this.lbl_Product_ID.Text = "Product ID ";
            this.lbl_Product_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(16, 58);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(126, 24);
            this.lbl_Product_Name.TabIndex = 34;
            this.lbl_Product_Name.Text = "Prod. Name ";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(25, 105);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(108, 24);
            this.lbl_Category.TabIndex = 36;
            this.lbl_Category.Text = "Category  ";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Category.Location = new System.Drawing.Point(4, 152);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(150, 24);
            this.lbl_Sub_Category.TabIndex = 38;
            this.lbl_Sub_Category.Text = "Sub Category  ";
            this.lbl_Sub_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(161, 11);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(243, 25);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_ID_KeyPress);
            this.tb_Product_ID.Leave += new System.EventHandler(this.tb_Product_ID_Leave);
            // 
            // btn_Search_Product
            // 
            this.btn_Search_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search_Product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search_Product.FlatAppearance.BorderSize = 0;
            this.btn_Search_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_Product.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Product.Location = new System.Drawing.Point(410, 8);
            this.btn_Search_Product.Name = "btn_Search_Product";
            this.btn_Search_Product.Size = new System.Drawing.Size(131, 31);
            this.btn_Search_Product.TabIndex = 2;
            this.btn_Search_Product.Text = "Search";
            this.btn_Search_Product.UseVisualStyleBackColor = false;
            this.btn_Search_Product.Click += new System.EventHandler(this.btn_Search_Product_Click);
            // 
            // tb_Category
            // 
            this.tb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Category.Enabled = false;
            this.tb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(161, 105);
            this.tb_Category.MaxLength = 20;
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(243, 25);
            this.tb_Category.TabIndex = 4;
            // 
            // tb_Sub_Category
            // 
            this.tb_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Sub_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Sub_Category.Enabled = false;
            this.tb_Sub_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sub_Category.Location = new System.Drawing.Point(161, 152);
            this.tb_Sub_Category.MaxLength = 20;
            this.tb_Sub_Category.Name = "tb_Sub_Category";
            this.tb_Sub_Category.Size = new System.Drawing.Size(243, 25);
            this.tb_Sub_Category.TabIndex = 5;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_Name.Enabled = false;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(161, 58);
            this.tb_Product_Name.MaxLength = 20;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(243, 25);
            this.tb_Product_Name.TabIndex = 3;
            // 
            // lbl_Net_Wt
            // 
            this.lbl_Net_Wt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Net_Wt.AutoSize = true;
            this.lbl_Net_Wt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Wt.Location = new System.Drawing.Point(441, 59);
            this.lbl_Net_Wt.Name = "lbl_Net_Wt";
            this.lbl_Net_Wt.Size = new System.Drawing.Size(68, 22);
            this.lbl_Net_Wt.TabIndex = 39;
            this.lbl_Net_Wt.Text = "Net Wt";
            this.lbl_Net_Wt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Current_Stock
            // 
            this.lbl_Current_Stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Current_Stock.AutoSize = true;
            this.lbl_Current_Stock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock.Location = new System.Drawing.Point(413, 106);
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            this.lbl_Current_Stock.Size = new System.Drawing.Size(125, 22);
            this.lbl_Current_Stock.TabIndex = 41;
            this.lbl_Current_Stock.Text = "Current Stock";
            this.lbl_Current_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Add_Stock
            // 
            this.lbl_Add_Stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_Stock.AutoSize = true;
            this.lbl_Add_Stock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Stock.Location = new System.Drawing.Point(423, 152);
            this.lbl_Add_Stock.Name = "lbl_Add_Stock";
            this.lbl_Add_Stock.Size = new System.Drawing.Size(104, 24);
            this.lbl_Add_Stock.TabIndex = 42;
            this.lbl_Add_Stock.Text = "Add Stock";
            this.lbl_Add_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Current_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Current_Stock.Enabled = false;
            this.tb_Current_Stock.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(547, 105);
            this.tb_Current_Stock.MaxLength = 5;
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(230, 25);
            this.tb_Current_Stock.TabIndex = 43;
            // 
            // cmb_Net_Wt
            // 
            this.cmb_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Net_Wt.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Net_Wt.FormattingEnabled = true;
            this.cmb_Net_Wt.Location = new System.Drawing.Point(547, 57);
            this.cmb_Net_Wt.Name = "cmb_Net_Wt";
            this.cmb_Net_Wt.Size = new System.Drawing.Size(230, 27);
            this.cmb_Net_Wt.TabIndex = 40;
            this.cmb_Net_Wt.SelectedIndexChanged += new System.EventHandler(this.cmb_Net_Wt_SelectedIndexChanged);
            // 
            // tb_Add_Stock
            // 
            this.tb_Add_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Add_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Add_Stock.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add_Stock.Location = new System.Drawing.Point(547, 152);
            this.tb_Add_Stock.MaxLength = 5;
            this.tb_Add_Stock.Name = "tb_Add_Stock";
            this.tb_Add_Stock.Size = new System.Drawing.Size(230, 25);
            this.tb_Add_Stock.TabIndex = 44;
            this.tb_Add_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Add_Quantity_KeyPress);
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(783, 61);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(35, 18);
            this.lbl_Unit.TabIndex = 45;
            this.lbl_Unit.Text = "Unit";
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
            this.tlp_Buttons.Location = new System.Drawing.Point(195, 407);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(490, 42);
            this.tlp_Buttons.TabIndex = 17;
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
            this.btn_Refresh.Size = new System.Drawing.Size(142, 33);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(343, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(144, 33);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_Manage_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.gb_Stock_Added_By_Distributor);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Manage_Distributor";
            this.Text = "Manage Distributor";
            this.Load += new System.EventHandler(this.Frm_Manage_Distributor_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Distributor_Details.ResumeLayout(false);
            this.tlp_Distibutor_ID.ResumeLayout(false);
            this.tlp_Distibutor_ID.PerformLayout();
            this.gb_Stock_Added_By_Distributor.ResumeLayout(false);
            this.tlp_Product_Info.ResumeLayout(false);
            this.tlp_Product_Info.PerformLayout();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Manage_Distributor;
        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Distibutor_ID;
        private System.Windows.Forms.TextBox tb_Dist_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Distributor_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Distributor_ID;
        private System.Windows.Forms.Label lbl_Shop_Name;
        private System.Windows.Forms.TextBox tb_Shop_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox gb_Stock_Added_By_Distributor;
        private System.Windows.Forms.TableLayoutPanel tlp_Product_Info;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Sub_Category;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Button btn_Search_Product;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.TextBox tb_Sub_Category;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Net_Wt;
        private System.Windows.Forms.ComboBox cmb_Net_Wt;
        private System.Windows.Forms.Label lbl_Current_Stock;
        private System.Windows.Forms.Label lbl_Add_Stock;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.TextBox tb_Add_Stock;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
    }
}