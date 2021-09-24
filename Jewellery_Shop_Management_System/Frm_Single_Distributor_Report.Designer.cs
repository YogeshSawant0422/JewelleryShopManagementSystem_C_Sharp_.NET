namespace Jewellery_Shop_Management_System.Windows_Form
{
    partial class Frm_Single_Distributor_Report
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
            this.tb_Distributor_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_X = new System.Windows.Forms.Button();
            this.lb_Single_Distributor_Report = new System.Windows.Forms.Label();
            this.Crv_Single_Distributor_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.tb_Distributor_ID);
            this.pnl_Header.Controls.Add(this.btn_Search);
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lb_Single_Distributor_Report);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 50);
            this.pnl_Header.TabIndex = 6;
            // 
            // tb_Distributor_ID
            // 
            this.tb_Distributor_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Distributor_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_ID.Location = new System.Drawing.Point(409, 11);
            this.tb_Distributor_ID.Name = "tb_Distributor_ID";
            this.tb_Distributor_ID.Size = new System.Drawing.Size(205, 24);
            this.tb_Distributor_ID.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(641, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(146, 32);
            this.btn_Search.TabIndex = 51;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_X
            // 
            this.btn_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_X.BackColor = System.Drawing.Color.Black;
            this.btn_X.FlatAppearance.BorderSize = 0;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.Red;
            this.btn_X.Location = new System.Drawing.Point(824, 6);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(43, 33);
            this.btn_X.TabIndex = 1;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // lb_Single_Distributor_Report
            // 
            this.lb_Single_Distributor_Report.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Single_Distributor_Report.AutoSize = true;
            this.lb_Single_Distributor_Report.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Single_Distributor_Report.Location = new System.Drawing.Point(12, 9);
            this.lb_Single_Distributor_Report.Name = "lb_Single_Distributor_Report";
            this.lb_Single_Distributor_Report.Size = new System.Drawing.Size(345, 32);
            this.lb_Single_Distributor_Report.TabIndex = 0;
            this.lb_Single_Distributor_Report.Text = "Single Distributor Report";
            // 
            // Crv_Single_Distributor_Report
            // 
            this.Crv_Single_Distributor_Report.ActiveViewIndex = -1;
            this.Crv_Single_Distributor_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Single_Distributor_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Single_Distributor_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Single_Distributor_Report.Location = new System.Drawing.Point(0, 50);
            this.Crv_Single_Distributor_Report.Name = "Crv_Single_Distributor_Report";
            this.Crv_Single_Distributor_Report.Size = new System.Drawing.Size(874, 411);
            this.Crv_Single_Distributor_Report.TabIndex = 7;
            this.Crv_Single_Distributor_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Single_Distributor_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.ControlBox = false;
            this.Controls.Add(this.Crv_Single_Distributor_Report);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Single_Distributor_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single Distributor Report";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.TextBox tb_Distributor_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lb_Single_Distributor_Report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Single_Distributor_Report;
    }
}