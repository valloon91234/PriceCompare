using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Form_EnterPassword : Form
    {
        public const String PASSWORD_DEFAULT = "binance";
        private int InvalidInputCount = 0;
        const int INVALID_INPUT_COUNT_MAX = 3;

        public Form_EnterPassword()
        {
            InitializeComponent();
        }

        private void Form_EnterPassword_Load(object sender, EventArgs e)
        {
            InvalidInputCount = 0;
            textBox_Password.Text = "";
#if DEBUG
            textBox_Password.Text = PASSWORD_DEFAULT;
#endif
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String input = textBox_Password.Text;
                if (input == "")
                {
                    MessageBox.Show("Enter password.", "Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (input == PASSWORD_DEFAULT)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                    return;
                }
                InvalidInputCount++;
                if (InvalidInputCount >= INVALID_INPUT_COUNT_MAX)
                {
                    MessageBox.Show("You typed the wrong password 3 times. Now will be closed.", "Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password. Pleas try again.", "Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Password.Focus();
                    textBox_Password.SelectAll();
                }
            }
        }

        private void Form_EnterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
