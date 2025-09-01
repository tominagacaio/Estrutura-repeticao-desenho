using System;

namespace MyApp
{
    internal class Program
    {
        // triangulo
        static void Main(string[] args)
        {
            int altura = 10; // altura da árvore

            for (int a = 0; a < altura; a++)
            {
                // Parte negativa: imprime espaços em branco (vai diminuindo)
                for (int i = 0; i < altura - a - 1; i++)
                {
                    Console.Write(" ");
                }

                // Parte positiva: imprime pontos (vai aumentando)
                for (int j = 0; j < (2 * a + 1); j++)
                {
                    Console.Write(".");
                }

                // Quebra de linha para a próxima linha da árvore
                Console.WriteLine();
            }

            
            Console.WriteLine("Agora vamos desenhar o cubo: ");
            DesenhoCubo();

            Console.WriteLine(); // Linha em branco para separar os desenhos

            Console.WriteLine("Agora vamos desenhar o losango: ");
            DesenhoLosango();
        }

        static void DesenhoCubo()
        {
            {
                int altura = 5; // tamanho do cubo (altura/largura)

                // Parte superior do cubo
                for (int i = 0; i < altura; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < altura; i++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();

                // Parte do meio (faces laterais)
                for (int i = 0; i < altura; i++)
                {
                    // Espaços para dar o efeito 3D
                    for (int j = altura - 1; j > i; j--)
                    {
                        Console.Write(" ");
                    }

                    // Face frontal (esquerda)
                    Console.Write("/");

                    // Parte interna da face frontal
                    for (int j = 0; j < altura; j++)
                    {
                        Console.Write(" ");
                    }

                    // Face lateral direita
                    Console.Write("/");

                    // Parte de trás (só em algumas linhas)
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    // Fecha a lateral
                    Console.Write("|");
                    Console.WriteLine();
                }

                // Parte inferior do cubo (base)
                Console.Write("|");
                for (int i = 0; i < altura; i++)
                {
                    Console.Write("_");
                }
                Console.Write("|");

                for (int i = 0; i < altura - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
            }
        }

        static void DesenhoLosango()
        {
            int numerosDeLinhas = 5; // metade do losango

            // Metade superior
            for (int i = 1; i <= numerosDeLinhas; i++)
            {
                // Espaços
                for (int j = i; j < numerosDeLinhas; j++)
                {
                    Console.Write(" ");
                }

                // Caracteres (2 * i - 1 dá os números ímpares: 1, 3, 5, 7...)
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }

            // Metade inferior
            for (int i = numerosDeLinhas- 1; i >= 1; i--)
            {
                // Espaços
                for (int j = numerosDeLinhas; j > i; j--)
                {
                    Console.Write(" ");
                }

                // Caracteres
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }
        }
    }
}