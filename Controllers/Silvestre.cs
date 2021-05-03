using System.Collections.Generic;
namespace pato
{
    public class Silvestre : PatoBase, IPato
    {
        public Silvestre()
        {
            TipoPato = "Silvestre";
        }

        public string PonerHuevos()
        {
            return $"Cantidad de huevos en un pato {TipoPato}: {5 * 3}";
        }


    }
}