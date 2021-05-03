
namespace pato
{
    public class NadarHabilidad: INadar
    {

        private string tipoPato;

  
        public string Nadar()
        {
            return $"EL {tipoPato} nada";
        }

        public void setTipoPato(string _tipoPato)
        {
            tipoPato = _tipoPato;
        }
    }
}