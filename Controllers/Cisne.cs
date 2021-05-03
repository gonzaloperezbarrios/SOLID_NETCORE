using System.Collections.Generic;

namespace pato
{
    public class Cisne : IPato, ICisne
    {
        private readonly IPatoBase _IPatoBase;
        public Cisne(IPatoBase iPatoBase)
        {
            this._IPatoBase=iPatoBase;
            _IPatoBase.setTipoPato("Cisne");
            // TipoPato = "Cisne";
        }
        public string PonerHuevos()
        {
            return $"Cantidad de huevos en un {_IPatoBase.getTipoPato()}: {2 + 2 * 3}";
        }


        public string Sonido()
        {
            return $"El {_IPatoBase.getTipoPato()} hace clock clock clock";
        }

        public IEnumerable<string> CrearPato()
        {
            return new string[] {
                _IPatoBase.Nadar(),
                _IPatoBase.Volar(),
                this.Sonido(),
                _IPatoBase.Guardar()
                };
        }


    }
}