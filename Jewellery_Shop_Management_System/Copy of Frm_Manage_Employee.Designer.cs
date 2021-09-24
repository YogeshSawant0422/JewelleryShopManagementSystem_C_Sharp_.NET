namespace Jewellery_Shop_Management_System
{
    partial class Frm_Manage_Employee
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.lbl_Manage_Employee = new System.Windows.Forms.Label();
            this.gb_Employee_ID = new System.Windows.Forms.GroupBox();
            this.tlp_Employee_ID = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Join_Date = new System.Windows.Forms.Label();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Join_Date = new System.Windows.Forms.TextBox();
            this.lbl_Leave_Date = new System.Windows.Forms.Label();
            this.tb_Leave_Date = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.gb_View = new System.Windows.Forms.GroupBox();
            this.dgv_Manage_Employee = new System.Windows.Forms.DataGridView();
            this.jewellery_Shop_Management_System_DBDataSet5 = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet5();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Jewellery_Shop_Management_System.Jewellery_Shop_Management_System_DBDataSet5TableAdapters.Employee_DetailsTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experianceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Employee_ID.SuspendLayout();
            this.tlp_Employee_ID.SuspendLayout();
            this.gb_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manage_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Manage_Employee);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 49);
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
            this.btn_X.Location = new System.Drawing.Point(811, 4);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(54, 39);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // lbl_Manage_Employee
            // 
            this.lbl_Manage_Employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Manage_Employee.AutoSize = true;
            this.lbl_Manage_Employee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manage_Employee.Location = new System.Drawing.Point(334, 9);
            this.lbl_Manage_Employee.Name = "lbl_Manage_Employee";
            this.lbl_Manage_Employee.Size = new System.Drawing.Size(262, 32);
            this.lbl_Manage_Employee.TabIndex = 0;
            this.lbl_Manage_Employee.Text = "Manage Employee ";
            // 
            // gb_Employee_ID
            // 
            this.gb_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Employee_ID.Controls.Add(this.tlp_Employee_ID);
            this.gb_Employee_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_ID.Location = new System.Drawing.Point(6, 54);
            this.gb_Employee_ID.Name = "gb_Employee_ID";
            this.gb_Employee_ID.Size = new System.Drawing.Size(862, 116);
            this.gb_Employee_ID.TabIndex = 4;
            this.gb_Employee_ID.TabStop = false;
            this.gb_Employee_ID.Text = "Employee ID";
            // 
            // tlp_Employee_ID
            // 
            this.tlp_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Employee_ID.ColumnCount = 5;
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.71648F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.28352F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlp_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tlp_Employee_ID.Controls.Add(this.tb_Status, 0, 1);
            this.tlp_Employee_ID.Controls.Add(this.lbl_Status, 0, 1);
            this.tlp_Employee_ID.Controls.Add(this.lbl_Employee_ID, 0, 0);
            this.tlp_Employee_ID.Controls.Add(this.btn_Search, 2, 0);
            this.tlp_Employee_ID.Controls.Add(this.lbl_Join_Date, 3, 0);
            this.tlp_Employee_ID.Controls.Add(this.tb_Join_Date, 4, 0);
            this.tlp_Employee_ID.Controls.Add(this.tb_Employee_ID, 1, 0);
            this.tlp_Employee_ID.Controls.Add(this.lbl_Leave_Date, 3, 1);
            this.tlp_Employee_ID.Controls.Add(this.tb_Leave_Date, 4, 1);
            this.tlp_Employee_ID.Location = new System.Drawing.Point(7, 21);
            this.tlp_Employee_ID.Name = "tlp_Employee_ID";
            this.tlp_Employee_ID.RowCount = 2;
            this.tlp_Employee_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Employee_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlp_Employee_ID.Size = new System.Drawing.Size(848, 85);
            this.tlp_Employee_ID.TabIndex = 0;
            // 
            // lbl_Join_Date
            // 
            this.lbl_Join_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Join_Date.AutoSize = true;
            this.lbl_Join_Date.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Join_Date.Location = new System.Drawing.Point(516, 10);
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
            this.lbl_Employee_ID.Location = new System.Drawing.Point(19, 10);
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
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(121, 9);
            this.tb_Employee_ID.MaxLength = 5;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(225, 25);
            this.tb_Employee_ID.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(352, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(145, 33);
            this.btn_Search.TabIndex = 37;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Join_Date
            // 
            this.tb_Join_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Join_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Join_Date.Enabled = false;
            this.tb_Join_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.tb_Join_Date.Location = new System.Drawing.Point(625, 9);
            this.tb_Join_Date.MaxLength = 20;
            this.tb_Join_Date.Name = "tb_Join_Date";
            this.tb_Join_Date.Size = new System.Drawing.Size(220, 25);
            this.tb_Join_Date.TabIndex = 38;
            // 
            // lbl_Leave_Date
            // 
            this.lbl_Leave_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Leave_Date.AutoSize = true;
            this.lbl_Leave_Date.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Leave_Date.Location = new System.Drawing.Point(507, 53);
            this.lbl_Leave_Date.Name = "lbl_Leave_Date";
            this.lbl_Leave_Date.Size = new System.Drawing.Size(107, 22);
            this.lbl_Leave_Date.TabIndex = 39;
            this.lbl_Leave_Date.Text = "Leave Date";
            this.lbl_Leave_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Leave_Date
            // 
            this.tb_Leave_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Leave_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Leave_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.tb_Leave_Date.Location = new System.Drawing.Point(625, 51);
            this.tb_Leave_Date.MaxLength = 20;
            this.tb_Leave_Date.Name = "tb_Leave_Date";
            this.tb_Leave_Date.Size = new System.Drawing.Size(220, 25);
            this.tb_Leave_Date.TabIndex = 40;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lbl_Status.Location = new System.Drawing.Point(27, 53);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(63, 22);
            this.lbl_Status.TabIndex = 41;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Status
            // 
            this.tb_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Status.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Status.Location = new System.Drawing.Point(121, 51);
            this.tb_Status.MaxLength = 20;
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(225, 25);
            this.tb_Status.TabIndex = 58;
            // 
            // gb_View
            // 
            this.gb_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_View.Controls.Add(this.dgv_Manage_Employee);
            this.gb_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_View.Location = new System.Drawing.Point(6, 175);
            this.gb_View.Name = "gb_View";
            this.gb_View.Size = new System.Drawing.Size(862, 235);
            this.gb_View.TabIndex = 5;
            this.gb_View.TabStop = false;
            this.gb_View.Text = "View";
            // 
            // dgv_Manage_Employee
            // 
            this.dgv_Manage_Employee.AllowUserToAddRows = false;
            this.dgv_Manage_Employee.AllowUserToDeleteRows = false;
            this.dgv_Manage_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Manage_Employee.AutoGenerateColumns = false;
            this.dgv_Manage_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Manage_Employee.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Manage_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Manage_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Manage_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.adharNoDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.experianceDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.leaveDateDataGridViewTextBoxColumn});
            this.dgv_Manage_Employee.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Manage_Employee.Location = new System.Drawing.Point(8, 19);
            this.dgv_Manage_Employee.Name = "dgv_Manage_Employee";
            this.dgv_Manage_Employee.ReadOnly = true;
            this.dgv_Manage_Employee.RowHeadersVisible = false;
            this.dgv_Manage_Employee.Size = new System.Drawing.Size(845, 209);
            this.dgv_Manage_Employee.TabIndex = 0;
            // 
            // jewellery_Shop_Management_System_DBDataSet5
            // 
            this.jewellery_Shop_Management_System_DBDataSet5.DataSetName = "Jewellery_Shop_Management_System_DBDataSet5";
            this.jewellery_Shop_Management_System_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.jewellery_Shop_Management_System_DBDataSet5;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "Join_Date";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "Join_Date";
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            this.joinDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adharNoDataGridViewTextBoxColumn
            // 
            this.adharNoDataGridViewTextBoxColumn.DataPropertyName = "Adhar_No";
            this.adharNoDataGridViewTextBoxColumn.HeaderText = "Adhar_No";
            this.adharNoDataGridViewTextBoxColumn.Name = "adharNoDataGridViewTextBoxColumn";
            this.adharNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experianceDataGridViewTextBoxColumn
            // 
            this.experianceDataGridViewTextBoxColumn.DataPropertyName = "Experiance";
            this.experianceDataGridViewTextBoxColumn.HeaderText = "Experiance";
            this.experianceDataGridViewTextBoxColumn.Name = "experianceDataGridViewTextBoxColumn";
            this.experianceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveDateDataGridViewTextBoxColumn
            // 
            this.leaveDateDataGridViewTextBoxColumn.DataPropertyName = "Leave_Date";
            this.leaveDateDataGridViewTextBoxColumn.HeaderText = "Leave_Date";
            this.leaveDateDataGridViewTextBoxColumn.Name = "leaveDateDataGridViewTextBoxColumn";
            this.leaveDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tlp_Buttons.Controls.Add(this.btn_Refresh, 4, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(36, 416);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(812, 41);
            this.tlp_Buttons.TabIndex = 6;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(585, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(224, 33);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Refresh Grid";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(217, 33);
            this.btn_Update.TabIndex = 38;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Frm_Manage_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.gb_View);
            this.Controls.Add(this.gb_Employee_ID);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Manage_Employee";
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.Frm_Manage_Employee_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Employee_ID.ResumeLayout(false);
            this.tlp_Employee_ID.ResumeLayout(false);
            this.tlp_Employee_ID.PerformLayout();
            this.gb_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manage_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewellery_Shop_Management_System_DBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Manage_Employee;
        private System.Windows.Forms.GroupBox gb_Employee_ID;
        private System.Windows.Forms.TableLayoutPanel tlp_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Join_Date;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Join_Date;
        private System.Windows.Forms.Label lbl_Leave_Date;
        private System.Windows.Forms.TextBox tb_Leave_Date;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.GroupBox gb_View;
        private System.Windows.Forms.DataGridView dgv_Manage_Employee;
        private Jewellery_Shop_Management_System_DBDataSet5 jewellery_Shop_Management_System_DBDataSet5;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Jewellery_Shop_Management_System_DBDataSet5TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experianceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
    }
}