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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_Manage_Customer = new System.Windows.Forms.Label();
            this.gb_Customer_Info = new System.Windows.Forms.GroupBox();
            this.tlp_Customer_Info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.tlp_Dgv = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_View_Customer_Details = new System.Windows.Forms.DataGridView();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Customer_Info.SuspendLayout();
            this.tlp_Customer_Info.SuspendLayout();
            this.tlp_Dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Customer_Details)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
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
            this.gb_Customer_Info.Location = new System.Drawing.Point(10, 62);
            this.gb_Customer_Info.Name = "gb_Customer_Info";
            this.gb_Customer_Info.Size = new System.Drawing.Size(872, 139);
            this.gb_Customer_Info.TabIndex = 4;
            this.gb_Customer_Info.TabStop = false;
            this.gb_Customer_Info.Text = "Customer Info";
            // 
            // tlp_Customer_Info
            // 
            this.tlp_Customer_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Customer_Info.ColumnCount = 6;
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tlp_Customer_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Customer_Info.Controls.Add(this.lbl_PAN_No, 0, 2);
            this.tlp_Customer_Info.Controls.Add(this.lbl_ID, 0, 0);
            this.tlp_Customer_Info.Controls.Add(this.tb_ID, 1, 0);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Name, 2, 0);
            this.tlp_Customer_Info.Controls.Add(this.tb_Name, 3, 0);
            this.tlp_Customer_Info.Controls.Add(this.btn_Search, 4, 0);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Mobile_Number, 0, 1);
            this.tlp_Customer_Info.Controls.Add(this.tb_Mobile_Number, 1, 1);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Address, 2, 1);
            this.tlp_Customer_Info.Controls.Add(this.tb_Address, 3, 1);
            this.tlp_Customer_Info.Controls.Add(this.lbl_Date, 4, 1);
            this.tlp_Customer_Info.Controls.Add(this.tb_Date, 5, 1);
            this.tlp_Customer_Info.Controls.Add(this.tb_PAN_No, 1, 2);
            this.tlp_Customer_Info.Location = new System.Drawing.Point(5, 16);
            this.tlp_Customer_Info.Name = "tlp_Customer_Info";
            this.tlp_Customer_Info.RowCount = 3;
            this.tlp_Customer_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Customer_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Customer_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlp_Customer_Info.Size = new System.Drawing.Size(862, 117);
            this.tlp_Customer_Info.TabIndex = 0;
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_PAN_No.Location = new System.Drawing.Point(3, 83);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(108, 29);
            this.lbl_PAN_No.TabIndex = 28;
            this.lbl_PAN_No.Text = "PAN No.";
            this.lbl_PAN_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(3, 5);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(108, 29);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(117, 7);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(166, 25);
            this.tb_ID.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Name.Location = new System.Drawing.Point(289, 5);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(108, 29);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(403, 7);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(166, 25);
            this.tb_Name.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(575, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 33);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(3, 44);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(108, 29);
            this.lbl_Mobile_Number.TabIndex = 22;
            this.lbl_Mobile_Number.Text = "Mo.No.";
            this.lbl_Mobile_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(117, 46);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(166, 25);
            this.tb_Mobile_Number.TabIndex = 23;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Address.Location = new System.Drawing.Point(289, 44);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(108, 29);
            this.lbl_Address.TabIndex = 24;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(403, 46);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(166, 25);
            this.tb_Address.TabIndex = 25;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Date.Location = new System.Drawing.Point(575, 44);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(108, 29);
            this.lbl_Date.TabIndex = 26;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.tb_Date.Location = new System.Drawing.Point(689, 46);
            this.tb_Date.MaxLength = 20;
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(170, 25);
            this.tb_Date.TabIndex = 27;
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PAN_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PAN_No.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(117, 85);
            this.tb_PAN_No.MaxLength = 12;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(166, 25);
            this.tb_PAN_No.TabIndex = 29;
            // 
            // tlp_Dgv
            // 
            this.tlp_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Dgv.ColumnCount = 1;
            this.tlp_Dgv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Dgv.Controls.Add(this.dgv_View_Customer_Details, 0, 0);
            this.tlp_Dgv.Location = new System.Drawing.Point(15, 207);
            this.tlp_Dgv.Name = "tlp_Dgv";
            this.tlp_Dgv.RowCount = 1;
            this.tlp_Dgv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Dgv.Size = new System.Drawing.Size(862, 235);
            this.tlp_Dgv.TabIndex = 0;
            // 
            // dgv_View_Customer_Details
            // 
            this.dgv_View_Customer_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_Customer_Details.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_View_Customer_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_View_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Customer_Details.Location = new System.Drawing.Point(3, 3);
            this.dgv_View_Customer_Details.Name = "dgv_View_Customer_Details";
            this.dgv_View_Customer_Details.Size = new System.Drawing.Size(856, 229);
            this.dgv_View_Customer_Details.TabIndex = 0;
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
            this.tlp_Buttons.Controls.Add(this.btn_Update, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 2, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Delete, 4, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(15, 448);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(862, 41);
            this.tlp_Buttons.TabIndex = 5;
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
            this.btn_Update.Size = new System.Drawing.Size(231, 34);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
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
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(621, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(238, 33);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Frm_Manage_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.tlp_Dgv);
            this.Controls.Add(this.gb_Customer_Info);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Manage_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Customer";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Customer_Info.ResumeLayout(false);
            this.tlp_Customer_Info.ResumeLayout(false);
            this.tlp_Customer_Info.PerformLayout();
            this.tlp_Dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Customer_Details)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Manage_Customer;
        private System.Windows.Forms.GroupBox gb_Customer_Info;
        private System.Windows.Forms.TableLayoutPanel tlp_Customer_Info;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.TableLayoutPanel tlp_Dgv;
        private System.Windows.Forms.DataGridView dgv_View_Customer_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Delete;

    }
}