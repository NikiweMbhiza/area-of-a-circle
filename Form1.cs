namespace area_of_a_circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A;
            double PI =3.14;
            double r;
            r = double.Parse(txtRadius.Text);

            A =( PI * r *r);

            txtArea.Text = A.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}