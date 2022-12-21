using Herramientas;

namespace UsandoDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones op1 = new Operaciones();

            op1.num1 = Convert.ToInt32(textBox_Num1.Text);
            op1.num2 = Convert.ToInt32(textBox_Num2.Text);

            op1.Sumar();

            textBox_Resultado.Text= op1.resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operaciones op1 = new Operaciones();

            op1.num1 = Convert.ToInt32(textBox_Num1.Text);
            op1.num2 = Convert.ToInt32(textBox_Num2.Text);

            op1.Restar();

            textBox_Resultado.Text = op1.resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operaciones op1 = new Operaciones();

            op1.num1 = Convert.ToInt32(textBox_Num1.Text);
            op1.num2 = Convert.ToInt32(textBox_Num2.Text);

            op1.Multiplicar();

            textBox_Resultado.Text = op1.resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operaciones op1 = new Operaciones();

            op1.num1 = Convert.ToInt32(textBox_Num1.Text);
            op1.num2 = Convert.ToInt32(textBox_Num2.Text);

            op1.Dividir();

            textBox_Resultado.Text = op1.resultado.ToString();
        }
    }
}