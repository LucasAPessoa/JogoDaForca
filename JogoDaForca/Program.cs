using System;
using System.Collections.Generic;
using Exibir;

class JogoDaForca
{
   

    static void Main()
    {
        TelaInicial.Menu();
        /*
                Console.WriteLine("Bem-vindo ao Jogo da Forca com Dicas!");

               

                Console.WriteLine("Escolha a dificuldade:");
                Console.WriteLine("1 - Fácil");
                Console.WriteLine("2 - Médio");
                Console.WriteLine("3 - Difícil");
                Console.Write("Digite sua opção (1-3): ");



                        

                        char[] letrasDescobertas = new char[palavraSecreta.Length];
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
                            Console.WriteLine($"Dica: {dica}\n");
                            DesenharForca(tentativasRestantes);
                            Console.WriteLine("\nPalavra: " + string.Join(" ", letrasDescobertas));
                            Console.WriteLine("\nLetras incorretas: " + string.Join(", ", letrasIncorretas));
                            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");

                            Console.Write("\nDigite uma letra: ");
                            char letra;
                            try
                            {
                                letra = Console.ReadLine().ToUpper()[0];
                            }
                            catch
                            {
                                continue;
                            }

                            if (palavraSecreta.Contains(letra))
                            {
                                for (int i = 0; i < palavraSecreta.Length; i++)
                                {
                                    if (palavraSecreta[i] == letra)
                                    {
                                        letrasDescobertas[i] = letra;
                                    }
                                }

                                if (!new string(letrasDescobertas).Contains('_'))
                                {
                                    jogoTerminado = true;
                                    Console.Clear();
                                    Console.WriteLine("Parabéns! Você ganhou!");
                                    Console.WriteLine($"A palavra era: {palavraSecreta}");
                                }
                            }
                            else
                            {
                                if (!letrasIncorretas.Contains(letra))
                                {
                                    letrasIncorretas.Add(letra);
                                    tentativasRestantes--;
                                }

                                if (tentativasRestantes == 0)
                                {
                                    jogoTerminado = true;
                                    Console.Clear();
                                    Console.WriteLine("Game Over! Você perdeu!");
                                    Console.WriteLine($"A palavra era: {palavraSecreta}");
                                }
                            }
                        }

                        Console.WriteLine("\nPressione qualquer tecla para sair...");
                        Console.ReadKey();
                    }

                    static void DesenharForca(int tentativasRestantes)
                    {
                        Console.WriteLine("  _______");
                        Console.WriteLine("  |     |");

                        if (tentativasRestantes < 6)
                            Console.WriteLine("  |     O");
                        else
                            Console.WriteLine("  |");

                        if (tentativasRestantes < 4)
                        {
                            if (tentativasRestantes < 3)
                                Console.WriteLine("  |    /|\\");
                            else if (tentativasRestantes < 4)
                                Console.WriteLine("  |    /|");
                            else
                                Console.WriteLine("  |     |");
                        }
                        else
                            Console.WriteLine("  |");

                        if (tentativasRestantes < 2)
                        {
                            if (tentativasRestantes < 1)
                                Console.WriteLine("  |    / \\");
                            else
                                Console.WriteLine("  |    /");
                        }
                        else
                            Console.WriteLine("  |");

                        Console.WriteLine("__|__");
                  */
    }
}
