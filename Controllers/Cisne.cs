using System.Collections.Generic;

public class Cisne : PatoBase,IPato
{

    public Cisne()
    {
        TipoPato = "Cisne";
    }
    public string PonerHuevos()
    {
        return $"Cantidad de huevos en un {TipoPato}: {2 + 2 * 3}";
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