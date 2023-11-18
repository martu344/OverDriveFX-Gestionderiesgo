using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora_de_Gestion
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
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(opcionSeleccionada))
            {
                MessageBox.Show("Seleccione un par de divisas.");
               return;
            }

            if (string.IsNullOrEmpty(opcionSeleccionada2))
            {
                MessageBox.Show("Seleccione un factor RR.");
                return;
            }
            if (string.IsNullOrEmpty(txtCapital.Text))
            {
                MessageBox.Show("Especifique el capital invertido.");
                return;
            }
            if (string.IsNullOrEmpty(txtStoploss.Text))
            {
                MessageBox.Show("Especifique el Stoploss.");
                return;
            }
            if (string.IsNullOrEmpty(txtPorcentaje.Text))
            {
                MessageBox.Show("Especifique el porcentaje a arriesgar.");
                return;
            }
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
                valorpip = 10;
            }
            else if (opcionSeleccionada == "EUR/AUD")
            {
                valorpip = 6.86050;
            }

            if (double.TryParse(txtCapital.Text, out double capital) && double.TryParse(txtPorcentaje.Text, out double porcentaje)
                && double.TryParse(txtStoploss.Text, out double stoploss) && valorpip != 0 && valorfactor != 0)
            {
                double Usd = capital * (porcentaje / 100);
                double resultado = Usd / (stoploss * valorpip);
                txtResultado.Text = resultado.ToString("N3") + " Lote";
                double resultadoProfit = stoploss * valorfactor;
                txtTakeProfit.Text = resultadoProfit.ToString("N2") + " Pips";
                double ganancia = resultadoProfit * resultado * valorpip;
                txtGanancia.Text = ganancia.ToString("N2") + " USD";
                double perdida = stoploss * resultado * valorpip;
                txtPerdida.Text = perdida.ToString("N2") + " USD";
                //txtPerdida.Text = valorpip.ToString("N2") + " USD";
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/martu344");
        }
    }
}
