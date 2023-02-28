namespace KeyGen
{
    partial class Form_EnterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EnterPassword));
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(12, 12);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '●';
            this.textBox_Password.Size = new System.Drawing.Size(169, 27);
            this.textBox_Password.TabIndex = 0;
            this.textBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
            // 
            // Form_EnterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(193, 51);
            this.Controls.Add(this.textBox_Password);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_EnterPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_EnterPassword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_EnterPassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Password;
    }
}