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
            int altura = 6;   // altura do cubo
            int largura = 6;   // largura do cubo
            int profundidade = 3; // profundidade do cubo (linhas inclinadas)

            // Topo do cubo
            Console.WriteLine(new string(' ', profundidade) + " " + new string('_', largura));

            // Lados inclinados (superior)
            for (int i = 0; i < profundidade; i++)
            {
                Console.WriteLine(new string(' ', profundidade - i - 1) + " /" + new string(' ', largura) + "/" + new string(' ', i) + "|");
            }

            // Frente superior
            Console.WriteLine("/" + new string('_', largura) + "/" + new string(' ', profundidade) + "|");

            // Laterais retas
            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine("|" + new string(' ', largura) + "|" + new string(' ', profundidade) + "|");
            }

            // Base inclinada
            for (int i = 0; i < profundidade; i++)
            {
                Console.WriteLine("|" + new string(' ', largura) + "|" + new string(' ', profundidade - i - 1) + "/");
            }

            // Base do cubo
            Console.WriteLine("|" + new string('_', largura) + "|");
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