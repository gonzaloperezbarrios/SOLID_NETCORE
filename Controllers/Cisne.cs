using System.Collections.Generic;

namespace pato
{
    public class Cisne : IPato, ICisne
    {
        private readonly IPatoBase _IPatoBase;
        private readonly IPatoBaseHabilidad _IPatoBaseHabilidad;
        private readonly IPatoBaseInfraestructura _IPatoBaseInfraestructura;
        public Cisne(IPatoBase iPatoBase,IPatoBaseHabilidad _iPatoBaseHabilidad,IPatoBaseInfraestructura _iPatoBaseInfraestructura)
        {
            this._IPatoBase=iPatoBase;
            this._IPatoBaseHabilidad=_iPatoBaseHabilidad;
            this._IPatoBaseInfraestructura=_iPatoBaseInfraestructura;
            _IPatoBase.setTipoPato("Cisne");
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
                _IPatoBaseHabilidad.Nadar(),
                _IPatoBaseHabilidad.Volar(),
                this.Sonido(),
                _IPatoBaseInfraestructura.Guardar()
                };
        }


    }
}