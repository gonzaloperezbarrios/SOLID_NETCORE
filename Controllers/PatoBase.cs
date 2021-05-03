using System.Collections.Generic;

namespace pato
{
    public class PatoBase : IPatoBase, IPatoBaseHabilidad, IPatoBaseInfraestructura
    {
        public string TipoPato { get; set; }

        public string GetTipoPato()
        {
            return TipoPato;
        }

        private readonly INadar _iNadar;
        public PatoBase(INadar iNadar )
        {
            this._iNadar=iNadar;
            TipoPato = "pato";
        }

        // public PatoBase(string _tipoPato)
        // {
        //     TipoPato = _tipoPato;    
        // }
        public PatoBase()
        {
            TipoPato = "Pato";
        }
        public string Nadar()
        {
            _iNadar.setTipoPato(TipoPato);
            return _iNadar.Nadar();
        }

        public string Volar()
        {
            return new VolarHabilidad(TipoPato).Volar();
        }

        public string Sonido()
        {
            return new SonidoHabilidad(TipoPato).Sonido();
        }

        public string Guardar()
        {
            return new GuardarInfraestuctura().Guardar();
        }

        public IEnumerable<string> CrearPato()
        {
            return new string[] {
                this.Nadar(),
                this.Volar(),
                this.Sonido(),
                this.Guardar()
                };
        }

        public void setTipoPato(string _tipoPato)
        {
            TipoPato=_tipoPato;
        }

        public string getTipoPato()
        {
            return TipoPato;
        }
    }
}