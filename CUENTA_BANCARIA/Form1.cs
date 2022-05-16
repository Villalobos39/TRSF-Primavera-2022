using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTA_BANCARIA
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
                int Periodo =Convert.ToInt32(PeriodoBox.Value);
                string Composicion = ComposicionBox.Text;
                double PorcentajeIntere = Convert.ToDouble(InteresTxt.Text);
                Cuenta_Bancaria cuenta_Bancaria = new Cuenta_Bancaria(PorcentajeIntere, Composicion, Periodo, DepositoInicial, DepositoAhorro);
                // CALCULAR INGRESOS ES EL SALDO TOTAL DE SU CUENTA DE AHORRO 
                // ENVIAMOS LOS PARAMENTROS DE PORCENTANJE , LA COMPOSICION , EL P     wERIDO Y LOS DEPOSISTOS 
                cuenta_Bancaria.CalcularIngresos();
                int no= cuenta_Bancaria.NoRegistros;
                dataGV.DataSource = cuenta_Bancaria.ListCuenta;
                SaldoFinal_Label.Text = "$ " + Math.Round(cuenta_Bancaria.Resultado,2).ToString();
                Incial_Label.Text = "$ " +  Math.Round(DepositoInicial, 2).ToString();
                Interes_Label.Text = Math.Round(PorcentajeIntere, 2).ToString() +" % ";
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

            dataGV.DataSource=0;
        }
    }
}


//private void MostrarLista(List<Variables> lista)
//{
//    int cont = 1;
//    foreach (var item in lista)
//    {
//        int n = dataGV.Rows.Add(lista.Count);
//        dataGV.Rows[n].Cells[0].Value = cont++.ToString();
//        dataGV.Rows[n].Cells[1].Value = "$" + Math.Round(item.Saldo, 2).ToString();
//        dataGV.Rows[n].Cells[2].Value = "$" + Math.Round(item.TasaInteres, 2).ToString();  // Math.Round(valor, 4).ToString();
//        dataGV.Rows[n].Cells[3].Value = "$" + Math.Round(item.SaldoInteres, 2).ToString();
//    }
//}


//ListCuenta.Add(new IVariables() { Saldo = valor, TasaInteres = TasaInt, SaldoInteres = suma });

//for (int i = 1; i <= final.ListCuenta.Count; i++)
//{
//    int n = dataGV.Rows.Add(final.NoRegistros);
//    dataGV.Rows[n].Cells[0].Value = contador++.ToString();
//    dataGV.Rows[n].Cells[1].Value = final.ListCuenta[i].Saldo.ToString();
//    dataGV.Rows[n].Cells[2].Value = final.ListCuenta[i].TasaInteres.ToString();
//    dataGV.Rows[n].Cells[3].Value = final.ListCuenta[i].SaldoInteres.ToString();
//    i++;
//}


//for (int i = 1; i <= lista.Count; i++)
//{
//    int n = dataGV.Rows.Add(lista.Count);
//    dataGV.Rows[n].Cells[0].Value = cont++.ToString();
//    dataGV.Rows[n].Cells[1].Value = "$" + Math.Round(lista[i].Saldo, 2).ToString();
//    dataGV.Rows[n].Cells[2].Value = "$" + Math.Round(lista[i].TasaInteres, 2).ToString();  // Math.Round(valor, 4).ToString();
//    dataGV.Rows[n].Cells[3].Value = "$" + Math.Round(lista[i].SaldoInteres, 2).ToString();
//}