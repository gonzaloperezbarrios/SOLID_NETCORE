public class NadarHabilidad
{

    private string tipoPato;

    public NadarHabilidad(string _tipoPato)
    {
        tipoPato = _tipoPato;
    }
    public string Nadar()
    {
        return $"EL {tipoPato} nada";
    }
}