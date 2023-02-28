using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Form_KeyGen : Form
    {
        public Form_KeyGen()
        {
            InitializeComponent();
        }

        private void Form_KeyGen_Load(object sender, EventArgs e)
        {
            using (var formEnterPassword = new Form_EnterPassword())
            {
                var result = formEnterPassword.ShowDialog();
                if (result != DialogResult.Yes)
                {
                    this.Close();
                }
            }
            if (Debugger.IsAttached)
                textBox_RequestCode.Text = Activator.ExportRequestCode();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            var requestCode = textBox_RequestCode.Text;
            if (!Activator.CheckRequestCode(requestCode))
            {
                textBox_ActivationCode.Text = "";
                MessageBox.Show("Invalid Request Code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            textBox_ActivationCode.Text = Activator.ExportActivationCode(requestCode);
        }
    }
}