namespace KeyGen
{
    partial class Form_KeyGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KeyGen));
            this.textBox_RequestCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ActivationCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_RequestCode
            // 
            this.textBox_RequestCode.Location = new System.Drawing.Point(141, 12);
            this.textBox_RequestCode.Name = "textBox_RequestCode";
            this.textBox_RequestCode.Size = new System.Drawing.Size(167, 27);
            this.textBox_RequestCode.TabIndex = 12;
            this.textBox_RequestCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Request Code:";
            // 
            // textBox_ActivationCode
            // 
            this.textBox_ActivationCode.Location = new System.Drawing.Point(141, 45);
            this.textBox_ActivationCode.Name = "textBox_ActivationCode";
            this.textBox_ActivationCode.ReadOnly = true;
            this.textBox_ActivationCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ActivationCode.Size = new System.Drawing.Size(167, 27);
            this.textBox_ActivationCode.TabIndex = 16;
            this.textBox_ActivationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Activation Code:";
            // 
            // button_Generate
            // 
            this.button_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Generate.Location = new System.Drawing.Point(141, 78);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(168, 32);
            this.button_Generate.TabIndex = 18;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // Form_KeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(321, 120);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ActivationCode);
            this.Controls.Add(this.textBox_RequestCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_KeyGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generator";
            this.Load += new System.EventHandler(this.Form_KeyGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_RequestCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ActivationCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Generate;
    }
}

