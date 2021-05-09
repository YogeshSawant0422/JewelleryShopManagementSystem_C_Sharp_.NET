namespace Jewellery_Shop_Management_System
{
    partial class Frm_Product_Details
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
            this.lbl_Product_Details = new System.Windows.Forms.Label();
            this.gb_Product_Info = new System.Windows.Forms.GroupBox();
            this.tlp_Image = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.tlp_Product_Info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Sub_Category = new System.Windows.Forms.ComboBox();
            this.tb_Stone_Wt = new System.Windows.Forms.TextBox();
            this.gb_Weight = new System.Windows.Forms.GroupBox();
            this.tlp_Weight = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Stone_Color = new System.Windows.Forms.Label();
            this.lbl_Stone_Name = new System.Windows.Forms.Label();
            this.lbl_Net_Wt = new System.Windows.Forms.Label();
            this.lbl_Purity = new System.Windows.Forms.Label();
            this.tb_Purity = new System.Windows.Forms.TextBox();
            this.lbl_Stone_Wt = new System.Windows.Forms.Label();
            this.tb_Stone_Name = new System.Windows.Forms.TextBox();
            this.tb_Net_Wt = new System.Windows.Forms.TextBox();
            this.tb_Stone_Color = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.gb_Product_Price_Info = new System.Windows.Forms.GroupBox();
            this.tlp_Product_Price_Info = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.tb_Other_Expenses = new System.Windows.Forms.TextBox();
            this.tb_Stone_Rate = new System.Windows.Forms.TextBox();
            this.tb_Per_Gm_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Per_Gm_Rate = new System.Windows.Forms.Label();
            this.lbl_Stone_Rate = new System.Windows.Forms.Label();
            this.lbl_Other_Expenses = new System.Windows.Forms.Label();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.tlp_Dgv = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Product_Info.SuspendLayout();
            this.tlp_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.tlp_Product_Info.SuspendLayout();
            this.gb_Weight.SuspendLayout();
            this.tlp_Weight.SuspendLayout();
            this.gb_Product_Price_Info.SuspendLayout();
            this.tlp_Product_Price_Info.SuspendLayout();
            this.tlp_Dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Product_Details);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 57);
            this.pnl_Header.TabIndex = 2;
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
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click_1);
            // 
            // lbl_Product_Details
            // 
            this.lbl_Product_Details.AutoSize = true;
            this.lbl_Product_Details.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Details.Location = new System.Drawing.Point(326, 14);
            this.lbl_Product_Details.Name = "lbl_Product_Details";
            this.lbl_Product_Details.Size = new System.Drawing.Size(217, 32);
            this.lbl_Product_Details.TabIndex = 0;
            this.lbl_Product_Details.Text = "Product Details";
            // 
            // gb_Product_Info
            // 
            this.gb_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product_Info.Controls.Add(this.tlp_Image);
            this.gb_Product_Info.Controls.Add(this.tlp_Product_Info);
            this.gb_Product_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Info.Location = new System.Drawing.Point(7, 60);
            this.gb_Product_Info.Name = "gb_Product_Info";
            this.gb_Product_Info.Size = new System.Drawing.Size(861, 185);
            this.gb_Product_Info.TabIndex = 3;
            this.gb_Product_Info.TabStop = false;
            this.gb_Product_Info.Text = "Product Info";
            // 
            // tlp_Image
            // 
            this.tlp_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Image.ColumnCount = 2;
            this.tlp_Image.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.75799F));
            this.tlp_Image.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlp_Image.Controls.Add(this.btn_Browse, 1, 1);
            this.tlp_Image.Controls.Add(this.pb_Image, 0, 0);
            this.tlp_Image.Controls.Add(this.btn_Upload, 0, 1);
            this.tlp_Image.Location = new System.Drawing.Point(602, 21);
            this.tlp_Image.Name = "tlp_Image";
            this.tlp_Image.RowCount = 2;
            this.tlp_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.37975F));
            this.tlp_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_Image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Image.Size = new System.Drawing.Size(253, 158);
            this.tlp_Image.TabIndex = 1;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(164, 125);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(86, 30);
            this.btn_Browse.TabIndex = 21;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            // 
            // pb_Image
            // 
            this.pb_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(3, 3);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(155, 116);
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Upload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Upload.FlatAppearance.BorderSize = 0;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(3, 125);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(155, 30);
            this.btn_Upload.TabIndex = 22;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            // 
            // tlp_Product_Info
            // 
            this.tlp_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Product_Info.ColumnCount = 3;
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.94836F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.05164F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_ID, 0, 0);
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_Name, 0, 1);
            this.tlp_Product_Info.Controls.Add(this.lbl_Category, 0, 2);
            this.tlp_Product_Info.Controls.Add(this.lbl_Sub_Category, 0, 3);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_ID, 1, 0);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_Name, 1, 1);
            this.tlp_Product_Info.Controls.Add(this.btn_Search, 2, 0);
            this.tlp_Product_Info.Controls.Add(this.cmb_Category, 1, 2);
            this.tlp_Product_Info.Controls.Add(this.cmb_Sub_Category, 1, 3);
            this.tlp_Product_Info.Location = new System.Drawing.Point(6, 21);
            this.tlp_Product_Info.Name = "tlp_Product_Info";
            this.tlp_Product_Info.RowCount = 4;
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_Product_Info.Size = new System.Drawing.Size(590, 158);
            this.tlp_Product_Info.TabIndex = 0;
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(3, 6);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(194, 29);
            this.lbl_Product_ID.TabIndex = 3;
            this.lbl_Product_ID.Text = "Product ID ";
            this.lbl_Product_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Product_Name.Location = new System.Drawing.Point(3, 46);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(194, 29);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name ";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Category.Location = new System.Drawing.Point(3, 86);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(194, 29);
            this.lbl_Category.TabIndex = 6;
            this.lbl_Category.Text = "Category  ";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Sub_Category.Location = new System.Drawing.Point(3, 125);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(194, 29);
            this.lbl_Sub_Category.TabIndex = 7;
            this.lbl_Sub_Category.Text = "Sub Category  ";
            this.lbl_Sub_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(203, 8);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(220, 25);
            this.tb_Product_ID.TabIndex = 8;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(203, 48);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(220, 25);
            this.tb_Product_Name.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(429, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(158, 34);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(203, 87);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(220, 27);
            this.cmb_Category.TabIndex = 21;
            // 
            // cmb_Sub_Category
            // 
            this.cmb_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sub_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sub_Category.FormattingEnabled = true;
            this.cmb_Sub_Category.Location = new System.Drawing.Point(203, 124);
            this.cmb_Sub_Category.Name = "cmb_Sub_Category";
            this.cmb_Sub_Category.Size = new System.Drawing.Size(220, 27);
            this.cmb_Sub_Category.TabIndex = 22;
            // 
            // tb_Stone_Wt
            // 
            this.tb_Stone_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Stone_Wt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Stone_Wt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stone_Wt.Location = new System.Drawing.Point(285, 42);
            this.tb_Stone_Wt.MaxLength = 5;
            this.tb_Stone_Wt.Name = "tb_Stone_Wt";
            this.tb_Stone_Wt.Size = new System.Drawing.Size(135, 25);
            this.tb_Stone_Wt.TabIndex = 12;
            // 
            // gb_Weight
            // 
            this.gb_Weight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Weight.Controls.Add(this.tlp_Weight);
            this.gb_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Weight.Location = new System.Drawing.Point(7, 246);
            this.gb_Weight.Name = "gb_Weight";
            this.gb_Weight.Size = new System.Drawing.Size(861, 100);
            this.gb_Weight.TabIndex = 4;
            this.gb_Weight.TabStop = false;
            this.gb_Weight.Text = "Weight";
            // 
            // tlp_Weight
            // 
            this.tlp_Weight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Weight.ColumnCount = 6;
            this.tlp_Weight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66564F));
            this.tlp_Weight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66687F));
            this.tlp_Weight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66687F));
            this.tlp_Weight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66687F));
            this.tlp_Weight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66687F));
            this.tlp_Weight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66687F));
            this.tlp_Weight.Controls.Add(this.lbl_Quantity, 5, 0);
            this.tlp_Weight.Controls.Add(this.lbl_Stone_Color, 4, 0);
            this.tlp_Weight.Controls.Add(this.lbl_Stone_Name, 3, 0);
            this.tlp_Weight.Controls.Add(this.lbl_Net_Wt, 0, 0);
            this.tlp_Weight.Controls.Add(this.lbl_Purity, 1, 0);
            this.tlp_Weight.Controls.Add(this.tb_Stone_Wt, 2, 1);
            this.tlp_Weight.Controls.Add(this.tb_Purity, 1, 1);
            this.tlp_Weight.Controls.Add(this.lbl_Stone_Wt, 2, 0);
            this.tlp_Weight.Controls.Add(this.tb_Stone_Name, 3, 1);
            this.tlp_Weight.Controls.Add(this.tb_Net_Wt, 0, 1);
            this.tlp_Weight.Controls.Add(this.tb_Stone_Color, 4, 1);
            this.tlp_Weight.Controls.Add(this.tb_Quantity, 5, 1);
            this.tlp_Weight.Location = new System.Drawing.Point(6, 21);
            this.tlp_Weight.Name = "tlp_Weight";
            this.tlp_Weight.RowCount = 2;
            this.tlp_Weight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Weight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Weight.Size = new System.Drawing.Size(849, 73);
            this.tlp_Weight.TabIndex = 0;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(708, 7);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(138, 22);
            this.lbl_Quantity.TabIndex = 18;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Stone_Color
            // 
            this.lbl_Stone_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stone_Color.AutoSize = true;
            this.lbl_Stone_Color.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stone_Color.Location = new System.Drawing.Point(567, 7);
            this.lbl_Stone_Color.Name = "lbl_Stone_Color";
            this.lbl_Stone_Color.Size = new System.Drawing.Size(135, 22);
            this.lbl_Stone_Color.TabIndex = 15;
            this.lbl_Stone_Color.Text = "Stone Color";
            this.lbl_Stone_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Stone_Name
            // 
            this.lbl_Stone_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stone_Name.AutoSize = true;
            this.lbl_Stone_Name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stone_Name.Location = new System.Drawing.Point(426, 7);
            this.lbl_Stone_Name.Name = "lbl_Stone_Name";
            this.lbl_Stone_Name.Size = new System.Drawing.Size(135, 22);
            this.lbl_Stone_Name.TabIndex = 13;
            this.lbl_Stone_Name.Text = "Stone Name";
            this.lbl_Stone_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Net_Wt
            // 
            this.lbl_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Net_Wt.AutoSize = true;
            this.lbl_Net_Wt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Wt.Location = new System.Drawing.Point(3, 7);
            this.lbl_Net_Wt.Name = "lbl_Net_Wt";
            this.lbl_Net_Wt.Size = new System.Drawing.Size(135, 22);
            this.lbl_Net_Wt.TabIndex = 7;
            this.lbl_Net_Wt.Text = "Net.Wt.(gm)";
            this.lbl_Net_Wt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Purity
            // 
            this.lbl_Purity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Purity.AutoSize = true;
            this.lbl_Purity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purity.Location = new System.Drawing.Point(144, 7);
            this.lbl_Purity.Name = "lbl_Purity";
            this.lbl_Purity.Size = new System.Drawing.Size(135, 22);
            this.lbl_Purity.TabIndex = 9;
            this.lbl_Purity.Text = "Purity(%)";
            this.lbl_Purity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Purity
            // 
            this.tb_Purity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Purity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Purity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purity.Location = new System.Drawing.Point(144, 42);
            this.tb_Purity.Name = "tb_Purity";
            this.tb_Purity.Size = new System.Drawing.Size(135, 25);
            this.tb_Purity.TabIndex = 10;
            // 
            // lbl_Stone_Wt
            // 
            this.lbl_Stone_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stone_Wt.AutoSize = true;
            this.lbl_Stone_Wt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stone_Wt.Location = new System.Drawing.Point(285, 7);
            this.lbl_Stone_Wt.Name = "lbl_Stone_Wt";
            this.lbl_Stone_Wt.Size = new System.Drawing.Size(135, 22);
            this.lbl_Stone_Wt.TabIndex = 11;
            this.lbl_Stone_Wt.Text = "StoneWt.gm";
            this.lbl_Stone_Wt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Stone_Name
            // 
            this.tb_Stone_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Stone_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Stone_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stone_Name.Location = new System.Drawing.Point(426, 42);
            this.tb_Stone_Name.Name = "tb_Stone_Name";
            this.tb_Stone_Name.Size = new System.Drawing.Size(135, 25);
            this.tb_Stone_Name.TabIndex = 14;
            // 
            // tb_Net_Wt
            // 
            this.tb_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Net_Wt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Net_Wt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Net_Wt.Location = new System.Drawing.Point(3, 42);
            this.tb_Net_Wt.MaxLength = 5;
            this.tb_Net_Wt.Name = "tb_Net_Wt";
            this.tb_Net_Wt.Size = new System.Drawing.Size(135, 25);
            this.tb_Net_Wt.TabIndex = 8;
            // 
            // tb_Stone_Color
            // 
            this.tb_Stone_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Stone_Color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Stone_Color.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stone_Color.Location = new System.Drawing.Point(567, 42);
            this.tb_Stone_Color.Name = "tb_Stone_Color";
            this.tb_Stone_Color.Size = new System.Drawing.Size(135, 25);
            this.tb_Stone_Color.TabIndex = 16;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(708, 42);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(138, 25);
            this.tb_Quantity.TabIndex = 19;
            // 
            // gb_Product_Price_Info
            // 
            this.gb_Product_Price_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product_Price_Info.Controls.Add(this.tlp_Product_Price_Info);
            this.gb_Product_Price_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Price_Info.Location = new System.Drawing.Point(7, 348);
            this.gb_Product_Price_Info.Name = "gb_Product_Price_Info";
            this.gb_Product_Price_Info.Size = new System.Drawing.Size(861, 87);
            this.gb_Product_Price_Info.TabIndex = 5;
            this.gb_Product_Price_Info.TabStop = false;
            this.gb_Product_Price_Info.Text = "Product Price Info";
            // 
            // tlp_Product_Price_Info
            // 
            this.tlp_Product_Price_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Product_Price_Info.ColumnCount = 5;
            this.tlp_Product_Price_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Product_Price_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Product_Price_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Product_Price_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Product_Price_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Product_Price_Info.Controls.Add(this.tb_Total_Price, 4, 1);
            this.tlp_Product_Price_Info.Controls.Add(this.tb_GST, 3, 1);
            this.tlp_Product_Price_Info.Controls.Add(this.tb_Other_Expenses, 2, 1);
            this.tlp_Product_Price_Info.Controls.Add(this.tb_Stone_Rate, 1, 1);
            this.tlp_Product_Price_Info.Controls.Add(this.tb_Per_Gm_Rate, 0, 1);
            this.tlp_Product_Price_Info.Controls.Add(this.lbl_Per_Gm_Rate, 0, 0);
            this.tlp_Product_Price_Info.Controls.Add(this.lbl_Stone_Rate, 1, 0);
            this.tlp_Product_Price_Info.Controls.Add(this.lbl_Other_Expenses, 2, 0);
            this.tlp_Product_Price_Info.Controls.Add(this.lbl_GST, 3, 0);
            this.tlp_Product_Price_Info.Controls.Add(this.lbl_Total_Price, 4, 0);
            this.tlp_Product_Price_Info.Location = new System.Drawing.Point(6, 20);
            this.tlp_Product_Price_Info.Name = "tlp_Product_Price_Info";
            this.tlp_Product_Price_Info.RowCount = 2;
            this.tlp_Product_Price_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Product_Price_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Product_Price_Info.Size = new System.Drawing.Size(849, 61);
            this.tlp_Product_Price_Info.TabIndex = 0;
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Total_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(679, 33);
            this.tb_Total_Price.MaxLength = 7;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(167, 25);
            this.tb_Total_Price.TabIndex = 23;
            // 
            // tb_GST
            // 
            this.tb_GST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_GST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GST.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(510, 33);
            this.tb_GST.MaxLength = 2;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(163, 25);
            this.tb_GST.TabIndex = 22;
            // 
            // tb_Other_Expenses
            // 
            this.tb_Other_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Other_Expenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Other_Expenses.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Other_Expenses.Location = new System.Drawing.Point(341, 33);
            this.tb_Other_Expenses.MaxLength = 7;
            this.tb_Other_Expenses.Name = "tb_Other_Expenses";
            this.tb_Other_Expenses.Size = new System.Drawing.Size(163, 25);
            this.tb_Other_Expenses.TabIndex = 21;
            // 
            // tb_Stone_Rate
            // 
            this.tb_Stone_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Stone_Rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Stone_Rate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stone_Rate.Location = new System.Drawing.Point(172, 33);
            this.tb_Stone_Rate.MaxLength = 7;
            this.tb_Stone_Rate.Name = "tb_Stone_Rate";
            this.tb_Stone_Rate.Size = new System.Drawing.Size(163, 25);
            this.tb_Stone_Rate.TabIndex = 20;
            // 
            // tb_Per_Gm_Rate
            // 
            this.tb_Per_Gm_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Per_Gm_Rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Per_Gm_Rate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Per_Gm_Rate.Location = new System.Drawing.Point(3, 33);
            this.tb_Per_Gm_Rate.MaxLength = 7;
            this.tb_Per_Gm_Rate.Name = "tb_Per_Gm_Rate";
            this.tb_Per_Gm_Rate.Size = new System.Drawing.Size(163, 25);
            this.tb_Per_Gm_Rate.TabIndex = 19;
            // 
            // lbl_Per_Gm_Rate
            // 
            this.lbl_Per_Gm_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Per_Gm_Rate.AutoSize = true;
            this.lbl_Per_Gm_Rate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per_Gm_Rate.Location = new System.Drawing.Point(3, 4);
            this.lbl_Per_Gm_Rate.Name = "lbl_Per_Gm_Rate";
            this.lbl_Per_Gm_Rate.Size = new System.Drawing.Size(163, 22);
            this.lbl_Per_Gm_Rate.TabIndex = 14;
            this.lbl_Per_Gm_Rate.Text = "Per gm rate";
            this.lbl_Per_Gm_Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Stone_Rate
            // 
            this.lbl_Stone_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stone_Rate.AutoSize = true;
            this.lbl_Stone_Rate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stone_Rate.Location = new System.Drawing.Point(172, 4);
            this.lbl_Stone_Rate.Name = "lbl_Stone_Rate";
            this.lbl_Stone_Rate.Size = new System.Drawing.Size(163, 22);
            this.lbl_Stone_Rate.TabIndex = 15;
            this.lbl_Stone_Rate.Text = "Stone Rate";
            this.lbl_Stone_Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Other_Expenses
            // 
            this.lbl_Other_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Other_Expenses.AutoSize = true;
            this.lbl_Other_Expenses.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Other_Expenses.Location = new System.Drawing.Point(341, 4);
            this.lbl_Other_Expenses.Name = "lbl_Other_Expenses";
            this.lbl_Other_Expenses.Size = new System.Drawing.Size(163, 22);
            this.lbl_Other_Expenses.TabIndex = 16;
            this.lbl_Other_Expenses.Text = "Other Expenses";
            this.lbl_Other_Expenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GST
            // 
            this.lbl_GST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(510, 4);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(163, 22);
            this.lbl_GST.TabIndex = 17;
            this.lbl_GST.Text = "GST(%)";
            this.lbl_GST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(679, 4);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(167, 22);
            this.lbl_Total_Price.TabIndex = 18;
            this.lbl_Total_Price.Text = "Total Price";
            this.lbl_Total_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Dgv
            // 
            this.tlp_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Dgv.ColumnCount = 1;
            this.tlp_Dgv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.09299F));
            this.tlp_Dgv.Controls.Add(this.dgv_Product, 0, 0);
            this.tlp_Dgv.Location = new System.Drawing.Point(7, 436);
            this.tlp_Dgv.Name = "tlp_Dgv";
            this.tlp_Dgv.RowCount = 1;
            this.tlp_Dgv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Dgv.Size = new System.Drawing.Size(861, 54);
            this.tlp_Dgv.TabIndex = 6;
            // 
            // dgv_Product
            // 
            this.dgv_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Product.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(3, 3);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.Size = new System.Drawing.Size(855, 48);
            this.dgv_Product.TabIndex = 0;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tlp_Buttons.ColumnCount = 5;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tlp_Buttons.Controls.Add(this.btn_Add, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 4, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Update, 2, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(4, 491);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Size = new System.Drawing.Size(865, 33);
            this.tlp_Buttons.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 26);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(687, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(175, 27);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(333, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(200, 27);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // Frm_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 525);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.tlp_Dgv);
            this.Controls.Add(this.gb_Product_Price_Info);
            this.Controls.Add(this.gb_Weight);
            this.Controls.Add(this.gb_Product_Info);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
           // this.Load += new System.EventHandler(this.Frm_Product_Details_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Product_Info.ResumeLayout(false);
            this.tlp_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.tlp_Product_Info.ResumeLayout(false);
            this.tlp_Product_Info.PerformLayout();
            this.gb_Weight.ResumeLayout(false);
            this.tlp_Weight.ResumeLayout(false);
            this.tlp_Weight.PerformLayout();
            this.gb_Product_Price_Info.ResumeLayout(false);
            this.tlp_Product_Price_Info.ResumeLayout(false);
            this.tlp_Product_Price_Info.PerformLayout();
            this.tlp_Dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Product_Details;
        private System.Windows.Forms.GroupBox gb_Product_Info;
        private System.Windows.Forms.TableLayoutPanel tlp_Product_Info;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Sub_Category;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tlp_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.GroupBox gb_Weight;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Sub_Category;
        private System.Windows.Forms.TableLayoutPanel tlp_Weight;
        private System.Windows.Forms.Label lbl_Net_Wt;
        private System.Windows.Forms.TextBox tb_Net_Wt;
        private System.Windows.Forms.Label lbl_Purity;
        private System.Windows.Forms.TextBox tb_Purity;
        private System.Windows.Forms.Label lbl_Stone_Wt;
        private System.Windows.Forms.TextBox tb_Stone_Wt;
        private System.Windows.Forms.Label lbl_Stone_Color;
        private System.Windows.Forms.Label lbl_Stone_Name;
        private System.Windows.Forms.TextBox tb_Stone_Name;
        private System.Windows.Forms.TextBox tb_Stone_Color;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.GroupBox gb_Product_Price_Info;
        private System.Windows.Forms.TableLayoutPanel tlp_Product_Price_Info;
        private System.Windows.Forms.Label lbl_Per_Gm_Rate;
        private System.Windows.Forms.Label lbl_Stone_Rate;
        private System.Windows.Forms.Label lbl_Other_Expenses;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.TextBox tb_Other_Expenses;
        private System.Windows.Forms.TextBox tb_Stone_Rate;
        private System.Windows.Forms.TextBox tb_Per_Gm_Rate;
        private System.Windows.Forms.TableLayoutPanel tlp_Dgv;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;

    }
}