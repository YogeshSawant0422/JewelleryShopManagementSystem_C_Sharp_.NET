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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.tb_Silver_Price = new System.Windows.Forms.TextBox();
            this.tb_Gold_Price = new System.Windows.Forms.TextBox();
            this.lbl_Silver_Price = new System.Windows.Forms.Label();
            this.lbl_Gold_Price = new System.Windows.Forms.Label();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_Product_Details = new System.Windows.Forms.Label();
            this.gb_Product_Info = new System.Windows.Forms.GroupBox();
            this.tlp_Product_Info = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Sub_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.gb_Weight_Price = new System.Windows.Forms.GroupBox();
            this.tlp_Weight_Price = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Net_Wt = new System.Windows.Forms.Label();
            this.tb_Net_Wt = new System.Windows.Forms.TextBox();
            this.lbl_Purity = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.cmb_Purity = new System.Windows.Forms.ComboBox();
            this.tlp_Dgv = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.Net_Wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Product_Info.SuspendLayout();
            this.tlp_Product_Info.SuspendLayout();
            this.gb_Weight_Price.SuspendLayout();
            this.tlp_Weight_Price.SuspendLayout();
            this.tlp_Dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.tb_Silver_Price);
            this.pnl_Header.Controls.Add(this.tb_Gold_Price);
            this.pnl_Header.Controls.Add(this.lbl_Silver_Price);
            this.pnl_Header.Controls.Add(this.lbl_Gold_Price);
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Product_Details);
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 57);
            this.pnl_Header.TabIndex = 2;
            // 
            // tb_Silver_Price
            // 
            this.tb_Silver_Price.BackColor = System.Drawing.Color.White;
            this.tb_Silver_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Silver_Price.Enabled = false;
            this.tb_Silver_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Silver_Price.ForeColor = System.Drawing.Color.Black;
            this.tb_Silver_Price.Location = new System.Drawing.Point(80, 32);
            this.tb_Silver_Price.Name = "tb_Silver_Price";
            this.tb_Silver_Price.Size = new System.Drawing.Size(160, 19);
            this.tb_Silver_Price.TabIndex = 20;
            this.tb_Silver_Price.Text = "74,000";
            // 
            // tb_Gold_Price
            // 
            this.tb_Gold_Price.BackColor = System.Drawing.Color.White;
            this.tb_Gold_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Gold_Price.Enabled = false;
            this.tb_Gold_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gold_Price.ForeColor = System.Drawing.Color.Black;
            this.tb_Gold_Price.Location = new System.Drawing.Point(80, 4);
            this.tb_Gold_Price.Name = "tb_Gold_Price";
            this.tb_Gold_Price.Size = new System.Drawing.Size(160, 19);
            this.tb_Gold_Price.TabIndex = 19;
            this.tb_Gold_Price.Text = "45,750";
            // 
            // lbl_Silver_Price
            // 
            this.lbl_Silver_Price.AutoSize = true;
            this.lbl_Silver_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Silver_Price.Location = new System.Drawing.Point(4, 32);
            this.lbl_Silver_Price.Name = "lbl_Silver_Price";
            this.lbl_Silver_Price.Size = new System.Drawing.Size(70, 21);
            this.lbl_Silver_Price.TabIndex = 18;
            this.lbl_Silver_Price.Text = "S-Price : ";
            // 
            // lbl_Gold_Price
            // 
            this.lbl_Gold_Price.AutoSize = true;
            this.lbl_Gold_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gold_Price.Location = new System.Drawing.Point(4, 4);
            this.lbl_Gold_Price.Name = "lbl_Gold_Price";
            this.lbl_Gold_Price.Size = new System.Drawing.Size(72, 21);
            this.lbl_Gold_Price.TabIndex = 17;
            this.lbl_Gold_Price.Text = "G-Price : ";
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
            this.gb_Product_Info.Controls.Add(this.tlp_Product_Info);
            this.gb_Product_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Info.Location = new System.Drawing.Point(7, 60);
            this.gb_Product_Info.Name = "gb_Product_Info";
            this.gb_Product_Info.Size = new System.Drawing.Size(861, 147);
            this.gb_Product_Info.TabIndex = 3;
            this.gb_Product_Info.TabStop = false;
            this.gb_Product_Info.Text = "Product Info";
            // 
            // tlp_Product_Info
            // 
            this.tlp_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Product_Info.ColumnCount = 7;
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.355932F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.13828F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.20911F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.9393F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.47604F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlp_Product_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlp_Product_Info.Controls.Add(this.tb_Product_ID, 2, 0);
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_ID, 1, 0);
            this.tlp_Product_Info.Controls.Add(this.lbl_Category, 1, 1);
            this.tlp_Product_Info.Controls.Add(this.cmb_Category, 2, 1);
            this.tlp_Product_Info.Controls.Add(this.cmb_Sub_Category, 2, 2);
            this.tlp_Product_Info.Controls.Add(this.lbl_Sub_Category, 1, 2);
            this.tlp_Product_Info.Controls.Add(this.lbl_Product_Name, 4, 1);
            this.tlp_Product_Info.Controls.Add(this.tb_Product_Name, 5, 1);
            this.tlp_Product_Info.Location = new System.Drawing.Point(6, 21);
            this.tlp_Product_Info.Name = "tlp_Product_Info";
            this.tlp_Product_Info.RowCount = 3;
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tlp_Product_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_Product_Info.Size = new System.Drawing.Size(843, 114);
            this.tlp_Product_Info.TabIndex = 0;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(166, 7);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(185, 25);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_ID_KeyPress);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(11, 7);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(149, 24);
            this.lbl_Product_ID.TabIndex = 3;
            this.lbl_Product_ID.Text = "Product ID ";
            this.lbl_Product_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(11, 46);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(149, 24);
            this.lbl_Category.TabIndex = 6;
            this.lbl_Category.Text = "Category  ";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(166, 44);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(185, 27);
            this.cmb_Category.TabIndex = 3;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // cmb_Sub_Category
            // 
            this.cmb_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sub_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sub_Category.FormattingEnabled = true;
            this.cmb_Sub_Category.Location = new System.Drawing.Point(166, 80);
            this.cmb_Sub_Category.Name = "cmb_Sub_Category";
            this.cmb_Sub_Category.Size = new System.Drawing.Size(185, 27);
            this.cmb_Sub_Category.TabIndex = 4;
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Category.Location = new System.Drawing.Point(11, 83);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(149, 24);
            this.lbl_Sub_Category.TabIndex = 7;
            this.lbl_Sub_Category.Text = "Sub Category  ";
            this.lbl_Sub_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(433, 46);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(157, 24);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name ";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(596, 45);
            this.tb_Product_Name.MaxLength = 80;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(204, 25);
            this.tb_Product_Name.TabIndex = 5;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Name_KeyPress);
            // 
            // gb_Weight_Price
            // 
            this.gb_Weight_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Weight_Price.Controls.Add(this.tlp_Weight_Price);
            this.gb_Weight_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Weight_Price.Location = new System.Drawing.Point(7, 214);
            this.gb_Weight_Price.Name = "gb_Weight_Price";
            this.gb_Weight_Price.Size = new System.Drawing.Size(861, 113);
            this.gb_Weight_Price.TabIndex = 4;
            this.gb_Weight_Price.TabStop = false;
            this.gb_Weight_Price.Text = "Weight And Price Info";
            // 
            // tlp_Weight_Price
            // 
            this.tlp_Weight_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Weight_Price.ColumnCount = 5;
            this.tlp_Weight_Price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02356F));
            this.tlp_Weight_Price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.14134F));
            this.tlp_Weight_Price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.37691F));
            this.tlp_Weight_Price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.37927F));
            this.tlp_Weight_Price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.96113F));
            this.tlp_Weight_Price.Controls.Add(this.lbl_Net_Wt, 0, 0);
            this.tlp_Weight_Price.Controls.Add(this.tb_Net_Wt, 0, 1);
            this.tlp_Weight_Price.Controls.Add(this.lbl_Purity, 2, 0);
            this.tlp_Weight_Price.Controls.Add(this.lbl_Unit, 1, 0);
            this.tlp_Weight_Price.Controls.Add(this.lbl_Price, 3, 0);
            this.tlp_Weight_Price.Controls.Add(this.tb_Price, 3, 1);
            this.tlp_Weight_Price.Controls.Add(this.btn_Add, 4, 1);
            this.tlp_Weight_Price.Controls.Add(this.cmb_Unit, 1, 1);
            this.tlp_Weight_Price.Controls.Add(this.cmb_Purity, 2, 1);
            this.tlp_Weight_Price.Location = new System.Drawing.Point(6, 26);
            this.tlp_Weight_Price.Name = "tlp_Weight_Price";
            this.tlp_Weight_Price.RowCount = 2;
            this.tlp_Weight_Price.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042F));
            this.tlp_Weight_Price.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958F));
            this.tlp_Weight_Price.Size = new System.Drawing.Size(849, 71);
            this.tlp_Weight_Price.TabIndex = 2;
            // 
            // lbl_Net_Wt
            // 
            this.lbl_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Net_Wt.AutoSize = true;
            this.lbl_Net_Wt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Wt.Location = new System.Drawing.Point(3, 4);
            this.lbl_Net_Wt.Name = "lbl_Net_Wt";
            this.lbl_Net_Wt.Size = new System.Drawing.Size(164, 22);
            this.lbl_Net_Wt.TabIndex = 7;
            this.lbl_Net_Wt.Text = "Net.Wt.";
            this.lbl_Net_Wt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Net_Wt
            // 
            this.tb_Net_Wt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Net_Wt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Net_Wt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Net_Wt.Location = new System.Drawing.Point(3, 38);
            this.tb_Net_Wt.MaxLength = 10;
            this.tb_Net_Wt.Name = "tb_Net_Wt";
            this.tb_Net_Wt.Size = new System.Drawing.Size(164, 25);
            this.tb_Net_Wt.TabIndex = 6;
            this.tb_Net_Wt.Text = "0";
            this.tb_Net_Wt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Net_Wt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Net_Wt_KeyPress);
            // 
            // lbl_Purity
            // 
            this.lbl_Purity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Purity.AutoSize = true;
            this.lbl_Purity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purity.Location = new System.Drawing.Point(344, 4);
            this.lbl_Purity.Name = "lbl_Purity";
            this.lbl_Purity.Size = new System.Drawing.Size(167, 22);
            this.lbl_Purity.TabIndex = 9;
            this.lbl_Purity.Text = "Purity";
            this.lbl_Purity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(173, 4);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(165, 22);
            this.lbl_Unit.TabIndex = 20;
            this.lbl_Unit.Text = "Unit";
            this.lbl_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(517, 4);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(184, 22);
            this.lbl_Price.TabIndex = 24;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Price
            // 
            this.tb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(517, 38);
            this.tb_Price.MaxLength = 10;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(184, 25);
            this.tb_Price.TabIndex = 9;
            this.tb_Price.Text = "0";
            this.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Price_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(707, 38);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(139, 26);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Unit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.Items.AddRange(new object[] {
            "gm",
            "ml.gm"});
            this.cmb_Unit.Location = new System.Drawing.Point(173, 37);
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(165, 27);
            this.cmb_Unit.TabIndex = 7;
            // 
            // cmb_Purity
            // 
            this.cmb_Purity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Purity.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Purity.FormattingEnabled = true;
            this.cmb_Purity.Items.AddRange(new object[] {
            "24_Ct",
            "22_Ct",
            "20_Ct",
            "75%_Silver"});
            this.cmb_Purity.Location = new System.Drawing.Point(344, 37);
            this.cmb_Purity.Name = "cmb_Purity";
            this.cmb_Purity.Size = new System.Drawing.Size(167, 27);
            this.cmb_Purity.TabIndex = 25;
            this.cmb_Purity.SelectedIndexChanged += new System.EventHandler(this.cmb_Purity_SelectedIndexChanged);
            // 
            // tlp_Dgv
            // 
            this.tlp_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Dgv.ColumnCount = 1;
            this.tlp_Dgv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.09299F));
            this.tlp_Dgv.Controls.Add(this.dgv_Product, 0, 0);
            this.tlp_Dgv.Location = new System.Drawing.Point(7, 333);
            this.tlp_Dgv.Name = "tlp_Dgv";
            this.tlp_Dgv.RowCount = 1;
            this.tlp_Dgv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Dgv.Size = new System.Drawing.Size(861, 128);
            this.tlp_Dgv.TabIndex = 6;
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Net_Wt,
            this.Unit,
            this.Purity,
            this.Price});
            this.dgv_Product.Location = new System.Drawing.Point(3, 3);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgv_Product.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Product.Size = new System.Drawing.Size(855, 122);
            this.dgv_Product.TabIndex = 0;
            // 
            // Net_Wt
            // 
            this.Net_Wt.HeaderText = "Net_Wt";
            this.Net_Wt.Name = "Net_Wt";
            this.Net_Wt.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Purity
            // 
            this.Purity.HeaderText = "Purity";
            this.Purity.Name = "Purity";
            this.Purity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
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
            this.tlp_Buttons.Controls.Add(this.btn_Save, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 4, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(22, 471);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Size = new System.Drawing.Size(832, 42);
            this.tlp_Buttons.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(137, 35);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(654, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(175, 35);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.Controls.Add(this.gb_Weight_Price);
            this.Controls.Add(this.gb_Product_Info);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Product_Details";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.Frm_Product_Details_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Product_Info.ResumeLayout(false);
            this.tlp_Product_Info.ResumeLayout(false);
            this.tlp_Product_Info.PerformLayout();
            this.gb_Weight_Price.ResumeLayout(false);
            this.tlp_Weight_Price.ResumeLayout(false);
            this.tlp_Weight_Price.PerformLayout();
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
        private System.Windows.Forms.GroupBox gb_Weight_Price;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Sub_Category;
        private System.Windows.Forms.TableLayoutPanel tlp_Dgv;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TableLayoutPanel tlp_Weight_Price;
        private System.Windows.Forms.Label lbl_Net_Wt;
        private System.Windows.Forms.TextBox tb_Net_Wt;
        private System.Windows.Forms.Label lbl_Purity;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net_Wt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ComboBox cmb_Purity;
        private System.Windows.Forms.TextBox tb_Silver_Price;
        private System.Windows.Forms.TextBox tb_Gold_Price;
        private System.Windows.Forms.Label lbl_Silver_Price;
        private System.Windows.Forms.Label lbl_Gold_Price;

    }
}