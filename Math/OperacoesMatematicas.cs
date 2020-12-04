using System;
using System.Collections.Generic;
using System.Linq;

namespace Matematica
{
    static class OperacoesMatematicas
    {
        public static IEnumerable<int> SequenciaFibonacci(int limite)
        {
            IList<int> fibonacci = new List<int>();

            Enumerable.Range(0, limite)
                .ToList()
                .ForEach(f => fibonacci.Add((f <= 1) ? 1 : fibonacci[f - 2] + fibonacci[f - 1]));

            return fibonacci;
        }

        public static int NumeroFatorial(int numero)
        {
            if (numero == 1)
                return 1;

            return numero * NumeroFatorial(numero - 1);
        }

        public static int SomarNumeros(int enesimo)
        {
            int soma = default(int);

            for (int i = 0; i <= enesimo; i++)
                soma += i;

            return soma;
        }

        public static IEnumerable<int> ObterFatoresNumero(int numeroFator)
        {
            for (int i = 1; i <= numeroFator; i++)
            {
                if (numeroFator % i == 0)
                {
                    yield return i;
                }
            }
        }

        public static bool VerificarNumeroArmstrong(int numeroArmstrong)
        {
            int soma = 0 , resto;

            for (int i = numeroArmstrong; i > 0; i = i / 10)
            {
                resto = i % 10;
                soma += (int)Math.Pow(resto, 3);
            }

            return soma == numeroArmstrong;
        }
    }
}
