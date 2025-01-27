using kajak_kenuKolcsonzo;
using System.Text;

List<Kolcsonzes> kolcsonzesek = new();

using StreamReader sr = new StreamReader(
    path: @"..\..\..\src\kolcsonzes.txt",
    encoding: Encoding.UTF8);
    sr.ReadLine();
    while (!sr.EndOfStream)
    {
        kolcsonzesek.Add(new Kolcsonzes(sr.ReadLine()));
    }

Console.WriteLine("4.feladat");
Console.WriteLine($"{kolcsonzesek.Count} kölcsönzés adatai találhatók a forrásállományban");

Console.WriteLine("\n5.feladat");
Console.Write("Add meg a neved: ");
string nev = Console.ReadLine().ToLower();

var talalatok = kolcsonzesek.FindAll(k => k.Nev.ToLower() == nev);

if (talalatok.Count == 0)
{
    Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
}
else
{
    Console.WriteLine($"{nev.ToUpper()} kölcsönzései:");
    foreach (var kolcsonzes in talalatok)
    {
        Console.WriteLine($"  {kolcsonzes.ElvitelOraja}:{kolcsonzes.ElvitelPerce:00} - {kolcsonzes.VisszahozatalOraja}:{kolcsonzes.VisszahozatalPerc:00}");
    }
}

Console.WriteLine("\n6.feladat");
var n = kolcsonzesek.FindAll(k => k.Nev.Contains(","));

Console.WriteLine($"Külföldiek száma: {n.Count}\nMagyarok száma: {kolcsonzesek.Count- n.Count}");
