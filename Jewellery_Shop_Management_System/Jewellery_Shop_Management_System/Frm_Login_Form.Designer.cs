namespace Jewellery_Shop_Management_System
{
    partial class Frm_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login_Form));
            this.pnl_Login_Screen = new System.Windows.Forms.Panel();
            this.lbl_Login_Screen = new System.Windows.Forms.Label();
            this.btn_X = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lishape_Login_Screen = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rect_Password = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect_Username = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.pnl_Login_Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login_Screen
            // 
            this.pnl_Login_Screen.BackColor = System.Drawing.Color.Blue;
            this.pnl_Login_Screen.Controls.Add(this.lbl_Login_Screen);
            this.pnl_Login_Screen.Controls.Add(this.btn_X);
            this.pnl_Login_Screen.Controls.Add(this.shapeContainer1);
            this.pnl_Login_Screen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Login_Screen.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login_Screen.Name = "pnl_Login_Screen";
            this.pnl_Login_Screen.Size = new System.Drawing.Size(651, 100);
            this.pnl_Login_Screen.TabIndex = 0;
            // 
            // lbl_Login_Screen
            // 
            this.lbl_Login_Screen.AutoSize = true;
            this.lbl_Login_Screen.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Screen.ForeColor = System.Drawing.Color.White;
            this.lbl_Login_Screen.Location = new System.Drawing.Point(12, 26);
            this.lbl_Login_Screen.Name = "lbl_Login_Screen";
            this.lbl_Login_Screen.Size = new System.Drawing.Size(235, 43);
            this.lbl_Login_Screen.TabIndex = 1;
            this.lbl_Login_Screen.Text = "Login Screen";
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.Blue;
            this.btn_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_X.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_X.FlatAppearance.BorderSize = 0;
            this.btn_X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.White;
            this.btn_X.Location = new System.Drawing.Point(559, 26);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(65, 59);
            this.btn_X.TabIndex = 0;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lishape_Login_Screen});
            this.shapeContainer1.Size = new System.Drawing.Size(651, 100);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lishape_Login_Screen
            // 
            this.lishape_Login_Screen.BorderColor = System.Drawing.Color.White;
            this.lishape_Login_Screen.BorderWidth = 2;
            this.lishape_Login_Screen.Name = "lishape_Login_Screen";
            this.lishape_Login_Screen.X1 = 5;
            this.lishape_Login_Screen.X2 = 320;
            this.lishape_Login_Screen.Y1 = 78;
            this.lishape_Login_Screen.Y2 = 78;
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Username.Location = new System.Drawing.Point(205, 181);
            this.tb_Username.MaxLength = 12;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(353, 32);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.Text = "Username";
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Password.Location = new System.Drawing.Point(205, 283);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(353, 32);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "Password";
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rect_Password,
            this.rect_Username});
            this.shapeContainer2.Size = new System.Drawing.Size(651, 505);
            this.shapeContainer2.TabIndex = 3;
            this.shapeContainer2.TabStop = false;
            // 
            // rect_Password
            // 
            this.rect_Password.BorderColor = System.Drawing.Color.White;
            this.rect_Password.CornerRadius = 4;
            this.rect_Password.Location = new System.Drawing.Point(107, 258);
            this.rect_Password.Name = "rect_Password";
            this.rect_Password.Size = new System.Drawing.Size(468, 78);
            // 
            // rect_Username
            // 
            this.rect_Username.BorderColor = System.Drawing.Color.White;
            this.rect_Username.CornerRadius = 4;
            this.rect_Username.Location = new System.Drawing.Point(107, 157);
            this.rect_Username.Name = "rect_Username";
            this.rect_Username.Size = new System.Drawing.Size(466, 82);
            // 
            // pb_Username
            // 
            this.pb_Username.BackColor = System.Drawing.Color.Transparent;
            this.pb_Username.Image = ((System.Drawing.Image)(resources.GetObject("pb_Username.Image")));
            this.pb_Username.Location = new System.Drawing.Point(118, 167);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(64, 58);
            this.pb_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Username.TabIndex = 4;
            this.pb_Username.TabStop = false;
            // 
            // pb_Password
            // 
            this.pb_Password.BackColor = System.Drawing.Color.Transparent;
            this.pb_Password.Image = ((System.Drawing.Image)(resources.GetObject("pb_Password.Image")));
            this.pb_Password.Location = new System.Drawing.Point(118, 270);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(64, 56);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Password.TabIndex = 4;
            this.pb_Password.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Blue;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(118, 422);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(141, 56);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "&Login";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Blue;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Location = new System.Drawing.Point(346, 422);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(150, 56);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "&Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.White;
            this.lbl_Note.Location = new System.Drawing.Point(103, 371);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(54, 24);
            this.lbl_Note.TabIndex = 6;
            this.lbl_Note.Text = "Note";
            // 
            // Frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(651, 505);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pb_Password);
            this.Controls.Add(this.pb_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pnl_Login_Screen);
            this.Controls.Add(this.shapeContainer2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Login_Form";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.frm_Login_Form_Load);
            this.pnl_Login_Screen.ResumeLayout(false);
            this.pnl_Login_Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login_Screen;
        private System.Windows.Forms.Label lbl_Login_Screen;
        private System.Windows.Forms.Button btn_X;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lishape_Login_Screen;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_Password;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_Username;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Note;
    }
}