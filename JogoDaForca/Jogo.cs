using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exibir;

namespace JogoDoMeEnforca
{
    internal class Jogo
    {

        internal class PalavraComDica
        {
            public string Palavra { get; set; }
            public string Dica { get; set; }

            public PalavraComDica(string palavra, string dica)
            {
                Palavra = palavra;
                Dica = dica;
            }
        }


        public static List<PalavraComDica> palavrasFaceis { get; private set; } = new List<PalavraComDica>
                {
                    new PalavraComDica("calopsita", "ave"),
                    new PalavraComDica("cachorro", "animal"),
                    new PalavraComDica("banana", "fruta"),
                    new PalavraComDica("maça", "fruta"),
                    new PalavraComDica("olho", "parte do corpo"),
                    new PalavraComDica("azul", "cor"),
                    new PalavraComDica("matematica", "materia de exatas")
                };
        public static List<PalavraComDica> palavrasMedias { get; private set; } = new List<PalavraComDica>
                {
                    new PalavraComDica("psicologo", "profissao"),
                    new PalavraComDica("golf", "esporte"),
                    new PalavraComDica("pitaya", "fruta"),
                    new PalavraComDica("banoffe", "doce"),
                    new PalavraComDica("intestino", "parte do corpo"),
                    new PalavraComDica("paralelepipedo", "forma geometrica"),

                };

        public static List<PalavraComDica> palavrasDificeis { get; private set; } = new List<PalavraComDica>
                {
                   new PalavraComDica("pneumoultramicroscopicossilicovulcanoconiótico",""),
                   new PalavraComDica("otorrinolaringologista",""),
                   new PalavraComDica("inconstitucionalissimamente",""),
                   new PalavraComDica("HIPOPOTAMONSTROSESQUIPEDALIOFOBIA","")
                };




        public static void Dificuldade(int dificuldade)
        {

            switch (dificuldade)
            {

                case 1:
                    Console.WriteLine("Dificuldade fácil escolhida.");
                    EscolherPalavra(palavrasFaceis);
                    break;
                case 2:
                    Console.WriteLine("Dificuldade média escolhida.");
                    EscolherPalavra(palavrasMedias);
                    break;
                case 3:
                    Console.WriteLine("Dificuldade difícil escolhida.");
                    EscolherPalavra(palavrasDificeis);
                    break;
            }
        }



        public static void EscolherPalavra(List<PalavraComDica> palavras)
        {
            Random random = new Random();
            PalavraComDica palavraAtual = palavras[random.Next(palavras.Count)];
            string palavraSecreta = palavraAtual.Palavra.ToUpper();
            string dica = palavraAtual.Dica;

            teste(palavraSecreta, dica);
        }

        public static void teste(string PalavraSecreta, string Dica)
        {
            char[] letrasDescobertas = new char[PalavraSecreta.Length];
            List<char> letrasIncorretas = new List<char>();

            for (int i = 0; i < letrasDescobertas.Length; i++)
            {
                letrasDescobertas[i] = '_';
            }

            int tentativasRestantes = 6;
            bool jogoTerminado = false;

            while (!jogoTerminado)
            {
                Console.Clear();
                Console.WriteLine($"Dica: {Dica}\n");
                forca(tentativasRestantes);
                Console.WriteLine("\nPalavra: " + string.Join(" ", letrasDescobertas));
                Console.WriteLine("\nLetras incorretas: " + string.Join(", ", letrasIncorretas));
                Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");

                Console.Write("\nDigite uma letra: ");

                string letra;
                char letraChar;

                try
                {
                    letra = Console.ReadLine().ToUpper();
                    letraChar = char.Parse(letra);
                }
                catch
                {
                    Console.WriteLine("ERRO");
                    continue;
                }

                if (PalavraSecreta.Contains(letraChar))
                {
                    for (int i = 0; i < PalavraSecreta.Length; i++)
                    {
                        if (PalavraSecreta[i] == letraChar)
                        {
                            letrasDescobertas[i] = letraChar;
                        }
                    }

                    if (!new string(letrasDescobertas).Contains('_'))
                    {
                        jogoTerminado = true;
                        Console.Clear();
                        Console.WriteLine("Parabéns! Você ganhou!");
                        Console.WriteLine($"A palavra era: {PalavraSecreta}");
                    }
                }
                else
                {
                    if (!letrasIncorretas.Contains(letraChar))
                    {
                        letrasIncorretas.Add(letraChar);
                        tentativasRestantes--;
                    }

                    if (tentativasRestantes == 0)
                    {
                        jogoTerminado = true;
                        Console.Clear();
                        Console.WriteLine("Game Over! Você perdeu!");
                        Console.WriteLine($"A palavra era: {PalavraSecreta}");
                    }
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
            TelaInicial.Menu();
        }
        


        public static void forca(int tentativasRestantes)
        {
            switch (tentativasRestantes)
            {
                case 0:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |       O ");
                    Console.WriteLine(" |      /|\\");
                    Console.WriteLine(" |      / \\");
                    Console.WriteLine(" |_________");
                    break;
                case 1:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |       O ");
                    Console.WriteLine(" |      /|\\");
                    Console.WriteLine(" |      / ");
                    Console.WriteLine(" |_________");
                    break;
                case 2:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |       O ");
                    Console.WriteLine(" |      /|\\");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |_________");
                    break;
                case 3:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |       O ");
                    Console.WriteLine(" |      /|");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |_________");
                    break;
                case 4:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |       O ");
                    Console.WriteLine(" |       |");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |_________");
                    break;
                case 5:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |       O ");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |_________");
                    break;
                case 6:
                    Console.WriteLine("  _______  ");
                    Console.WriteLine(" |       | ");
                    Console.WriteLine(" |         ");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |      ");
                    Console.WriteLine(" |_________");
                    break;
            }

        }




    } 
}

