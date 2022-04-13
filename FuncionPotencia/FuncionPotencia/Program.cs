using System;

namespace FuncionPotencia
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            Console.Write("INGRESE NUMERO : ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EXPONENCIAL : ");
            numero2 = int.Parse(Console.ReadLine());
            int resultado= FuncionPower(numero1, numero2);
            Console.WriteLine("VALOR EXPONENCIAL : "+ numero1+ " ^ "+ numero2 +" = "+ resultado);
            Console.Read();
        }

        public static int FuncionPower(int numero, int power)
        {
            int resultado=1;
            for (int i = 0; i < power; i++)
            { resultado *= numero; }
            return resultado;
        }
    }
}
