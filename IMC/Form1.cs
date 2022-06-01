namespace IMC
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
            string textoPeso = txtPeso.Text;
            double peso = double.Parse(txtPeso.Text);

            string textoAltura = txtAltura.Text;
            double altura = double.Parse(txtAltura.Text);

            double imc = peso / (altura* altura);

            MessageBox.Show("El IMC es: " + imc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}