namespace Jewellery_Shop_Management_System
{
    partial class Frm_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Start));
            this.btn_Login_Here = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login_Here
            // 
            this.btn_Login_Here.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Login_Here.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login_Here.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login_Here.FlatAppearance.BorderSize = 0;
            this.btn_Login_Here.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Login_Here.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Login_Here.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login_Here.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_Here.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Login_Here.Location = new System.Drawing.Point(257, 397);
            this.btn_Login_Here.Name = "btn_Login_Here";
            this.btn_Login_Here.Size = new System.Drawing.Size(266, 44);
            this.btn_Login_Here.TabIndex = 0;
            this.btn_Login_Here.Text = "Click Here to Login";
            this.btn_Login_Here.UseVisualStyleBackColor = false;
            this.btn_Login_Here.Click += new System.EventHandler(this.btn_Login_Here_Click);
            // 
            // Frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 493);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Login_Here);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Start";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login_Here;
    }
}

