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
