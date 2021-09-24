namespace Jewellery_Shop_Management_System
{
    partial class Frm_Add_Employee
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
            this.lbl_Add_New_Employee = new System.Windows.Forms.Label();
            this.gb_Employee_ID = new System.Windows.Forms.GroupBox();
            this.tlp_Employee_ID = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Join_Date = new System.Windows.Forms.Label();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Personal_Details = new System.Windows.Forms.TableLayoutPanel();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.gb_Other_Details = new System.Windows.Forms.GroupBox();
            this.tlp_Other_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Account_Number = new System.Windows.Forms.Label();
            this.tb_Account_Number = new System.Windows.Forms.TextBox();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.tb_Adhar_Number = new System.Windows.Forms.TextBox();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.tb_Qualification = new System.Windows.Forms.TextBox();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.tb_Experience = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Employee_ID.SuspendLayout();
            this.tlp_Employee_ID.SuspendLayout();
            this.gb_Personal_Details.SuspendLayout();
            this.tlp_Personal_Details.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.gb_Other_Details.SuspendLayout();
            this.tlp_Other_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Add_New_Employee);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 49);
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
            this.btn_X.Location = new System.Drawing.Point(811, 4);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(54, 39);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // lbl_Add_New_Employee
            // 
            this.lbl_Add_New_Employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add_New_Employee.AutoSize = true;
            this.lbl_Add_New_Employee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Employee.Location = new System.Drawing.Point(334, 9);
            this.lbl_Add_New_Employee.Name = "lbl_Add_New_Employee";
            this.lbl_Add_New_Employee.Size = new System.Drawing.Size(279, 32);
            this.lbl_Add_New_Employee.TabIndex = 0;
            this.lbl_Add_New_Employee.Text = "Add New Employee ";
            // 
            // gb_Employee_ID
            // 
            this.gb_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Employee_ID.Controls.Add(this.tlp_Employee_ID);
            this.gb_Employee_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_ID.Location = new System.Drawing.Point(8, 53);
            this.gb_Employee_ID.Name = "gb_Employee_ID";
            this.gb_Employee_ID.Size = new System.Drawing.Size(862, 83);
            this.gb_Employee_ID.TabIndex = 3;
            this.gb_Employee_ID.TabStop = false;
            this.gb_Employee_ID.Text = "Employee ID";
            // 
            // tlp_Employee_ID
            // 
            this.tlp_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Employee_ID.ColumnCount = 4;
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.14851F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.85149F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tlp_Employee_ID.Controls.Add(this.dtp_Date, 3, 0);
            this.tlp_Employee_ID.Controls.Add(this.lbl_Join_Date, 2, 0);
            this.tlp_Employee_ID.Controls.Add(this.lbl_Employee_ID, 0, 0);
            this.tlp_Employee_ID.Controls.Add(this.tb_Employee_ID, 1, 0);
            this.tlp_Employee_ID.Location = new System.Drawing.Point(7, 21);
            this.tlp_Employee_ID.Name = "tlp_Employee_ID";
            this.tlp_Employee_ID.RowCount = 1;
            this.tlp_Employee_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Employee_ID.Size = new System.Drawing.Size(848, 51);
            this.tlp_Employee_ID.TabIndex = 0;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(596, 11);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(233, 28);
            this.dtp_Date.TabIndex = 36;
            // 
            // lbl_Join_Date
            // 
            this.lbl_Join_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Join_Date.AutoSize = true;
            this.lbl_Join_Date.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Join_Date.Location = new System.Drawing.Point(445, 14);
            this.lbl_Join_Date.Name = "lbl_Join_Date";
            this.lbl_Join_Date.Size = new System.Drawing.Size(90, 22);
            this.lbl_Join_Date.TabIndex = 35;
            this.lbl_Join_Date.Text = "Join Date";
            this.lbl_Join_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Employee_ID.Location = new System.Drawing.Point(30, 14);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(80, 22);
            this.lbl_Employee_ID.TabIndex = 5;
            this.lbl_Employee_ID.Text = "Emp.ID ";
            this.lbl_Employee_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Employee_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Employee_ID.Enabled = false;
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(144, 13);
            this.tb_Employee_ID.MaxLength = 5;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(256, 25);
            this.tb_Employee_ID.TabIndex = 6;
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Personal_Details.Controls.Add(this.tlp_Personal_Details);
            this.gb_Personal_Details.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Personal_Details.Location = new System.Drawing.Point(8, 140);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Size = new System.Drawing.Size(862, 128);
            this.gb_Personal_Details.TabIndex = 4;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal Details";
            // 
            // tlp_Personal_Details
            // 
            this.tlp_Personal_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Personal_Details.ColumnCount = 4;
            this.tlp_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tlp_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlp_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tlp_Personal_Details.Controls.Add(this.gb_Gender, 3, 1);
            this.tlp_Personal_Details.Controls.Add(this.lbl_Gender, 2, 1);
            this.tlp_Personal_Details.Controls.Add(this.dtp_DOB, 1, 1);
            this.tlp_Personal_Details.Controls.Add(this.lbl_DOB, 0, 1);
            this.tlp_Personal_Details.Controls.Add(this.tb_Mobile_Number, 3, 0);
            this.tlp_Personal_Details.Controls.Add(this.lbl_Mobile_No, 2, 0);
            this.tlp_Personal_Details.Controls.Add(this.tb_Name, 1, 0);
            this.tlp_Personal_Details.Controls.Add(this.lbl_Name, 0, 0);
            this.tlp_Personal_Details.Location = new System.Drawing.Point(12, 20);
            this.tlp_Personal_Details.Name = "tlp_Personal_Details";
            this.tlp_Personal_Details.RowCount = 2;
            this.tlp_Personal_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.92523F));
            this.tlp_Personal_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.07477F));
            this.tlp_Personal_Details.Size = new System.Drawing.Size(840, 98);
            this.tlp_Personal_Details.TabIndex = 0;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(582, 46);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(253, 49);
            this.gb_Gender.TabIndex = 58;
            this.gb_Gender.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Female.AutoSize = true;
            this.rb_Female.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb_Female.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.Color.Black;
            this.rb_Female.Location = new System.Drawing.Point(36, 18);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(79, 22);
            this.rb_Female.TabIndex = 49;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = false;
            // 
            // rb_Male
            // 
            this.rb_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Male.AutoSize = true;
            this.rb_Male.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb_Male.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.Color.Black;
            this.rb_Male.Location = new System.Drawing.Point(150, 17);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(60, 22);
            this.rb_Male.TabIndex = 48;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = false;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Gender.Location = new System.Drawing.Point(451, 59);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(74, 22);
            this.lbl_Gender.TabIndex = 57;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(139, 56);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(258, 28);
            this.dtp_DOB.TabIndex = 56;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_DOB.Location = new System.Drawing.Point(8, 59);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(119, 22);
            this.lbl_DOB.TabIndex = 55;
            this.lbl_DOB.Text = "Date Of Birth";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Mobile_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(583, 9);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(250, 25);
            this.tb_Mobile_Number.TabIndex = 38;
            this.tb_Mobile_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_Number_KeyPress);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(441, 10);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(95, 22);
            this.lbl_Mobile_No.TabIndex = 37;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(139, 9);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(258, 25);
            this.tb_Name.TabIndex = 34;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Name.Location = new System.Drawing.Point(35, 10);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 22);
            this.lbl_Name.TabIndex = 33;
            this.lbl_Name.Text = "Name ";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Other_Details
            // 
            this.gb_Other_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Other_Details.Controls.Add(this.tlp_Other_Details);
            this.gb_Other_Details.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Other_Details.Location = new System.Drawing.Point(8, 271);
            this.gb_Other_Details.Name = "gb_Other_Details";
            this.gb_Other_Details.Size = new System.Drawing.Size(862, 135);
            this.gb_Other_Details.TabIndex = 5;
            this.gb_Other_Details.TabStop = false;
            this.gb_Other_Details.Text = "Other Details";
            // 
            // tlp_Other_Details
            // 
            this.tlp_Other_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Other_Details.ColumnCount = 4;
            this.tlp_Other_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.19431F));
            this.tlp_Other_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.6872F));
            this.tlp_Other_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.03F));
            this.tlp_Other_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97F));
            this.tlp_Other_Details.Controls.Add(this.lbl_Account_Number, 0, 0);
            this.tlp_Other_Details.Controls.Add(this.tb_Account_Number, 1, 0);
            this.tlp_Other_Details.Controls.Add(this.lbl_Adhar_No, 2, 0);
            this.tlp_Other_Details.Controls.Add(this.tb_Adhar_Number, 3, 0);
            this.tlp_Other_Details.Controls.Add(this.lbl_Qualification, 0, 1);
            this.tlp_Other_Details.Controls.Add(this.tb_Qualification, 1, 1);
            this.tlp_Other_Details.Controls.Add(this.lbl_Experience, 2, 1);
            this.tlp_Other_Details.Controls.Add(this.tb_Experience, 3, 1);
            this.tlp_Other_Details.Controls.Add(this.lbl_Address, 0, 2);
            this.tlp_Other_Details.Controls.Add(this.tb_Address, 1, 2);
            this.tlp_Other_Details.Controls.Add(this.lbl_Salary, 2, 2);
            this.tlp_Other_Details.Controls.Add(this.tb_Salary, 3, 2);
            this.tlp_Other_Details.Location = new System.Drawing.Point(11, 22);
            this.tlp_Other_Details.Name = "tlp_Other_Details";
            this.tlp_Other_Details.RowCount = 3;
            this.tlp_Other_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.09709F));
            this.tlp_Other_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.06796F));
            this.tlp_Other_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.83495F));
            this.tlp_Other_Details.Size = new System.Drawing.Size(844, 103);
            this.tlp_Other_Details.TabIndex = 2;
            // 
            // lbl_Account_Number
            // 
            this.lbl_Account_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Account_Number.AutoSize = true;
            this.lbl_Account_Number.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Account_Number.Location = new System.Drawing.Point(5, 4);
            this.lbl_Account_Number.Name = "lbl_Account_Number";
            this.lbl_Account_Number.Size = new System.Drawing.Size(151, 22);
            this.lbl_Account_Number.TabIndex = 52;
            this.lbl_Account_Number.Text = "Account Number";
            this.lbl_Account_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Account_Number
            // 
            this.tb_Account_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Account_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Account_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_Number.Location = new System.Drawing.Point(165, 3);
            this.tb_Account_Number.MaxLength = 15;
            this.tb_Account_Number.Name = "tb_Account_Number";
            this.tb_Account_Number.Size = new System.Drawing.Size(253, 25);
            this.tb_Account_Number.TabIndex = 39;
            this.tb_Account_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Account_Number_KeyPress);
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Adhar_No.Location = new System.Drawing.Point(448, 4);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(89, 22);
            this.lbl_Adhar_No.TabIndex = 38;
            this.lbl_Adhar_No.Text = "Adhar No";
            this.lbl_Adhar_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Adhar_Number
            // 
            this.tb_Adhar_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Adhar_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Adhar_Number.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhar_Number.Location = new System.Drawing.Point(578, 3);
            this.tb_Adhar_Number.MaxLength = 12;
            this.tb_Adhar_Number.Name = "tb_Adhar_Number";
            this.tb_Adhar_Number.Size = new System.Drawing.Size(252, 25);
            this.tb_Adhar_Number.TabIndex = 53;
            this.tb_Adhar_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Adhar_Number_KeyPress);
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Qualification.Location = new System.Drawing.Point(24, 35);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(113, 22);
            this.lbl_Qualification.TabIndex = 54;
            this.lbl_Qualification.Text = "Qualification";
            this.lbl_Qualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Qualification
            // 
            this.tb_Qualification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Qualification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Qualification.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qualification.Location = new System.Drawing.Point(165, 34);
            this.tb_Qualification.MaxLength = 20;
            this.tb_Qualification.Name = "tb_Qualification";
            this.tb_Qualification.Size = new System.Drawing.Size(253, 25);
            this.tb_Qualification.TabIndex = 55;
            this.tb_Qualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Qualification_KeyPress);
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Experience.Location = new System.Drawing.Point(439, 35);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(106, 22);
            this.lbl_Experience.TabIndex = 56;
            this.lbl_Experience.Text = "Experience";
            this.lbl_Experience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Experience
            // 
            this.tb_Experience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Experience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Experience.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Experience.Location = new System.Drawing.Point(576, 34);
            this.tb_Experience.MaxLength = 20;
            this.tb_Experience.Name = "tb_Experience";
            this.tb_Experience.Size = new System.Drawing.Size(255, 25);
            this.tb_Experience.TabIndex = 57;
            this.tb_Experience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Experience_KeyPress);
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Address.Location = new System.Drawing.Point(40, 71);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(82, 22);
            this.lbl_Address.TabIndex = 44;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(165, 65);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(253, 35);
            this.tb_Address.TabIndex = 45;
            this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Address_KeyPress);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Salary.Location = new System.Drawing.Point(461, 71);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(62, 22);
            this.lbl_Salary.TabIndex = 40;
            this.lbl_Salary.Text = "Salary";
            this.lbl_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(577, 70);
            this.tb_Salary.MaxLength = 10;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(254, 25);
            this.tb_Salary.TabIndex = 41;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Salary_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(595, 419);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(143, 34);
            this.btn_Save.TabIndex = 52;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(184, 419);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 34);
            this.btn_Refresh.TabIndex = 53;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Frm_Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Other_Details);
            this.Controls.Add(this.gb_Personal_Details);
            this.Controls.Add(this.gb_Employee_ID);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Add_Employee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.Frm_Add_Employee_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Employee_ID.ResumeLayout(false);
            this.tlp_Employee_ID.ResumeLayout(false);
            this.tlp_Employee_ID.PerformLayout();
            this.gb_Personal_Details.ResumeLayout(false);
            this.tlp_Personal_Details.ResumeLayout(false);
            this.tlp_Personal_Details.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Other_Details.ResumeLayout(false);
            this.tlp_Other_Details.ResumeLayout(false);
            this.tlp_Other_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Add_New_Employee;
        private System.Windows.Forms.GroupBox gb_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Join_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Employee_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TableLayoutPanel tlp_Personal_Details;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.GroupBox gb_Other_Details;
        private System.Windows.Forms.TableLayoutPanel tlp_Other_Details;
        private System.Windows.Forms.Label lbl_Account_Number;
        private System.Windows.Forms.TextBox tb_Account_Number;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.TextBox tb_Adhar_Number;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.TextBox tb_Qualification;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.TextBox tb_Experience;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}