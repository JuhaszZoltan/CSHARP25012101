using CSHARP25012101;

const string PATH = "..\\..\\..\\RES\\fob2016.txt";
List<Versenyzo> versenyzok = [];

using StreamReader sr = new(PATH);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat: versenyzok szama: {versenyzok.Count}");

var f4nok = versenyzok.Count(v => !v.Kategoria);
Console.WriteLine($"4. feladat: noi versenyzok aranya: " +
    $"{f4nok / (float)versenyzok.Count * 100:0.00}%");

