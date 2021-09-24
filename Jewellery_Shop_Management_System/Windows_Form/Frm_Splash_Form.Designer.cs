namespace Jewellery_Shop_Management_System
{
    partial class Frm_Splash_Form
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
            this.pb_Alankar_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Application = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.pb_Loading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Alankar_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Alankar_Image
            // 
            this.pb_Alankar_Image.Image = global::Jewellery_Shop_Management_System.Properties.Resources.jewellery_gold_wedding_indian;
            this.pb_Alankar_Image.Location = new System.Drawing.Point(0, 56);
            this.pb_Alankar_Image.Name = "pb_Alankar_Image";
            this.pb_Alankar_Image.Size = new System.Drawing.Size(782, 378);
            this.pb_Alankar_Image.TabIndex = 0;
            this.pb_Alankar_Image.TabStop = false;
            // 
            // lbl_Application
            // 
            this.lbl_Application.AutoSize = true;
            this.lbl_Application.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Application.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Application.Location = new System.Drawing.Point(129, 13);
            this.lbl_Application.Name = "lbl_Application";
            this.lbl_Application.Size = new System.Drawing.Size(487, 35);
            this.lbl_Application.TabIndex = 1;
            this.lbl_Application.Text = "Jewellery Shop Application";
            // 
            // lbl_Note
            // 
            this.lbl_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(183, 446);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(232, 24);
            this.lbl_Note.TabIndex = 7;
            this.lbl_Note.Text = "Application Is Loading...";
            // 
            // pb_Loading
            // 
            this.pb_Loading.ForeColor = System.Drawing.Color.SpringGreen;
            this.pb_Loading.Location = new System.Drawing.Point(0, 479);
            this.pb_Loading.Name = "pb_Loading";
            this.pb_Loading.Size = new System.Drawing.Size(782, 34);
            this.pb_Loading.Step = 1;
            this.pb_Loading.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Frm_Splash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 518);
            this.ControlBox = false;
            this.Controls.Add(this.pb_Loading);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_Application);
            this.Controls.Add(this.pb_Alankar_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Splash_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Form";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Alankar_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Alankar_Image;
        private System.Windows.Forms.Label lbl_Application;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ProgressBar pb_Loading;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;


    }
}

