using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_Ahorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal DepositoInicial = Convert.ToDecimal(MontoInicial.Text);
                decimal DepositoAhorro = Convert.ToDecimal(CuotaTxt.Text);
                int Periodo = Convert.ToInt32(PeriodoBox.Value);
                string Composicion = ComposicionBox.Text;
                double PorcentajeIntere = Convert.ToDouble(InteresTxt.Text);
                Cuenta_Bancaria cuenta_Bancaria = new Cuenta_Bancaria();
                // CALCULAR INGRESOS ES EL SALDO TOTAL DE SU CUENTA DE AHORRO 
                // ENVIAMOS LOS PARAMENTROS DE PORCENTANJE , LA COMPOSICION , EL P     wERIDO Y LOS DEPOSISTOS 
               var Resultado=  cuenta_Bancaria.CalcularIngresos(PorcentajeIntere, Composicion, Periodo, DepositoInicial, DepositoAhorro);
                int no = cuenta_Bancaria.NoRegistros;
                dataGV.DataSource = cuenta_Bancaria.ListCuenta;
                SaldoFinal_Label.Text = "$ " + Math.Round(Resultado, 2).ToString();
                Incial_Label.Text = "$ " + Math.Round(DepositoInicial, 2).ToString();
                Interes_Label.Text = Math.Round(PorcentajeIntere, 2).ToString() + " % ";
                NombreLabel.Text = NombreTxt.Text;
            }
            catch (Exception)
            {
                ResetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuotaTxt.Text = "00.00";

            Incial_Label.Text = "$ 00.00";
            MontoInicial.Text = "00.00";

            SaldoFinal_Label.Text = "$ 00.00";

            Interes_Label.Text = "0 %";
            InteresTxt.Text = "0";

            dataGV.DataSource = 0;
        }
    }
}
