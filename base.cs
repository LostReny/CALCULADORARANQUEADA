using System;

namespace CalculadoraRanqueada
{
    class Program
    {
        public static int saldo = 27;
        public static string level = "myLevel";

        static void Main(string[] args)
        {
            if (saldo <= 10)
            {
                level = "Ferro";
            }
            else if (saldo >= 11 && saldo <= 20)
            {
                level = "Bronze";
            }
            else if (saldo >= 21 && saldo <= 50)
            {
                level = "Prata";
            }
            else if (saldo >= 51 && saldo <= 80)
            {
                level = "Ouro";
            }
            else if (saldo >= 81 && saldo <= 90)
            {
                level = "Diamante";
            }
            else if (saldo >= 91 && saldo <= 100)
            {
                level = "Lendário";
            }
            else
            {
                level = "Imortal";
            }

            Console.WriteLine($"O Herói que tem o saldo de {saldo} está no nível de {level};");
        }
    }
}