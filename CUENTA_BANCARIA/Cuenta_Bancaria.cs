using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_BANCARIA
{
    class Cuenta_Bancaria
    {
        SaldoFinal SaldoResult = new SaldoFinal();
        public decimal Resultado = 0;
        public int NoRegistros { get; set; }
        public List<Variables> ListCuenta { get; set; } 
        double Interes { get; set; }
        string Composicion { get; set; }
        int Periodo { get; set; }
        decimal DepositoInicial { get; set; }
        decimal DepositoAhorro { get; set; }

        public Cuenta_Bancaria(double interes, string composicion, int periodo, decimal depositoInicial, decimal depositoAhorro) 
        {
            Interes = interes;
            Composicion = composicion;
            Periodo = periodo;
            DepositoAhorro = depositoAhorro;
            DepositoInicial = depositoInicial;
        }
        // EL METODO MANDA A LLAMAR A LA CLASE CALCULAR CUENTA DONDE SE REALIZA LA OPERACION DESIGNADA 
        public void CalcularIngresos()
        { 
            double TasaIntere;
            // SI LA COMPOSICION DEL CLIENTE ES MENSUAL LA TASA DE INTERES SE DIVIDE ENTRE LOS MESES PARA CALCULAR 
            switch (Composicion)
            {
                case "MENSUAL":
                    TasaIntere = Math.Round((Interes/100) / 12,5);
                    Resultado = CuentaAhorroMensual(TasaIntere);
                    break;
                case "SEMESTRAL":
                    TasaIntere = Math.Round((Interes / 100) / 2, 5);
                    Resultado = CuentaAhorroSemestral(TasaIntere);
                    break;
                case "ANUAL":
                    TasaIntere = Math.Round((Interes / 100), 5);
                    Resultado = CuentaAhorroAnual(TasaIntere);
                    break;
            }
        }

        public decimal CuentaAhorroMensual(double TasaIntere)
        {
            int Mensualidades;
            int Meses = 12;
            decimal Total = 0;

            switch (Periodo)
            {
                case 1:
                    Mensualidades = Meses;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, TasaIntere);
                    break;
                case 2:
                    Mensualidades = Meses * 2;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, TasaIntere);
                    break;
                case 3:
                    Mensualidades = Meses * 3;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, TasaIntere);
                    break;
                case 4:
                    Mensualidades = Meses * 4;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, TasaIntere);
                    break;
                case 5:
                    Mensualidades = Meses * 5;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, TasaIntere);
                    break;
            }
            return Total;
        }

        public decimal CuentaAhorroSemestral(double TasaIntere)
        {
            int Semestres;
            decimal Total = 0;
            switch (Periodo)
            {
                case 1:
                    Semestres = 2;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, TasaIntere);
                    break;
                case 2:
                    Semestres = 4;
                    Total =SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, TasaIntere);
                    break;
                case 3:
                    Semestres = 6;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, TasaIntere);
                    break;
                case 4:
                    Semestres = 8;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, TasaIntere);
                    break;
                case 5:
                    Semestres = 10;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, TasaIntere);
                    break;
            }
            return Total;
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
