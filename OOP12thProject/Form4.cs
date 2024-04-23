using System;
using System.Windows.Forms;
using System.Linq;


namespace OOP12thProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            EmailName.KeyDown += TextBox_KeyDown;
            PassLog.KeyDown += TextBox_KeyDown;
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

        public static CLient user = new CLient();

        private void EmailName_TextChanged(object sender, EventArgs e)
        {
            user.ClientMail = EmailName.Text;
            user.ClientName = EmailName.Text;
        }

        private void PassLog_TextChanged(object sender, EventArgs e)
        {
            user.ClientPassword = PassLog.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!user.isValidSign())
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            Form5 form5 = new Form5();
            form5.ClientName = user.ClientName;
            form5.ShowDialog();
        }
    }
}
