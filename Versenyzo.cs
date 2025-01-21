namespace CSHARP25012101;

internal class Versenyzo
{
    public string Nev { get; set; }
    public bool Kategoria { get; set; }
    public string? Egyesulet { get; set; }
    public int[] Pontok { get; set; } = new int[8];

    public int OsszPontszam
    {
        get
        {
            int op = 0;
            var rend = Pontok.Order().ToArray();
            if (rend[0] != 0) op += 10;
            if (rend[1] != 0) op += 10;
            for (int i = 2; i < rend.Length; i++)
                op += rend[i];
            return op;
        }
    }

    public Versenyzo(string sor)
    {
        var tmp = sor.Split(';');

        Nev = tmp[0];
        Kategoria = tmp[1] == "Felnott ferfi";
        Egyesulet = tmp[2] == "n.a." ? null : tmp[2];
        for (int i = 0; i < Pontok.Length; i++)
        {
            Pontok[i] = int.Parse(tmp[i + 3]);
        }
    }
}
