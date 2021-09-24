namespace Jewellery_Shop_Management_System
{
    partial class Frm_Bill_Receipt
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rect_Bill_Receipt = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnl_Bill_Receipt = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Other_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Other_Amount = new System.Windows.Forms.Label();
            this.gb_Payment_Mode = new System.Windows.Forms.GroupBox();
            this.rb_Online = new System.Windows.Forms.RadioButton();
            this.rb_Card = new System.Windows.Forms.RadioButton();
            this.rb_Cash = new System.Windows.Forms.RadioButton();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.panel_Header_Receipt = new System.Windows.Forms.Panel();
            this.lbl_Bill_Receipt = new System.Windows.Forms.Label();
            this.pnl_Bill_Receipt.SuspendLayout();
            this.gb_Payment_Mode.SuspendLayout();
            this.panel_Header_Receipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rect_Bill_Receipt});
            this.shapeContainer1.Size = new System.Drawing.Size(861, 601);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rect_Bill_Receipt
            // 
            this.rect_Bill_Receipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rect_Bill_Receipt.BorderColor = System.Drawing.Color.White;
            this.rect_Bill_Receipt.Location = new System.Drawing.Point(191, 16);
            this.rect_Bill_Receipt.Name = "rect_Bill_Receipt";
            this.rect_Bill_Receipt.Size = new System.Drawing.Size(457, 565);
            // 
            // pnl_Bill_Receipt
            // 
            this.pnl_Bill_Receipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Bill_Receipt.Controls.Add(this.btn_Close);
            this.pnl_Bill_Receipt.Controls.Add(this.btn_Save);
            this.pnl_Bill_Receipt.Controls.Add(this.tb_Other_Amount);
            this.pnl_Bill_Receipt.Controls.Add(this.lbl_Other_Amount);
            this.pnl_Bill_Receipt.Controls.Add(this.gb_Payment_Mode);
            this.pnl_Bill_Receipt.Controls.Add(this.lbl_Payment_Mode);
            this.pnl_Bill_Receipt.Controls.Add(this.tb_Total_Amount);
            this.pnl_Bill_Receipt.Controls.Add(this.lbl_Total_Amount);
            this.pnl_Bill_Receipt.Controls.Add(this.tb_GST);
            this.pnl_Bill_Receipt.Controls.Add(this.lbl_GST);
            this.pnl_Bill_Receipt.Controls.Add(this.tb_Customer_ID);
            this.pnl_Bill_Receipt.Controls.Add(this.lbl_Customer_ID);
            this.pnl_Bill_Receipt.Controls.Add(this.panel_Header_Receipt);
            this.pnl_Bill_Receipt.Location = new System.Drawing.Point(208, 29);
            this.pnl_Bill_Receipt.Name = "pnl_Bill_Receipt";
            this.pnl_Bill_Receipt.Size = new System.Drawing.Size(428, 539);
            this.pnl_Bill_Receipt.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(266, 421);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(111, 31);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(39, 421);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 31);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "Save && Print";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Other_Amount
            // 
            this.tb_Other_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Other_Amount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Other_Amount.Location = new System.Drawing.Point(160, 207);
            this.tb_Other_Amount.MaxLength = 8;
            this.tb_Other_Amount.Name = "tb_Other_Amount";
            this.tb_Other_Amount.Size = new System.Drawing.Size(239, 26);
            this.tb_Other_Amount.TabIndex = 22;
            this.tb_Other_Amount.Leave += new System.EventHandler(this.tb_Other_Amount_Leave);
            // 
            // lbl_Other_Amount
            // 
            this.lbl_Other_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Other_Amount.AutoSize = true;
            this.lbl_Other_Amount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Other_Amount.Location = new System.Drawing.Point(16, 207);
            this.lbl_Other_Amount.Name = "lbl_Other_Amount";
            this.lbl_Other_Amount.Size = new System.Drawing.Size(134, 22);
            this.lbl_Other_Amount.TabIndex = 20;
            this.lbl_Other_Amount.Text = "Other Amount :";
            // 
            // gb_Payment_Mode
            // 
            this.gb_Payment_Mode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Payment_Mode.Controls.Add(this.rb_Online);
            this.gb_Payment_Mode.Controls.Add(this.rb_Card);
            this.gb_Payment_Mode.Controls.Add(this.rb_Cash);
            this.gb_Payment_Mode.Location = new System.Drawing.Point(160, 311);
            this.gb_Payment_Mode.Name = "gb_Payment_Mode";
            this.gb_Payment_Mode.Size = new System.Drawing.Size(262, 43);
            this.gb_Payment_Mode.TabIndex = 19;
            this.gb_Payment_Mode.TabStop = false;
            // 
            // rb_Online
            // 
            this.rb_Online.AutoSize = true;
            this.rb_Online.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Online.Location = new System.Drawing.Point(180, 16);
            this.rb_Online.Name = "rb_Online";
            this.rb_Online.Size = new System.Drawing.Size(64, 20);
            this.rb_Online.TabIndex = 2;
            this.rb_Online.TabStop = true;
            this.rb_Online.Text = "Online";
            this.rb_Online.UseVisualStyleBackColor = true;
            // 
            // rb_Card
            // 
            this.rb_Card.AutoSize = true;
            this.rb_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Card.Location = new System.Drawing.Point(106, 15);
            this.rb_Card.Name = "rb_Card";
            this.rb_Card.Size = new System.Drawing.Size(55, 20);
            this.rb_Card.TabIndex = 1;
            this.rb_Card.TabStop = true;
            this.rb_Card.Text = "Card";
            this.rb_Card.UseVisualStyleBackColor = true;
            // 
            // rb_Cash
            // 
            this.rb_Cash.AutoSize = true;
            this.rb_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Cash.Location = new System.Drawing.Point(24, 14);
            this.rb_Cash.Name = "rb_Cash";
            this.rb_Cash.Size = new System.Drawing.Size(57, 20);
            this.rb_Cash.TabIndex = 0;
            this.rb_Cash.TabStop = true;
            this.rb_Cash.Text = "Cash";
            this.rb_Cash.UseVisualStyleBackColor = true;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(16, 325);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(141, 22);
            this.lbl_Payment_Mode.TabIndex = 18;
            this.lbl_Payment_Mode.Text = "Payment Mode :";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(162, 260);
            this.tb_Total_Amount.MaxLength = 5;
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(237, 26);
            this.tb_Total_Amount.TabIndex = 17;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(16, 264);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(128, 22);
            this.lbl_Total_Amount.TabIndex = 16;
            this.lbl_Total_Amount.Text = "Total Amount :";
            // 
            // tb_GST
            // 
            this.tb_GST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_GST.Enabled = false;
            this.tb_GST.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(162, 150);
            this.tb_GST.MaxLength = 5;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(237, 26);
            this.tb_GST.TabIndex = 15;
            this.tb_GST.Text = "3";
            // 
            // lbl_GST
            // 
            this.lbl_GST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(16, 154);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(86, 22);
            this.lbl_GST.TabIndex = 14;
            this.lbl_GST.Text = "GST (%) :";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(162, 95);
            this.tb_Customer_ID.MaxLength = 5;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(237, 26);
            this.tb_Customer_ID.TabIndex = 4;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(16, 95);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(121, 22);
            this.lbl_Customer_ID.TabIndex = 5;
            this.lbl_Customer_ID.Text = "Customer ID :";
            // 
            // panel_Header_Receipt
            // 
            this.panel_Header_Receipt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_Header_Receipt.Controls.Add(this.lbl_Bill_Receipt);
            this.panel_Header_Receipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header_Receipt.Location = new System.Drawing.Point(0, 0);
            this.panel_Header_Receipt.Name = "panel_Header_Receipt";
            this.panel_Header_Receipt.Size = new System.Drawing.Size(428, 40);
            this.panel_Header_Receipt.TabIndex = 0;
            // 
            // lbl_Bill_Receipt
            // 
            this.lbl_Bill_Receipt.AutoSize = true;
            this.lbl_Bill_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Receipt.ForeColor = System.Drawing.Color.White;
            this.lbl_Bill_Receipt.Location = new System.Drawing.Point(158, 10);
            this.lbl_Bill_Receipt.Name = "lbl_Bill_Receipt";
            this.lbl_Bill_Receipt.Size = new System.Drawing.Size(88, 20);
            this.lbl_Bill_Receipt.TabIndex = 0;
            this.lbl_Bill_Receipt.Text = "Bill Receipt";
            // 
            // Frm_Bill_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(861, 601);
            this.Controls.Add(this.pnl_Bill_Receipt);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Bill_Receipt";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Receipt";
            this.Load += new System.EventHandler(this.Frm_Bill_Receipt_Load);
            this.pnl_Bill_Receipt.ResumeLayout(false);
            this.pnl_Bill_Receipt.PerformLayout();
            this.gb_Payment_Mode.ResumeLayout(false);
            this.gb_Payment_Mode.PerformLayout();
            this.panel_Header_Receipt.ResumeLayout(false);
            this.panel_Header_Receipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_Bill_Receipt;
        private System.Windows.Forms.Panel pnl_Bill_Receipt;
        private System.Windows.Forms.Panel panel_Header_Receipt;
        private System.Windows.Forms.Label lbl_Bill_Receipt;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Other_Amount;
        private System.Windows.Forms.Label lbl_Other_Amount;
        private System.Windows.Forms.GroupBox gb_Payment_Mode;
        private System.Windows.Forms.RadioButton rb_Online;
        private System.Windows.Forms.RadioButton rb_Card;
        private System.Windows.Forms.RadioButton rb_Cash;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;

    }
}