using System.Security.Cryptography.X509Certificates;

namespace Formulario_de_càlculos
{
    public partial class Form1 : Form
    {

        private TextBox textBox3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_valor1.Clear();
            txt_valor2.Clear();
            txt_resultado.Clear();
            txt_resta.Clear();
            txt_dvision.Clear();
            txt_multiplicacion.Clear();

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txt_valor1.Text);
            double valor2 = Convert.ToDouble(txt_valor2.Text);

            // Calcular la suma
            double suma = valor1 + valor2;

            // Calcular la resta
            double resta = valor1 - valor2;

            //Calcular la division
            double division = valor1 / valor2;

            // Calcular la multiplicación
            double multiplicacion = valor1 * valor2;


            // Mostrar los resultados en los cuadros de texto correspondientes
            txt_resultado.Text = suma.ToString();
            txt_resta.Text = resta.ToString();
            txt_dvision.Text = multiplicacion.ToString();
            txt_multiplicacion.Text = division.ToString();
           
        }
    }
}