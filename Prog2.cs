using System.Collections.Concurrent;

List<byte> csapadek = new List<byte>();
csapadek = File.ReadAllLines("C:\\adatok\\csapadek.txt").Select(sor => Convert.ToByte(sor)).ToList();

for (int i = 0; i < csapadek.Count; i++)
{

    if (csapadek[i] > 30)
    {
        Console.WriteLine("Túl sok csapadék esett");

    }
    if (i > 170 && i < 236)
    {
        if (csapadek[i] < 1 && csapadek[1] > 19)
        {
            Console.WriteLine("Túl sok csapadék esett");
        }


    }

}
if (csapadek.Count > 365)
{
        Console.WriteLine("Több adat van, mint egy év");
}