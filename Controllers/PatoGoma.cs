using System.Collections.Generic;
namespace pato
{
    public class PatoGoma : IpatoNoValodor
    {
        PatoBase patoBase = new PatoBase();

        public PatoGoma()
        {
            patoBase.TipoPato = "PatoGoma";
        }

        public IEnumerable<string> CrearPato()
        {
            return new string[] {
                this.Nadar(),
                this.Sonido(),
                this.Guardar()
                };
        }

        public string Nadar()
        {
            return patoBase.Nadar();
        }

        public string Sonido()
        {
            return patoBase.Sonido();
        }

        public string Guardar()
        {
            return patoBase.Guardar();
        }
    }
}