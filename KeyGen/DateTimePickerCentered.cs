using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class DateTimePickerCentered : DateTimePicker
    {
        public DateTimePickerCentered()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
        }
    }
}
