namespace Práctica_12
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

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(textBox1.Text);              //Se declaró la variable cal, y su equivalencia que será lo que escribamos.
            if (cal < 3.0) MessageBox.Show(" Reprobado");  //Se declaró el condicional, el cual hará que aparezca un mensaje si el valor cal es menor que 3.
        }
    }
}