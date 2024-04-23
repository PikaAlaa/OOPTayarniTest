using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP12thProject
{
    public partial class Form5 : Form
    {
        public string ClientName { get; set; }
        public Form5()
        {
            InitializeComponent();
            label2.Text = ClientName;

        }

        private void AvailableTrips_Click(object sender, EventArgs e)
        {

        }

        private void Account_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
