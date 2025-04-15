using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDoMeEnforca;

namespace Exibir
{

    internal class TelaInicial
    {
        public static void Menu()
        {
            string titulo = @"
 ███████╗░█████╗░██████╗░░█████╗░░█████╗░
 ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗
 █████╗░░██║░░██║██████╔╝██║░░╚═╝███████║
 ██╔══╝░░██║░░██║██╔══██╗██║░░██╗██╔══██║
 ██║░░░░░╚█████╔╝██║░░██║╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝";


            bool continuar = true;
            while (continuar)
            {
                Console.Clear();

                EscreverCentralizado(titulo);
                Console.WriteLine();

                ExibirOpcoesMenu();

                
                Console.Write("Digite o número da opção: ");
                string opcao = Console.ReadLine();

                
                switch (opcao)
                {
                    case "1":

                        Jogo.SelecionarDificuldade(1);
                        Thread.Sleep(3000);
                        break;
                    case "2":

                        Jogo.SelecionarDificuldade(2);
                        Thread.Sleep(3000);
                        break;
                    case "3":
                        
                        Jogo.SelecionarDificuldade(3);
                        Thread.Sleep(3000);
                        break;
                    case "4":
                        Console.Clear();

                        Thread.Sleep(1000);
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Thread.Sleep(1000);
                        continue;
                }
            }
        }


        public static void EscreverCentralizado(string texto)
        {
            string[] linhas = texto.Split("\n", StringSplitOptions.None);

            foreach (var linha in linhas)
            {
                int larguraConsole = Console.WindowWidth;
                int espacos = (larguraConsole - linha.Length) / 2;
                string textoCentralizado = new string(' ', Math.Max(0, espacos)) + linha;
                Console.WriteLine(textoCentralizado);
            }
        }

        public static void ExibirOpcoesMenu()
        {
            string[] opcoesMenu = {
            "1. Fácil",
            "2. Médio",
            "3. Difícil",
            "4. Sair"
        };

            
            int alinhamento = 52;  

            foreach (var opcao in opcoesMenu)
            {
                
                Console.WriteLine(new string(' ', alinhamento) + opcao);
            }
        }
    }
}
