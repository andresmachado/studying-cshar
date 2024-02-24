namespace ScreenSound.Modelos;

internal class Avaliacao
{
    private int nota;
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota
    {
        get => nota;
        set
        {
            if (value < 0) value = 0;
            if (value > 10) value = 10;
            nota = value;
        }
    }

    public static Avaliacao Parse(string text)
    {
        int nota = int.Parse(text);
        return new Avaliacao(nota);
    }
}