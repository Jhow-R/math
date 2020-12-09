using System;

using static System.Console;

namespace Matematica
{
    static class Program
    {
        const string WhiteSpace = " ";

        static void Main(string[] args)
        {
        Menu:
            Clear();
            WriteLine($"\n 1. {Titulos.SequenciaFibonacci}"
                        + Environment.NewLine + $" 2. {Titulos.NumeroFatorial}"
                        + Environment.NewLine + $" 3. {Titulos.NumerosSoma}"
                        + Environment.NewLine + $" 4. {Titulos.NumeroFatores}"
                        + Environment.NewLine + $" 5. {Titulos.NumeroArmstrong}"
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

                        var sequencia = OperacoesMatematicas.ObterSequenciaFibonacci(int.Parse(ReadLine()));

                        foreach (var item in sequencia)
                            Write($"{ item.ToString()} {WhiteSpace}");
                        break;

                    case 2:
                        Cabecalho(Titulos.NumeroFatorial);
                        Write("Digite um número para o fatorial: ");
                        int.TryParse(ReadLine(), out int numeroFatorial);

                        var fatorial = OperacoesMatematicas.ObterNumeroFatorial(numeroFatorial);

                        Write($"{numeroFatorial}! = {fatorial}");
                        break;

                    case 3:
                        Cabecalho(Titulos.NumerosSoma);
                        Write("Digite o enésimo número: ");
                        int.TryParse(ReadLine(), out int enesimo);

                        var soma = OperacoesMatematicas.SomarNumeros(enesimo);

                        Write(soma);
                        break;

                    case 4:
                        Cabecalho(Titulos.NumeroFatores);
                        Write("Digite o número: ");
                        int.TryParse(ReadLine(), out int numeroFator);

                        foreach (var item in OperacoesMatematicas.ObterFatoresNumero(numeroFator))
                            Write($"{ item.ToString()} {WhiteSpace}");
                        break;

                    case 5:
                        Cabecalho(Titulos.NumeroArmstrong);
                        Write("Digite o número: ");
                        int.TryParse(ReadLine(), out int numeroArmstrong);

                        bool isArmstrongNumber = OperacoesMatematicas.VerificarNumeroArmstrong(numeroArmstrong);

                        Write(isArmstrongNumber ?
                            "É um número de Armstrong." :
                            "Não é um número de Armstrong.");
                        break;

                    case 6:
                        Cabecalho(Titulos.NumeroPerfeito);
                        Write("Digite o número: ");
                        int.TryParse(ReadLine(), out int numeroPerfeito);

                        bool isPerfectNumber = OperacoesMatematicas.VerificarNumeroPerfeito(numeroPerfeito);

                        Write(isPerfectNumber ?
                            "É um número de perfeito." :
                            "Não é um número perfeito.");
                        break;

                    case 7:
                        Cabecalho(Titulos.MDC);
                        Write("Digite o primeiro número: ");
                        int.TryParse(ReadLine(), out int mdcPrimeiroNumero);

                        Write("Digite o segundo número: ");
                        int.TryParse(ReadLine(), out int mdcSegundoNumero);

                        var mdc = OperacoesMatematicas.CalcularMaiorDivisorComum(mdcPrimeiroNumero, mdcSegundoNumero);

                        Write($"O MDC de ({mdcPrimeiroNumero}, {mdcSegundoNumero}) = {mdc}");
                        break;

                    case 8:
                        Cabecalho(Titulos.MMC);
                        Write("Digite o primeiro número: ");
                        int.TryParse(ReadLine(), out int mmcPrimeiroNumero);

                        Write("Digite o segundo número: ");
                        int.TryParse(ReadLine(), out int mmcSegundoNumero);

                        var mmc = OperacoesMatematicas.CalcularMenorMultiploComum(mmcPrimeiroNumero, mmcSegundoNumero);

                        Write($"O MMC de ({mmcPrimeiroNumero}, {mmcSegundoNumero}) = {mmc}");
                        
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

            goto Menu;
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
