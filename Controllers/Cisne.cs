public class Cisne: PatoBase
{
    public Cisne(){
        TipoPato="Cisne";
    }
     public string Sonido(){
        return $"El {TipoPato} hace clock clock clock";
    }
}