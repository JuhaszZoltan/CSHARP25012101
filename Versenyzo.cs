namespace CSHARP25012101;

internal class Versenyzo
{
    public string Nev { get; set; }
    public bool Kategoria { get; set; }
    public string? Egyesulet { get; set; }
    public int[] Pontok { get; set; } = new int[8];

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
