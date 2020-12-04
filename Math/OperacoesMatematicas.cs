using System;
using System.Collections.Generic;
using System.Linq;

namespace Math
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
    }
}
