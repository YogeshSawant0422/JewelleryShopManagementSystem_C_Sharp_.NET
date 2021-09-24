namespace Jewellery_Shop_Management_System
{
    partial class Frm_Add_New_Product_Category
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
            this.lbl_Add_Category = new System.Windows.Forms.Label();
            this.pnl_Add_Category = new System.Windows.Forms.Panel();
            this.gb_Category_Details = new System.Windows.Forms.GroupBox();
            this.tbl_Add_Category = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Add_Category.SuspendLayout();
            this.gb_Category_Details.SuspendLayout();
            this.tbl_Add_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Add_Category);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(890, 65);
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
            this.btn_X.Location = new System.Drawing.Point(830, 7);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(54, 39);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click_1);
            // 
            // lbl_Add_Category
            // 
            this.lbl_Add_Category.AutoSize = true;
            this.lbl_Add_Category.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Category.Location = new System.Drawing.Point(368, 14);
            this.lbl_Add_Category.Name = "lbl_Add_Category";
            this.lbl_Add_Category.Size = new System.Drawing.Size(195, 32);
            this.lbl_Add_Category.TabIndex = 0;
            this.lbl_Add_Category.Text = "Add Category";
            this.lbl_Add_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Add_Category
            // 
            this.pnl_Add_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Add_Category.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Add_Category.Controls.Add(this.gb_Category_Details);
            this.pnl_Add_Category.Location = new System.Drawing.Point(173, 113);
            this.pnl_Add_Category.Name = "pnl_Add_Category";
            this.pnl_Add_Category.Size = new System.Drawing.Size(584, 363);
            this.pnl_Add_Category.TabIndex = 3;
            // 
            // gb_Category_Details
            // 
            this.gb_Category_Details.Controls.Add(this.tbl_Add_Category);
            this.gb_Category_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Category_Details.Location = new System.Drawing.Point(16, 7);
            this.gb_Category_Details.Name = "gb_Category_Details";
            this.gb_Category_Details.Size = new System.Drawing.Size(551, 348);
            this.gb_Category_Details.TabIndex = 0;
            this.gb_Category_Details.TabStop = false;
            this.gb_Category_Details.Text = "Category Details";
            // 
            // tbl_Add_Category
            // 
            this.tbl_Add_Category.ColumnCount = 4;
            this.tbl_Add_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.03344F));
            this.tbl_Add_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.96655F));
            this.tbl_Add_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tbl_Add_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_Add_Category.Controls.Add(this.lbl_Category_ID, 1, 1);
            this.tbl_Add_Category.Controls.Add(this.lbl_Category_Name, 1, 2);
            this.tbl_Add_Category.Controls.Add(this.tb_Category_ID, 2, 1);
            this.tbl_Add_Category.Controls.Add(this.tb_Category_Name, 2, 2);
            this.tbl_Add_Category.Controls.Add(this.btn_Add, 2, 4);
            this.tbl_Add_Category.Controls.Add(this.btn_Refresh, 1, 4);
            this.tbl_Add_Category.Location = new System.Drawing.Point(6, 21);
            this.tbl_Add_Category.Name = "tbl_Add_Category";
            this.tbl_Add_Category.RowCount = 6;
            this.tbl_Add_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.20144F));
            this.tbl_Add_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.79856F));
            this.tbl_Add_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tbl_Add_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tbl_Add_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Add_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_Add_Category.Size = new System.Drawing.Size(539, 321);
            this.tbl_Add_Category.TabIndex = 0;
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_ID.Location = new System.Drawing.Point(29, 79);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(232, 29);
            this.lbl_Category_ID.TabIndex = 2;
            this.lbl_Category_ID.Text = "Category ID ";
            this.lbl_Category_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Category_Name.Location = new System.Drawing.Point(29, 145);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(232, 29);
            this.lbl_Category_Name.TabIndex = 4;
            this.lbl_Category_Name.Text = "Category Name ";
            this.lbl_Category_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Category_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Category_ID.Enabled = false;
            this.tb_Category_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_ID.Location = new System.Drawing.Point(267, 81);
            this.tb_Category_ID.MaxLength = 5;
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(237, 25);
            this.tb_Category_ID.TabIndex = 1;
            this.tb_Category_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_ID_KeyPress);
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Category_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(267, 147);
            this.tb_Category_Name.MaxLength = 40;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(237, 25);
            this.tb_Category_Name.TabIndex = 2;
            this.tb_Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_Name_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(267, 253);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(237, 34);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(29, 253);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(232, 34);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Frm_Add_New_Product_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Add_Category);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_New_Product_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product Category";
            this.Load += new System.EventHandler(this.Frm_Add_New_Product_Category_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Add_Category.ResumeLayout(false);
            this.gb_Category_Details.ResumeLayout(false);
            this.tbl_Add_Category.ResumeLayout(false);
            this.tbl_Add_Category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Add_Category;
        private System.Windows.Forms.Panel pnl_Add_Category;
        private System.Windows.Forms.TableLayoutPanel tbl_Add_Category;
        private System.Windows.Forms.GroupBox gb_Category_Details;
        private System.Windows.Forms.Label lbl_Category_ID;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.TextBox tb_Category_ID;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Refresh;

    }
}