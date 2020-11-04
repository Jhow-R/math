using System;

using static System.Console;

namespace Math
{
    static class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Clear();
            WriteLine($"\n 1. {Titulos.SequenciaFibonacci}"
                        + Environment.NewLine + $" 2. {Titulos.NumeroFatorial}"
                        + Environment.NewLine + $" 3. {Titulos.NumerosSoma}s"
                        + Environment.NewLine + $" 4. {Titulos.NumeroFatores}"
                        + Environment.NewLine + $" 5. {Titulos.NumeroArmostrong}"
                        + Environment.NewLine + $" 6. {Titulos.NumeroPerfeito}"
                        + Environment.NewLine + $" 7. {Titulos.MDC}"
                        + Environment.NewLine + $" 8. {Titulos.MMC}"
                        + Environment.NewLine + $" 9. {Titulos.NumeroPrimo}"
                        + Environment.NewLine + $" 10. {Titulos.NumeroRaizCubica}"
                        + Environment.NewLine);

            var resposta = ReadLine();

            if (int.TryParse(resposta, out int escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Cabecalho(Titulos.SequenciaFibonacci);
                        Write("Digite o limite para a sequência: ");

                        var sequencia = OperacoesMatematicas.SequenciaFibonacci(int.Parse(ReadLine()));

                        foreach (var item in sequencia)
                            Write(item.ToString() + " ");

                        break;

                    case 2:
                        Cabecalho(Titulos.NumeroFatorial);
                        Write("Digite um número para o fatorial: ");
                        var numero = int.Parse(ReadLine());

                        var fatorial = OperacoesMatematicas.NumeroFatorial(numero);

                        Write($"{numero}! = {fatorial}");

                        break;

                    default:
                        WriteLine("Opção inexistente!");
                        break;
                }
            }
            else
            {
                WriteLine("Permitido somente valores numéricos!");
            }

            WriteLine(Environment.NewLine);
            Write("Pressione qualquer tecla para retornar ao menu.");

            ReadKey();
            Menu();
        }

        private static void Cabecalho(string titulo)
        {
            Write(Environment.NewLine);
            WriteLine("==================================================");
            WriteLine(titulo);
            WriteLine("==================================================");
            Write(Environment.NewLine);
        }
    }
}
