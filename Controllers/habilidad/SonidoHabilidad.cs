

namespace pato
{
    public class SonidoHabilidad
    {

        private string tipoPato;

        public SonidoHabilidad(string _tipoPato)
        {
            tipoPato = _tipoPato;
        }
        public string Sonido()
        {
            return $"El {tipoPato} hace cuak cuak cuak";
        }
    }
}