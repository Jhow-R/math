using System;
using System.Collections.Generic;
using System.Linq;

namespace Matematica
{
    static class OperacoesMatematicas
    {
        internal static IEnumerable<int> ObterSequenciaFibonacci(int limite)
        {
            IList<int> fibonacci = new List<int>();

            Enumerable.Range(0, limite)
                .ToList()
                .ForEach(f => fibonacci.Add((f <= 1) ? 1 : fibonacci[f - 2] + fibonacci[f - 1]));

            return fibonacci;
        }

        internal static int ObterNumeroFatorial(int numero)
        {
            if (numero == 1)
                return 1;

            return numero * ObterNumeroFatorial(numero - 1);
        }

        internal static int SomarNumeros(int enesimo)
        {
            int soma = default(int);

            for (int i = 0; i <= enesimo; i++)
                soma += i;

            return soma;
        }

        internal static IEnumerable<int> ObterFatoresNumero(int numeroFator)
        {
            for (int i = 1; i <= numeroFator; i++)
            {
                if (numeroFator % i == 0)
                {
                    yield return i;
                }
            }
        }

        internal static bool VerificarNumeroArmstrong(int numeroArmstrong)
        {
            int soma = 0, resto;

            for (int i = numeroArmstrong; i > 0; i = i / 10)
            {
                resto = i % 10;
                soma += (int)Math.Pow(resto, 3);
            }

            return soma == numeroArmstrong;
        }

        internal static bool VerificarNumeroPerfeito(int numeroPerfeito)
        {
            int soma = 0;

            for (int i = 1; i < numeroPerfeito; i++)
            {
                if (numeroPerfeito % i == 0)
                    soma = soma + i;
            }

            return soma == numeroPerfeito;
        }

        internal static int CalcularMaiorDivisorComum(int primeiroNumero, int segundoNumero)
        {
            int resto;
            while (segundoNumero != 0)
            {
                resto = primeiroNumero % segundoNumero;
                primeiroNumero = segundoNumero;
                segundoNumero = resto;
            }
            return primeiroNumero;
        }

        internal static int CalcularMenorMultiploComum(int primeiroNumero, int segundoNumero)
        {
            int x = primeiroNumero;
            int y = segundoNumero;

            while (primeiroNumero != segundoNumero)
            {
                if (primeiroNumero > segundoNumero)
                    primeiroNumero -= segundoNumero;
                else
                    segundoNumero -= primeiroNumero;
            }
            return (x * y) / primeiroNumero;
        }

        internal static bool VerificarNumeroPrimo(int numeroPrimo)
        {
            int k = 0;
            for (int i = 1; i <= numeroPrimo; i++)
            {
                if (numeroPrimo % i == 0)
                    k++;
            }
            return k == 2;
        }
    }
}
