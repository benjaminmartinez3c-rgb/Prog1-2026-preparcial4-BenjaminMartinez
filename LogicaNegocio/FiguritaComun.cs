using System.ComponentModel;

namespace LogicaNegocio;

public class FiguritaComun : Figurita
{
    public int Rareza {get;set;}

    public FiguritaComun (int numero, string nombreJugador, string pais, int rareza) : base (numero, nombreJugador, pais)
    {
        if (rareza < 1 || rareza > 5)
        {
            throw new ArgumentException ("Rareza no puede ser menor a 1 ni mayor a 5");
        } else
        {
            Rareza = rareza;

        }
    }
}
