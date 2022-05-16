using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Ahorro
{
   public class Cuenta_Bancaria
   {

        public decimal Resultado = 0;
        public int NoRegistros { get; set; }
        double Interes { get; set; }
        string Composicion { get; set; }
        int Periodo { get; set; }
        decimal DepositoInicial { get; set; }
        decimal DepositoAhorro { get; set; } 

        public Cuenta_Bancaria() 
        {
          
        }
        // EL METODO MANDA A LLAMAR A LA CLASE CALCULAR CUENTA DONDE SE REALIZA LA OPERACION DESIGNADA 
        public decimal CalcularIngresos(double interes, string composicion, int periodo, decimal depositoInicial, decimal depositoAhorro)
        {
            Interes = interes;
            Composicion = composicion;
            Periodo = periodo;
            DepositoAhorro = depositoAhorro;
            DepositoInicial = depositoInicial;
            // SI LA COMPOSICION DEL CLIENTE ES MENSUAL LA TASA DE INTERES SE DIVIDE ENTRE LOS MESES PARA CALCULAR 
            double Tinteres;
            int TimePeriodo;
            Tinteres = MetodosLibreria.Metodos.TasaInteres(Composicion, Interes);
            if (Composicion=="ANUAL")
            {
                Resultado = CuentaAhorroAnual(Tinteres);
            }
            else if(Composicion == "MENSUAL")
            {
                TimePeriodo = MetodosLibreria.Metodos.Mensual(Periodo);
                Resultado = SaldoTotal(DepositoInicial, DepositoAhorro, TimePeriodo, Tinteres);
            }
            else
            {
                TimePeriodo = MetodosLibreria.Metodos.Semestral(Periodo);
                Resultado = SaldoTotal(DepositoInicial, DepositoAhorro, TimePeriodo, Tinteres);
            }

            return Resultado;

        }

     
        public decimal CuentaAhorroAnual(double TasaIntere)
        {
            decimal Total = 0;
            switch (Periodo)
            {
                case 1:
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Periodo, TasaIntere);
                    break;
                case 2:
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Periodo, TasaIntere);
                    break;
                case 3:
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Periodo, TasaIntere);
                    break;
                case 4:
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Periodo, TasaIntere);
                    break;
                case 5:
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Periodo, TasaIntere);
                    break;
            }
            return Total;
        }
        public List<Variables> ListCuenta { get; set; }
        public decimal SaldoTotal(decimal DepositoInicial, decimal DepositoAhorro, int Mensualidades, double Interes)
        {
           ListCuenta = new List<Variables>();
            decimal TasaInt = 0;
            decimal suma = 0;
            decimal valor = 0;
            NoRegistros = Mensualidades;
            for (int i = 1; i <= Mensualidades; i++)
            {
                valor += DepositoInicial + DepositoAhorro + TasaInt;
                TasaInt = valor * Convert.ToDecimal(Interes);
                suma = valor + TasaInt;
                ListCuenta.Add(new Variables(){MES=i.ToString(), SALDO_DEPOSISTO=("$ " + Math.Round(valor,2)), TASA_INTERES=("$ " + Math.Round(TasaInt,2)), SALDO_MAS_INTERES=("$ " + Math.Round(suma,2)) });
                DepositoInicial = 0;
            }
            return Math.Round(suma, 4);
        }
    }
}
