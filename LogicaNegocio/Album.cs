namespace LogicaNegocio;

public class Album
{
    public string NombreColeccionista {get;set;}

    protected List<Figurita> figuritas;

    public Album(string nombreColeccionista)
    {
        NombreColeccionista = nombreColeccionista;
        figuritas = new List<Figurita>();
    }

    public void AgregarFigurita(Figurita figurita)
    {
        figuritas.Add(figurita);
    }

    public void AgregarFigurita(Figurita figurita, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            figuritas.Add(figurita);
        }
    }

    public bool TieneRepetida(Figurita figurita)
    {
        int cantidad = 0;

        foreach (var f in figuritas)
        {
            if (f.Numero == figurita.Numero)
            {
                cantidad++;
            }
        }

        if (cantidad < 2)
        {
            return false;
        } else
        {
            return true;
        }
    }

    public bool TieneRepetida(int numeroDeFigurita)
    {
        int cantidad = 0;

        foreach (var r in figuritas)
        {
            if (r.Numero == numeroDeFigurita)
            {
                cantidad++;
            }
        }
        if (cantidad > 1)
        {
            return true;
        }else
        {
            return false;
        }

    }

    public List<Figurita> ObtenerRepetidas()
    {
        List<Figurita> resultado = new List<Figurita>();

        foreach (var f in figuritas)
        {
            bool yaEsta = resultado.Any(r => r.Numero == f.Numero);

            int cantidad = 0;

            foreach (var x in figuritas)
            {
                if (x.Numero == f.Numero)
                    cantidad++;
            }

            if (cantidad > 1 && !yaEsta)
            {
                resultado.Add(f);
            }
        }

        return resultado;
    }

    public List<Figurita> ObtenerFiguritas()
    {
        return figuritas;
    }
}
