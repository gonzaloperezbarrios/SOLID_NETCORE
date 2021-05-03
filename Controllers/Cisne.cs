using System.Collections.Generic;

public class Cisne : PatoBase
{

    public Cisne()
    {
        TipoPato = "Cisne";
    }


    public string Sonido()
    {
        return $"El {TipoPato} hace clock clock clock";
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