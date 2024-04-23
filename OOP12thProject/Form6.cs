using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP12thProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            NamEma.KeyDown += TextBox_KeyDown;
            PassEmp.KeyDown += TextBox_KeyDown;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control currentControl = (Control)sender;
                int currentIndex = currentControl.TabIndex;
                Control nextControl = this.GetNextControl(currentControl, true);
                if (nextControl != null && nextControl is TextBox)
                {
                    nextControl.Focus();
                }
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void NamEma_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassEmp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
