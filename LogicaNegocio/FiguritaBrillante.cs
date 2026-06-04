namespace LogicaNegocio;

public class FiguritaBrillante : Figurita
{
    public bool EsLimitada {get;set;}

    public FiguritaBrillante (int numero, string nombreJugador, string pais, bool esLimitada) : base (numero, nombreJugador, pais)
    {
        EsLimitada = esLimitada;
    }
}
