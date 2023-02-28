namespace PriceCompare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Notify = new System.Windows.Forms.NumericUpDown();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label_SwapButton = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Interval = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Notify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_Notify);
            this.splitContainer1.Panel1.Controls.Add(this.button_Refresh);
            this.splitContainer1.Panel1.Controls.Add(this.label_SwapButton);
            this.splitContainer1.Panel1.Controls.Add(this.button_Stop);
            this.splitContainer1.Panel1.Controls.Add(this.button_Start);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown_Interval);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(933, 443);
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(796, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Notify (%):";
            // 
            // numericUpDown_Notify
            // 
            this.numericUpDown_Notify.DecimalPlaces = 1;
            this.numericUpDown_Notify.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_Notify.Location = new System.Drawing.Point(873, 13);
            this.numericUpDown_Notify.Name = "numericUpDown_Notify";
            this.numericUpDown_Notify.Size = new System.Drawing.Size(46, 26);
            this.numericUpDown_Notify.TabIndex = 12;
            this.numericUpDown_Notify.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(644, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(125, 28);
            this.button_Refresh.TabIndex = 11;
            this.button_Refresh.Text = "🗘 Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label_SwapButton
            // 
            this.label_SwapButton.AutoSize = true;
            this.label_SwapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_SwapButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SwapButton.ForeColor = System.Drawing.Color.White;
            this.label_SwapButton.Location = new System.Drawing.Point(144, 14);
            this.label_SwapButton.Name = "label_SwapButton";
            this.label_SwapButton.Size = new System.Drawing.Size(24, 22);
            this.label_SwapButton.TabIndex = 10;
            this.label_SwapButton.Text = "⇄";
            this.label_SwapButton.Click += new System.EventHandler(this.label_SwapButton_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(573, 12);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(65, 28);
            this.button_Stop.TabIndex = 8;
            this.button_Stop.Text = "⏹ Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(506, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(61, 28);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "▶️  Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Interval Seconds:";
            // 
            // numericUpDown_Interval
            // 
            this.numericUpDown_Interval.Location = new System.Drawing.Point(454, 13);
            this.numericUpDown_Interval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Interval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Interval.Name = "numericUpDown_Interval";
            this.numericUpDown_Interval.Size = new System.Drawing.Size(46, 26);
            this.numericUpDown_Interval.TabIndex = 5;
            this.numericUpDown_Interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Interval.ValueChanged += new System.EventHandler(this.numericUpDown_Interval_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 26);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Crypto Price Comparison";
            this.notifyIcon1.Visible = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(933, 389);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 443);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Crypto Price Comparison";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Notify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Interval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Interval;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_SwapButton;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Notify;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

