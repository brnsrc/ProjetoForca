using System;
using System.Collections.Generic;

namespace ProjetoForca
{
    class Program
    {
        static void Main(string[] args)
        {
            var letraBuscar = "a";
            string palavraEscolhida;
            string comparaPalavra = "lock";
            Random random = new Random();
            List<string> conjuntoDePalavras = new List<string>
            {
                "podre", "claridade", "céu", "vida", "mar", "rio de janeiro", "sao paulo",
                "curitiba"
            };   
            //randomiza a palavra
            palavraEscolhida = conjuntoDePalavras[random.Next(conjuntoDePalavras.Count)];
            
            Console.WriteLine($"letra: {letraBuscar}");

            Console.WriteLine($"verifica Letra: {palavraEscolhida.Contains(letraBuscar)}");

            Console.WriteLine(palavraEscolhida);
            //Console.WriteLine(comparaPalavra == palavraEscolhida);


            
        }

        public void AdicionarMembroDoCorpo(int numeroDoErro)
        {
            switch (numeroDoErro)
            {
                case 1:
                    Console.WriteLine("        O");                
                    break;
                case 2:
                    Console.Write("       /|");
                    break;
                case 3:
                    Console.WriteLine("|\\  ");
                    break;
                case 4:
                    Console.WriteLine("        |");
                    break;
                case 5:
                    Console.Write("       / ");
                    break;
                case 6:
                    Console.WriteLine("\\  ");
                    break;
            }
        }
    }
}
