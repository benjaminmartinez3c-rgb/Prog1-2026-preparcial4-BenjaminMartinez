namespace LogicaNegocio;

public abstract class Figurita
{
    public int Numero {get;set;}
    public string NombreJugador {get;set;}
    public string Pais {get;set;}

    public Figurita(int numero, string nombreJugador, string pais)
    {
        if (numero <= 0)
        {
            throw new ArgumentException ("Numero de figurita no puede ser ni igual ni menor a 0");
        } else {
            Numero = numero;
        }
        if (string.IsNullOrWhiteSpace(nombreJugador))
        {
            throw new ArgumentException ("Nombre de jugador no puede ser ni nulo ni espacio en blanco");
        } else
        {
            NombreJugador = nombreJugador;
        }
        Pais = pais;
    }
}

