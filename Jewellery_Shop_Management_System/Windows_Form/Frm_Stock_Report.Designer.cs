namespace Jewellery_Shop_Management_System.Windows_Form
{
    partial class Frm_Stock_Report
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
            this.lbl_Stock_Report = new System.Windows.Forms.Label();
            this.Crv_Stock_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.btn_X);
            this.pnl_Header.Controls.Add(this.lbl_Stock_Report);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(874, 50);
            this.pnl_Header.TabIndex = 8;
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
            // lbl_Stock_Report
            // 
            this.lbl_Stock_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Stock_Report.AutoSize = true;
            this.lbl_Stock_Report.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Report.Location = new System.Drawing.Point(315, 9);
            this.lbl_Stock_Report.Name = "lbl_Stock_Report";
            this.lbl_Stock_Report.Size = new System.Drawing.Size(186, 32);
            this.lbl_Stock_Report.TabIndex = 0;
            this.lbl_Stock_Report.Text = "Stock Report";
            // 
            // Crv_Stock_Report
            // 
            this.Crv_Stock_Report.ActiveViewIndex = -1;
            this.Crv_Stock_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Stock_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Stock_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Stock_Report.Location = new System.Drawing.Point(0, 50);
            this.Crv_Stock_Report.Name = "Crv_Stock_Report";
            this.Crv_Stock_Report.Size = new System.Drawing.Size(874, 411);
            this.Crv_Stock_Report.TabIndex = 9;
            this.Crv_Stock_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.Controls.Add(this.Crv_Stock_Report);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Frm_Stock_Report";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.Frm_Stock_Report_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Label lbl_Stock_Report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Stock_Report;
    }
}