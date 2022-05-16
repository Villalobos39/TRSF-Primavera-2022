using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosLibreria
{
    public static class Metodos
    {
        public static double TasaIntere;
        public static int Mensualidades;
        public static int Semestres;
        // EL METODO MANDA A LLAMAR A LA CLASE CALCULAR CUENTA DONDE SE REALIZA LA OPERACION DESIGNADA 
        public static double TasaInteres(string Composicion, double Interes)
        {
            // SI LA COMPOSICION DEL CLIENTE ES MENSUAL LA TASA DE INTERES SE DIVIDE ENTRE LOS MESES PARA CALCULAR 
            switch (Composicion)
            {
                case "MENSUAL":
                    TasaIntere = Math.Round((Interes / 100) / 12, 5);
                    break;
                case "SEMESTRAL":
                    TasaIntere = Math.Round((Interes / 100) / 2, 5);
                    break;
                case "ANUAL":
                    TasaIntere = Math.Round((Interes / 100), 5);
                    break;
            }
            return TasaIntere;
        }

        public static int Mensual(int Periodo)
        {
            int Meses = 12;

            switch (Periodo)
            {
                case 1:
                    Mensualidades = Meses;
                    break;
                case 2:
                    Mensualidades = Meses * 2;
                    break;
                case 3:
                    Mensualidades = Meses * 3;
                    break;
                case 4:
                    Mensualidades = Meses * 4;
                    break;
                case 5:
                    Mensualidades = Meses * 5;
                    break;
            }
            return Mensualidades;
        }

        public static int Semestral(int Periodo)
        {
            switch (Periodo)
            {
                case 1:
                    Semestres = 2;
                    break;
                case 2:
                    Semestres = 4;
                    break;
                case 3:
                    Semestres = 6;
                    break;
                case 4:
                    Semestres = 8;
                    break;
                case 5:
                    Semestres = 10;
                    break;
            }
            return Semestres;
        }
    }
}
