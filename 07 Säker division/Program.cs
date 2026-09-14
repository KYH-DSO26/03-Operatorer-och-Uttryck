Console.Write("Mata in TÄLJARE: ");
double täljare = double.Parse(Console.ReadLine()!);
Console.Write("Mata in NÄMNARE: ");
double nämnare = double.Parse(Console.ReadLine()!);

double resultat = (nämnare != 0) ? täljare / nämnare : 0;

string svar = (nämnare == 0) ? "Fel: kan inte dela med noll! Resultatet satt till 0" : $"Resultat: {resultat}";
Console.WriteLine(svar);



Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();