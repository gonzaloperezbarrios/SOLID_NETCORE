using System.Collections.Generic;

class PonerHuevos
{
    public IEnumerable<string> Cantidad(List<PatoBase> patos)
    {
        List<string> huevos = new List<string>();
        foreach (PatoBase pato in patos)
        {
            if (pato.TipoPato == "Silvestre")
            {
                huevos.Add($"Cantidad de huevos en un pato {pato.TipoPato}: {5 * 3}");
            }
            if (pato.TipoPato == "Cisne")
            {
                huevos.Add($"Cantidad de huevos en un {pato.TipoPato}: {2 + 2 * 3}");
            }
        }
        return huevos;
    }
}