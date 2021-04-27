using System.Collections.Generic;

public class PatoBase
{
    public string TipoPato { get; set; }

    public PatoBase()
    {
        TipoPato = "Pato";
    }
    public string Nadar()
    {
        return $"EL {TipoPato} nada";
    }

    public string Volar()
    {
        return $"El {TipoPato} vuela";
    }

    public string Sonido()
    {
        return $"El {TipoPato} hace cuak cuak cuak";
    }

    public string Guardar(){
        return "Se guarda en SQL-SERVER";
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