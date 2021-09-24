namespace Jewellery_Shop_Management_System
{
    partial class Frm_Purchase_Items
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
            this.lbl_Purchase_Items = new System.Windows.Forms.Label();
            this.gb_Customer_Information = new System.Windows.Forms.GroupBox();
            this.tlp_Customer_Information = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Purchase_Details = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.lbl_Purity = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Sub_Category = new System.Windows.Forms.ComboBox();
            this.tb_Purity = new System.Windows.Forms.TextBox();
            this.lbl_Net_Wt = new System.Windows.Forms.Label();
            this.lbl_Stone_Wt = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Net_Wt = new System.Windows.Forms.TextBox();
            this.tb_Stone_Wt = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tlp_Purchase_Items = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Purchase_Items = new System.Windows.Forms.DataGridView();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Customer_Information.SuspendLayout();
            this.tlp_Customer_Information.SuspendLayout();
            this.gb_Purchase_Details.SuspendLayout();
            this.tlp_Purchase_Details.SuspendLayout();
            this.tlp_Purchase_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Items)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Purchase_Items);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 65);
            this.pnl_Header.TabIndex = 1;
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
            // lbl_Purchase_Items
            // 
            this.lbl_Purchase_Items.AutoSize = true;
            this.lbl_Purchase_Items.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Items.Location = new System.Drawing.Point(326, 14);
            this.lbl_Purchase_Items.Name = "lbl_Purchase_Items";
            this.lbl_Purchase_Items.Size = new System.Drawing.Size(219, 32);
            this.lbl_Purchase_Items.TabIndex = 0;
            this.lbl_Purchase_Items.Text = "Purchase Items";
            // 
            // gb_Customer_Information
            // 
            this.gb_Customer_Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Customer_Information.Controls.Add(this.tlp_Customer_Information);
            this.gb_Customer_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Information.Location = new System.Drawing.Point(6, 71);
            this.gb_Customer_Information.Name = "gb_Customer_Information";
            this.gb_Customer_Information.Size = new System.Drawing.Size(862, 117);
            this.gb_Customer_Information.TabIndex = 2;
            this.gb_Customer_Information.TabStop = false;
            this.gb_Customer_Information.Text = "Customer Information";
            // 
            // tlp_Customer_Information
            // 
            this.tlp_Customer_Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Customer_Information.ColumnCount = 8;
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.80645F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.19355F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Customer_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlp_Customer_Information.Controls.Add(this.lbl_ID, 1, 0);
            this.tlp_Customer_Information.Controls.Add(this.tb_ID, 2, 0);
            this.tlp_Customer_Information.Controls.Add(this.lbl_Name, 1, 1);
            this.tlp_Customer_Information.Controls.Add(this.tb_Name, 2, 1);
            this.tlp_Customer_Information.Controls.Add(this.tb_Date, 5, 0);
            this.tlp_Customer_Information.Controls.Add(this.lbl_Date, 4, 0);
            this.tlp_Customer_Information.Controls.Add(this.lbl_Address, 1, 2);
            this.tlp_Customer_Information.Controls.Add(this.tb_Address, 2, 2);
            this.tlp_Customer_Information.Controls.Add(this.lbl_Mobile_Number, 4, 2);
            this.tlp_Customer_Information.Controls.Add(this.tb_Mobile_Number, 5, 2);
            this.tlp_Customer_Information.Location = new System.Drawing.Point(6, 16);
            this.tlp_Customer_Information.Name = "tlp_Customer_Information";
            this.tlp_Customer_Information.RowCount = 3;
            this.tlp_Customer_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Customer_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Customer_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Customer_Information.Size = new System.Drawing.Size(850, 94);
            this.tlp_Customer_Information.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_ID.Location = new System.Drawing.Point(41, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(105, 22);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(152, 3);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(220, 25);
            this.tb_ID.TabIndex = 3;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Name.Location = new System.Drawing.Point(41, 35);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(105, 22);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(152, 34);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(220, 25);
            this.tb_Name.TabIndex = 5;
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.tb_Date.Location = new System.Drawing.Point(571, 3);
            this.tb_Date.MaxLength = 20;
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(196, 25);
            this.tb_Date.TabIndex = 29;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Date.Location = new System.Drawing.Point(422, 4);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(143, 22);
            this.lbl_Date.TabIndex = 28;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Address.Location = new System.Drawing.Point(41, 67);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 22);
            this.lbl_Address.TabIndex = 14;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(152, 65);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(220, 25);
            this.tb_Address.TabIndex = 27;
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(422, 67);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(143, 22);
            this.lbl_Mobile_Number.TabIndex = 11;
            this.lbl_Mobile_Number.Text = "Mobile No";
            this.lbl_Mobile_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(571, 65);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(196, 25);
            this.tb_Mobile_Number.TabIndex = 13;
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Purchase_Details.Controls.Add(this.tlp_Purchase_Details);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.Location = new System.Drawing.Point(6, 188);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(862, 145);
            this.gb_Purchase_Details.TabIndex = 3;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // tlp_Purchase_Details
            // 
            this.tlp_Purchase_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Purchase_Details.ColumnCount = 6;
            this.tlp_Purchase_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.387206F));
            this.tlp_Purchase_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.93603F));
            this.tlp_Purchase_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.93603F));
            this.tlp_Purchase_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.93603F));
            this.tlp_Purchase_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.417508F));
            this.tlp_Purchase_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.387206F));
            this.tlp_Purchase_Details.Controls.Add(this.tb_Quantity, 3, 3);
            this.tlp_Purchase_Details.Controls.Add(this.lbl_Category, 1, 0);
            this.tlp_Purchase_Details.Controls.Add(this.lbl_Sub_Category, 2, 0);
            this.tlp_Purchase_Details.Controls.Add(this.lbl_Purity, 3, 0);
            this.tlp_Purchase_Details.Controls.Add(this.cmb_Category, 1, 1);
            this.tlp_Purchase_Details.Controls.Add(this.cmb_Sub_Category, 2, 1);
            this.tlp_Purchase_Details.Controls.Add(this.tb_Purity, 3, 1);
            this.tlp_Purchase_Details.Controls.Add(this.lbl_Net_Wt, 1, 2);
            this.tlp_Purchase_Details.Controls.Add(this.lbl_Stone_Wt, 2, 2);
            this.tlp_Purchase_Details.Controls.Add(this.lbl_Quantity, 3, 2);
            this.tlp_Purchase_Details.Controls.Add(this.tb_Net_Wt, 1, 3);
            this.tlp_Purchase_Details.Controls.Add(this.tb_Stone_Wt, 2, 3);
            this.tlp_Purchase_Details.Controls.Add(this.btn_Add, 4, 3);
            this.tlp_Purchase_Details.Location = new System.Drawing.Point(3, 21);
            this.tlp_Purchase_Details.Name = "tlp_Purchase_Details";
            this.tlp_Purchase_Details.RowCount = 4;
            this.tlp_Purchase_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Purchase_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Purchase_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Purchase_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Purchase_Details.Size = new System.Drawing.Size(856, 118);
            this.tlp_Purchase_Details.TabIndex = 0;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(509, 90);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(224, 25);
            this.tb_Quantity.TabIndex = 12;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(49, 3);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(224, 22);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Category.Location = new System.Drawing.Point(279, 3);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(224, 22);
            this.lbl_Sub_Category.TabIndex = 3;
            this.lbl_Sub_Category.Text = "Sub-Category";
            this.lbl_Sub_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Purity
            // 
            this.lbl_Purity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Purity.AutoSize = true;
            this.lbl_Purity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purity.Location = new System.Drawing.Point(509, 3);
            this.lbl_Purity.Name = "lbl_Purity";
            this.lbl_Purity.Size = new System.Drawing.Size(224, 22);
            this.lbl_Purity.TabIndex = 5;
            this.lbl_Purity.Text = "Purity(%)";
            this.lbl_Purity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(49, 32);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(224, 27);
            this.cmb_Category.TabIndex = 6;
            // 
            // cmb_Sub_Category
            // 
            this.cmb_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sub_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sub_Category.FormattingEnabled = true;
            this.cmb_Sub_Category.Location = new System.Drawing.Point(279, 32);
            this.cmb_Sub_Category.Name = "cmb_Sub_Category";
            this.cmb_Sub_Category.Size = new System.Drawing.Size(224, 27);
            this.cmb_Sub_Category.TabIndex = 7;
            // 
            // tb_Purity
            // 
            this.tb_Purity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Purity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Purity.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purity.Location = new System.Drawing.Point(509, 32);
            this.tb_Purity.Name = "tb_Purity";
            this.tb_Purity.Size = new System.Drawing.Size(224, 25);
            this.tb_Purity.TabIndex = 8;
            // 
            // lbl_Net_Wt
            // 
            this.lbl_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Net_Wt.AutoSize = true;
            this.lbl_Net_Wt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Wt.Location = new System.Drawing.Point(49, 61);
            this.lbl_Net_Wt.Name = "lbl_Net_Wt";
            this.lbl_Net_Wt.Size = new System.Drawing.Size(224, 22);
            this.lbl_Net_Wt.TabIndex = 9;
            this.lbl_Net_Wt.Text = "Net.Wt.(gm)";
            this.lbl_Net_Wt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Stone_Wt
            // 
            this.lbl_Stone_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stone_Wt.AutoSize = true;
            this.lbl_Stone_Wt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stone_Wt.Location = new System.Drawing.Point(279, 61);
            this.lbl_Stone_Wt.Name = "lbl_Stone_Wt";
            this.lbl_Stone_Wt.Size = new System.Drawing.Size(224, 22);
            this.lbl_Stone_Wt.TabIndex = 10;
            this.lbl_Stone_Wt.Text = "Stone Wt.(gm)";
            this.lbl_Stone_Wt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(509, 61);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(224, 22);
            this.lbl_Quantity.TabIndex = 11;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Net_Wt
            // 
            this.tb_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Net_Wt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Net_Wt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Net_Wt.Location = new System.Drawing.Point(49, 90);
            this.tb_Net_Wt.MaxLength = 5;
            this.tb_Net_Wt.Name = "tb_Net_Wt";
            this.tb_Net_Wt.Size = new System.Drawing.Size(224, 25);
            this.tb_Net_Wt.TabIndex = 12;
            // 
            // tb_Stone_Wt
            // 
            this.tb_Stone_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Stone_Wt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Stone_Wt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stone_Wt.Location = new System.Drawing.Point(279, 90);
            this.tb_Stone_Wt.MaxLength = 5;
            this.tb_Stone_Wt.Name = "tb_Stone_Wt";
            this.tb_Stone_Wt.Size = new System.Drawing.Size(224, 25);
            this.tb_Stone_Wt.TabIndex = 13;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(739, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 25);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // tlp_Purchase_Items
            // 
            this.tlp_Purchase_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Purchase_Items.ColumnCount = 1;
            this.tlp_Purchase_Items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.11601F));
            this.tlp_Purchase_Items.Controls.Add(this.dgv_Purchase_Items, 0, 0);
            this.tlp_Purchase_Items.Location = new System.Drawing.Point(6, 339);
            this.tlp_Purchase_Items.Name = "tlp_Purchase_Items";
            this.tlp_Purchase_Items.RowCount = 1;
            this.tlp_Purchase_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.32787F));
            this.tlp_Purchase_Items.Size = new System.Drawing.Size(862, 69);
            this.tlp_Purchase_Items.TabIndex = 4;
            // 
            // dgv_Purchase_Items
            // 
            this.dgv_Purchase_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Purchase_Items.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Purchase_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Purchase_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Items.Location = new System.Drawing.Point(3, 3);
            this.dgv_Purchase_Items.Name = "dgv_Purchase_Items";
            this.dgv_Purchase_Items.Size = new System.Drawing.Size(856, 63);
            this.dgv_Purchase_Items.TabIndex = 0;
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
            this.tlp_Buttons.Location = new System.Drawing.Point(117, 414);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Size = new System.Drawing.Size(606, 39);
            this.tlp_Buttons.TabIndex = 5;
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
            this.btn_Refresh.Size = new System.Drawing.Size(140, 33);
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
            this.btn_Next.Size = new System.Drawing.Size(149, 33);
            this.btn_Next.TabIndex = 14;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click_1);
            // 
            // Frm_Purchase_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.tlp_Purchase_Items);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.gb_Customer_Information);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Purchase_Items";
            this.Text = "Purchase Items";
            this.TopMost = true;
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Customer_Information.ResumeLayout(false);
            this.tlp_Customer_Information.ResumeLayout(false);
            this.tlp_Customer_Information.PerformLayout();
            this.gb_Purchase_Details.ResumeLayout(false);
            this.tlp_Purchase_Details.ResumeLayout(false);
            this.tlp_Purchase_Details.PerformLayout();
            this.tlp_Purchase_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Items)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Purchase_Items;
        private System.Windows.Forms.GroupBox gb_Customer_Information;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Purchase_Items;
        private System.Windows.Forms.DataGridView dgv_Purchase_Items;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TableLayoutPanel tlp_Customer_Information;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.TableLayoutPanel tlp_Purchase_Details;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Sub_Category;
        private System.Windows.Forms.Label lbl_Purity;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Sub_Category;
        private System.Windows.Forms.TextBox tb_Purity;
        private System.Windows.Forms.Label lbl_Net_Wt;
        private System.Windows.Forms.Label lbl_Stone_Wt;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Net_Wt;
        private System.Windows.Forms.TextBox tb_Stone_Wt;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Button btn_Add;


    }
}