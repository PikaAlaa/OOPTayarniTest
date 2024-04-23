using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP12thProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            FullName.KeyDown += TextBox_KeyDown;
            Email.KeyDown += TextBox_KeyDown;
            Password.KeyDown += TextBox_KeyDown;
            NationalId.KeyDown += TextBox_KeyDown;
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        CLient c = new CLient();
        private void FullName_TextChanged(object sender, EventArgs e)
        {
            c.ClientName = FullName.Text;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            c.ClientMail = Email.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            c.ClientPassword = Password.Text;
        }

        private void NationalId_TextChanged(object sender, EventArgs e)
        {
            c.ClientID = NationalId.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!c.IsValid())
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            // If all checks pass, proceed to Form5
            Form5 form5 = new Form5();
            form5.ClientName = c.ClientName;
            form5.ShowDialog();
        }
    }
    }
