using System.Security.Claims;

List<byte> csapadek = new List<byte>();
Random random = new Random();
for (int i = 0; i < 366; i++)
{
    if(i>170 && i < 235)
    {
        int arany =random.Next(1, 17);
        if(arany > 1)
        {
            csapadek.Add(0);       
         }
        else
        {
            csapadek.Add((byte)random.Next(1, 19));
        }

    }
    else
    {
        int arany2 =random.Next(1, 7);
        if (arany2 > 1) {
            csapadek.Add(0);
        }
        else
        {
            csapadek.Add((byte)random.Next(1, 30));
        }
    }
}
File.WriteAllLines("C:\\adatok\\csapadek.txt", csapadek.Select(szam => szam + ""));

    
