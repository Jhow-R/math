using System;

using static System.Console;

namespace Math
{
    static class Program
    {
        const string WhiteSpace = " ";

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Clear();
            WriteLine($"\n 1. {Titulos.SequenciaFibonacci}"
                        + Environment.NewLine + $" 2. {Titulos.NumeroFatorial}"
                        + Environment.NewLine + $" 3. {Titulos.NumerosSoma}"
                        + Environment.NewLine + $" 4. {Titulos.NumeroFatores}"
                        + Environment.NewLine + $" 5. {Titulos.NumeroArmostrong}"
                        + Environment.NewLine + $" 6. {Titulos.NumeroPerfeito}"
                        + Environment.NewLine + $" 7. {Titulos.MDC}"
                        + Environment.NewLine + $" 8. {Titulos.MMC}"
                        + Environment.NewLine + $" 9. {Titulos.NumeroPrimo}"
                        + Environment.NewLine + $" 10. {Titulos.NumeroRaizCubica}"
                        + Environment.NewLine + $" 0. {Titulos.Sair}"
                        + Environment.NewLine);

            var resposta = ReadLine();

            if (int.TryParse(resposta, out int escolha))
            {
                switch (escolha)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        Cabecalho(Titulos.SequenciaFibonacci);
                        Write("Digite o limite para a sequência: ");

                        var sequencia = OperacoesMatematicas.SequenciaFibonacci(int.Parse(ReadLine()));

                        foreach (var item in sequencia)
                            Write($"{ item.ToString()} {WhiteSpace}");

                        break;

                    case 2:
                        Cabecalho(Titulos.NumeroFatorial);
                        Write("Digite um número para o fatorial: ");
                        int.TryParse(ReadLine(), out int numeroFatorial);

                        int fatorial = OperacoesMatematicas.NumeroFatorial(numeroFatorial);

                        Write($"{numeroFatorial}! = {fatorial}");

                        break;

                    case 3:
                        Cabecalho(Titulos.NumerosSoma);
                        Write("Digite o enésimo número: ");
                        int.TryParse(ReadLine(), out int enesimo);

                        int soma = OperacoesMatematicas.SomarNumeros(enesimo);

                        Write(soma);

                        break;

                    case 4:
                        Cabecalho(Titulos.NumeroFatores);
                        Write("Digite o número: ");
                        int.TryParse(ReadLine(), out int numeroFator);

                        foreach (var item in OperacoesMatematicas.ObterFatoresNumero(numeroFator))
                            Write($"{ item.ToString()} {WhiteSpace}");

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
