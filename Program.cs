using CSHARP25012101;

const string PATH = "..\\..\\..\\RES";
List<Versenyzo> versenyzok = [];

using StreamReader sr = new($"{PATH}\\fob2016.txt");
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat: versenyzok szama: {versenyzok.Count}");

var f4nok = versenyzok.Count(v => !v.Kategoria);
Console.WriteLine($"4. feladat: noi versenyzok aranya: " +
    $"{f4nok / (float)versenyzok.Count * 100:0.00}%");

var f6 = versenyzok.Where(v => !v.Kategoria).MaxBy(v => v.OsszPont);
Console.WriteLine($"6. feladat: a bajnok noi versenyzo:\n{f6}");

using StreamWriter sw = new($"{PATH}\\osszpontFF.txt");
var ffs = versenyzok.Where(v => v.Kategoria);
foreach (var ff in ffs) sw.WriteLine($"{ff.Nev};{ff.OsszPont}");

var f8grps = versenyzok.GroupBy(v => v.Egyesulet)
    .Where(g => g.Key is not null && g.Count() > 2);
Console.WriteLine("8. feladat: egyesuleti statisztika:");
foreach (var g in f8grps) Console.WriteLine($"\t{g.Key, -20} {g.Count(),2} fo");