namespace lote
{
    public partial class Form1 : Form
    {
        //private TextBox txtNumero;
        //private TextBox txtResultado;
        private string opcionSeleccionada;
        private string opcionSeleccionada2;
        private double valorpip = 0;
        private double valorfactor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada2 == "1/2")
            {
                valorfactor = 2;
            }
            else if (opcionSeleccionada2 == "1/3")
            {
                valorfactor = 3;
            }

            if (opcionSeleccionada == "EUR/USD")
            {
                valorpip = 1;
            }
            else if (opcionSeleccionada == "EUR/AUD")
            {
                valorpip = 6.86050;
            }

            if (double.TryParse(txtCapital.Text, out double capital) && double.TryParse(txtPorcentaje.Text, out double porcentaje) && double.TryParse(txtStoploss.Text, out double stoploss) && valorpip != 0 && valorfactor != 0)
            {
                double Usd = capital * (porcentaje / 100);
                double resultado = Usd / (stoploss * valorpip);
                txtResultado.Text = resultado.ToString() + " Lote";
                double resultadoProfit = stoploss * valorfactor;
                txtTakeProfit.Text = resultadoProfit.ToString() + " Pips";
                double ganancia = resultadoProfit * resultado;
                txtGanancia.Text = ganancia.ToString() + " USD";
                double perdida = stoploss * resultado;
                txtPerdida.Text = perdida.ToString() + " USD";

            }
            else
            {
                MessageBox.Show("Ingrese un número válido en el TextBox.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeleccionada = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeleccionada2 = comboBox2.SelectedItem.ToString();
        }


    }
}
