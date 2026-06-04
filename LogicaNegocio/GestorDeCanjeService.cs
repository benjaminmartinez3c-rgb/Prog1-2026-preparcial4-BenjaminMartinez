namespace LogicaNegocio;

public class GestorDeCanjeService
{
    protected List<Album> albums;

    public GestorDeCanjeService()
    {
        albums = new List<Album>();
    }

    public void Canjear(Album origen, Album destino, int numeroDeFigurita)
    {
        Figurita? figurita = origen.ObtenerFiguritas().FirstOrDefault(f => f.Numero == numeroDeFigurita);

    if (figurita != null)
    {
        origen.ObtenerFiguritas().Remove(figurita);
        destino.AgregarFigurita(figurita);
    }
    }
}
