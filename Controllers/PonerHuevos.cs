using System.Collections.Generic;

class PonerHuevos
{
    public IEnumerable<string> Cantidad(List<IPato> patos)
    {
        List<string> huevos = new List<string>();
        foreach (IPato pato in patos)
        {
            huevos.Add(pato.PonerHuevos());
        }
        return huevos;
    }
}