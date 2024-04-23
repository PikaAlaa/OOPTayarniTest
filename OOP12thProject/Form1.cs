namespace OOP12thProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6=new Form6();
            form6.ShowDialog();
        }
    }
}
