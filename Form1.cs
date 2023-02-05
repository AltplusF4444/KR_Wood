namespace KR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();
                Hide();
            }
            else
            {
                Form2 frm = new Form2();
                frm.Show();
                Hide();

            }
        }
    }
}