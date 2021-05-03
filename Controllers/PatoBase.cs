using System.Collections.Generic;

public class PatoBase
{
    public string TipoPato { get; set; }

    public PatoBase(string _tipoPato)
    {
        TipoPato = _tipoPato;
    }
    public PatoBase()
    {
        TipoPato = "Pato";
    }

    public string Nadar()
    {
        return new NadarHabilidad(TipoPato).Nadar();
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
}