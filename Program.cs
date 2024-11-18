using berek2020;
using System.Text;

List<Dolgozo> dolgozok = [];

using StreamReader sr = new("berek2020.txt", Encoding.UTF8);
while (!sr.EndOfStream)
{
    dolgozok.Add(new(sr.ReadLine()));
}

Console.WriteLine($"3. feladat: Dolgozók száma: {dolgozok.Count}");

int ossz = 0;
for (int i = 0; i < dolgozok.Count; i++)
{
    ossz += dolgozok[i].Ber;
}
Console.WriteLine($"4. feladat: Bérek átlaga: {ossz/dolgozok.Count/1000:0.0} eFt");

Console.Write("5. feladat: Kérem a részleg nevét: ");
string reszleg = Console.ReadLine();

bool sv = false;
int maxber = 0;
string maxnev = "";
string maxnem = "";
int maxbelepes = 0;
for (int i = 0;i < dolgozok.Count;i++)
{
    if (dolgozok[i].Reszleg == reszleg)
    {
        sv = true;
        if(maxber < dolgozok[i].Ber)
        {
            maxber = dolgozok[i].Ber;
            maxnev = dolgozok[i].Nev;
            maxnem = dolgozok[i].Nem;
            maxbelepes = dolgozok[i].Belepes;
        }
    }
}
if (sv)
{
    Console.WriteLine("Feladat 6: A legtöbbet kereső dolgozó a részlegen");
    Console.WriteLine($"\tNev: {maxnev}");
    Console.WriteLine($"\tNem: {maxnem}");
    Console.WriteLine($"\tBelépés: {maxbelepes}");
    Console.WriteLine($"\tBér: {maxber} Ft");
}
else Console.WriteLine("A megadott részleg nem létezik a cégnél!");

var f7 = dolgozok.GroupBy(v => v.Reszleg);
Console.WriteLine($"Feladat 7: Statisztika");
foreach (var g in f7)
{
    Console.WriteLine($"\t{(g.Key)} - {g.Count()} fő");
}