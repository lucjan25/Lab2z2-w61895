using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            float fontSize = tbText.Font.Size;
            FontStyle style = FontStyle.Regular;
            if (rdoSmall.Checked)
            {
                fontSize = 8f;
            }
            if (rdoBig.Checked)
            {
                fontSize = 14f;
            }
            if (rdoVBig.Checked)
            {
                fontSize = 20f;
            }
            if (cbBold.Checked)
            {
                style = style | FontStyle.Bold;
            }
            if (cbItalic.Checked)
            {
                style = style | FontStyle.Italic;
            }
            if (cbUnderline.Checked)
            {
                style = style | FontStyle.Underline;
            }
            tbText.Font = new Font(tbText.Font.Name, fontSize, style, tbText.Font.Unit);
            if (rdoRed.Checked)
            {
                tbText.ForeColor = Color.Red;
            }
            if (rdoBlue.Checked)
            {
                tbText.ForeColor = Color.Blue;
            }
            if (rdoOrange.Checked)
            {
                tbText.ForeColor = Color.Orange;
            }
        }
    }
}
