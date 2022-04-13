using System;
using System.Collections.Generic;
using System.Text;

namespace ValidarCURP
{
    class CrearCURP
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Genero { get; set; }
        public string Estado { get; set; }

        public void Insertar_datos()
        {
            Console.Write("NOMBRES: ");
            Nombre = Console.ReadLine().ToUpper();
            Console.Write("APELLIDO PATERNO: ");
            ApellidoPaterno = Console.ReadLine().ToUpper();
            Console.Write("APELLIDO MATERNO: ");
            ApellidoMaterno = Console.ReadLine().ToUpper();
            Console.Write("FECHA DE NACIONETO [AÑO-MES-DIA]: ");
            Fecha_Nacimiento = Console.ReadLine();
            Console.Write("ESTADO DE NACIMIENTO: ");
            Estado = Console.ReadLine().ToUpper();
            Console.Write("GENERO M|H: ");
            Genero = Console.ReadLine().ToUpper();

            char[] NOM;
            NOM = Nombre.ToCharArray(0, 1);
            char[] APP;
            APP = ApellidoPaterno.ToCharArray(0,2);
            char[] APM;
            APM = ApellidoMaterno.ToCharArray(0,1);
            char[] CONS;
            CONS = ApellidoPaterno.ToCharArray(2, 1);
            char[] CONSM;
            CONSM = ApellidoMaterno.ToCharArray(2, 1);
            char[] CON;
            CON = Nombre.ToCharArray(2, 1);
            char[] AÑO;
            AÑO = Fecha_Nacimiento.ToCharArray(2, 2);
            char[] MES;
            MES = Fecha_Nacimiento.ToCharArray(5, 2);
            char[] DIA;
            DIA = Fecha_Nacimiento.ToCharArray(8, 2); 
            char[] GEN;
            GEN = Genero.ToCharArray(0, 1);
           
           ESTADO eSTADO = new ESTADO();
           string EstadoNaci= eSTADO.ESTADONACIMIENTO(Estado);

            Console.Write("SU CURP ES:  ");
            Console.Write(APP);
            Console.Write(APM);
            Console.Write(NOM);
            Console.Write(AÑO);
            Console.Write(MES);
            Console.Write(DIA);
            Console.Write(GEN);
            Console.Write(EstadoNaci);
            Console.Write(CONS);
            Console.Write(CONSM);
            Console.Write(CON);
            Console.Write("09");
            Console.ReadLine();
        }
    }
}
