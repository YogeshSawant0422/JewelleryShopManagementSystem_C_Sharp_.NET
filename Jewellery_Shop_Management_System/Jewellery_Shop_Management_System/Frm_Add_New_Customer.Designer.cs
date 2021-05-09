namespace Jewellery_Shop_Management_System
{
    partial class Frm_Add_New_Customer
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
            this.lbl_Add_Customer = new System.Windows.Forms.Label();
            this.pnl_Add_Customer = new System.Windows.Forms.Panel();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Customer_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Add_Customer.SuspendLayout();
            this.gb_Customer_Details.SuspendLayout();
            this.tlp_Customer_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Add_Customer);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 77);
            this.pnl_Header.TabIndex = 0;
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
            // lbl_Add_Customer
            // 
            this.lbl_Add_Customer.AutoSize = true;
            this.lbl_Add_Customer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Customer.Location = new System.Drawing.Point(340, 23);
            this.lbl_Add_Customer.Name = "lbl_Add_Customer";
            this.lbl_Add_Customer.Size = new System.Drawing.Size(206, 32);
            this.lbl_Add_Customer.TabIndex = 0;
            this.lbl_Add_Customer.Text = "Add Customer";
            // 
            // pnl_Add_Customer
            // 
            this.pnl_Add_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Add_Customer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Add_Customer.Controls.Add(this.gb_Customer_Details);
            this.pnl_Add_Customer.Location = new System.Drawing.Point(105, 83);
            this.pnl_Add_Customer.Name = "pnl_Add_Customer";
            this.pnl_Add_Customer.Size = new System.Drawing.Size(681, 374);
            this.pnl_Add_Customer.TabIndex = 1;
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Customer_Details.Controls.Add(this.tlp_Customer_Details);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.Location = new System.Drawing.Point(9, 7);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(663, 360);
            this.gb_Customer_Details.TabIndex = 1;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // tlp_Customer_Details
            // 
            this.tlp_Customer_Details.ColumnCount = 6;
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.976918F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.51154F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.51154F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tlp_Customer_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Customer_Details.Controls.Add(this.lbl_ID, 1, 0);
            this.tlp_Customer_Details.Controls.Add(this.tb_ID, 2, 0);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Name, 1, 1);
            this.tlp_Customer_Details.Controls.Add(this.tb_Name, 2, 1);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Mobile_Number, 1, 2);
            this.tlp_Customer_Details.Controls.Add(this.tb_Mobile_Number, 2, 2);
            this.tlp_Customer_Details.Controls.Add(this.tb_Address, 2, 3);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Date, 3, 0);
            this.tlp_Customer_Details.Controls.Add(this.dtp_Date, 4, 0);
            this.tlp_Customer_Details.Controls.Add(this.lbl_Address, 1, 3);
            this.tlp_Customer_Details.Controls.Add(this.lbl_PAN_No, 3, 1);
            this.tlp_Customer_Details.Controls.Add(this.tb_PAN_No, 4, 1);
            this.tlp_Customer_Details.Controls.Add(this.btn_Refresh, 2, 4);
            this.tlp_Customer_Details.Controls.Add(this.btn_Add, 4, 4);
            this.tlp_Customer_Details.Location = new System.Drawing.Point(6, 18);
            this.tlp_Customer_Details.Name = "tlp_Customer_Details";
            this.tlp_Customer_Details.RowCount = 5;
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.17518F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.82482F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlp_Customer_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_Customer_Details.Size = new System.Drawing.Size(651, 336);
            this.tlp_Customer_Details.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(22, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(123, 29);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(151, 11);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(167, 25);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Name.Location = new System.Drawing.Point(22, 59);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(123, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(151, 61);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(167, 25);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(22, 113);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(123, 29);
            this.lbl_Mobile_Number.TabIndex = 4;
            this.lbl_Mobile_Number.Text = "MobileNo";
            this.lbl_Mobile_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(151, 115);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(167, 25);
            this.tb_Mobile_Number.TabIndex = 5;
            this.tb_Mobile_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_Number_KeyPress);
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(151, 164);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(167, 118);
            this.tb_Address.TabIndex = 6;
            this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Address_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Date.Location = new System.Drawing.Point(324, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(123, 29);
            this.lbl_Date.TabIndex = 8;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(453, 8);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(163, 32);
            this.dtp_Date.TabIndex = 9;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Address.Location = new System.Drawing.Point(22, 208);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(123, 29);
            this.lbl_Address.TabIndex = 7;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_PAN_No.Location = new System.Drawing.Point(324, 59);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(123, 29);
            this.lbl_PAN_No.TabIndex = 10;
            this.lbl_PAN_No.Text = "PAN No.";
            this.lbl_PAN_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PAN_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PAN_No.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(453, 61);
            this.tb_PAN_No.MaxLength = 10;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(163, 25);
            this.tb_PAN_No.TabIndex = 11;
            this.tb_PAN_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PAN_No_KeyPress);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(151, 296);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(167, 34);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(453, 296);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(163, 34);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Add_Customer);
            this.Controls.Add(this.pnl_Header);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Add_New_Customer_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Add_Customer.ResumeLayout(false);
            this.gb_Customer_Details.ResumeLayout(false);
            this.tlp_Customer_Details.ResumeLayout(false);
            this.tlp_Customer_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Add_Customer;
        private System.Windows.Forms.Panel pnl_Add_Customer;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Customer_Details;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add;


    }
}