using System.Collections.Generic;

namespace pato
{
    public interface IPatoBaseInfraestructura
    {
        IEnumerable<string> CrearPato();
        string Guardar();
    }
}