using System.Collections.Generic;

namespace pato
{
   public interface IPatoBase
    {
        void setTipoPato(string tipoPato);
        string getTipoPato();
        string Nadar();
        string Volar();
        string Sonido();
         IEnumerable<string> CrearPato();
         string Guardar();
    }
}