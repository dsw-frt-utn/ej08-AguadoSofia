using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notasRecibidas = new List<int?> { nota1, nota2, nota3 };

            var notasValidas = notasRecibidas
                .Where(n => n.HasValue && n.Value >= 0 && n.Value <= 10)
                .Select(n => (double)n!.Value)
                .ToList();
        
            if (notasValidas.Count == 0)
            {
                return 0;
            }

            return notasValidas.Average();
        }
    }
}
