using CSHARP25012101;

const string PATH = "..\\..\\..\\RES\\fob2016.txt";
List<Versenyzo> versenyzok = [];

using StreamReader sr = new(PATH);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat: versenyzok szama: {versenyzok.Count}");

