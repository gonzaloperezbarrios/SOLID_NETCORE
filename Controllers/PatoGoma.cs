using System.Collections.Generic;

public class PatoGoma : PatoBase,IPato
{

    public PatoGoma()
    {
        TipoPato = "PatoGoma";
    }
    public string PonerHuevos()
    {
        throw new System.Exception("No pone huevos");
    }

    public string Volar()
    {
        throw new System.Exception("No vuela");
    }

    public IEnumerable<string> CrearPato()
    {
        return new string[] {
                this.Nadar(),
                // this.Volar(),
                this.Sonido(),
                this.Guardar()
                };
    }


}