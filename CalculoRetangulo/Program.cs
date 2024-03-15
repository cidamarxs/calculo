using System;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo:");
            double largura = Double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt((altura * altura) + (largura * largura));
            double perimetro = 2 * (altura + largura);

            Console.WriteLine("Altura do retângulo: " + altura);
            Console.WriteLine("Largura do retângulo: " + largura);
            Console.WriteLine("Diagonal do retângulo: " + diagonal);
            Console.WriteLine("Perímetro do retângulo: " + perimetro);

            Console.ReadLine(); // Espera o usuário pressionar Enter antes de fechar
        }
    }