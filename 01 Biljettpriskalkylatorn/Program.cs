decimal grundPris = 120.00m;
int antal = 3;
decimal totalPris = grundPris * antal;

/*
if (int.TryParse(Console.ReadLine(), out int antalBiljetter) && antalBiljetter > 0)
//RAMI
*/
if (antal >= 3)
{
    //totalPris = totalPris * 0.90m;  // 10% rabatt är samma sak som att multiplicera med 0.90
    totalPris *= 0.90m;  // 10% rabatt är samma sak som att multiplicera med 0.90

    //decimal rabatt = grundPris * antal * 0.10m;  // Beräkna rabatten
    //totalPris = totalPris - rabatt;  // Dra av rabatten från totalpriset
    //totalPris -= rabatt;  // Dra av rabatten från totalpriset
}

Console.WriteLine($"Det rabatterade priset är {totalPris:F2} kr.");



Console.Write("Tryck på valfri tangent för att avsluta...");
Console.ReadKey();