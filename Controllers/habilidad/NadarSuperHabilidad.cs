
namespace pato
{
    public class NadarSuperHabilidad: INadar
    {

        private string tipoPato;

  
        public string Nadar()
        {
            return $"EL {tipoPato} nada con MOTOR DIESEL";
        }

        public void setTipoPato(string _tipoPato)
        {
            tipoPato = _tipoPato;
        }
    }
}