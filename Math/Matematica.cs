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
    }
}
