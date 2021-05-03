public class VolarHabilidad
{

    private string tipoPato;

    public VolarHabilidad(string _tipoPato)
    {
        tipoPato = _tipoPato;
    }
    public string Volar()
    {
        return $"El {tipoPato} vuela";
    }
}