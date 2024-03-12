namespace Modelo;
public class Lampada
{
    private bool ligada;

    public Lampada(bool estadoInicial)
    {
        ligada = estadoInicial;
    }

    public void Ligar()
    {
        ligada = true;
    }

    public void Desligar()
    {
        ligada = false;
    }

    public void Imprimir()
    {
        if (ligada)
        {
            Console.WriteLine("Lâmpada ligada");
        }
        else
        {
            Console.WriteLine("Lâmpada desligada");
        }
    }
}
