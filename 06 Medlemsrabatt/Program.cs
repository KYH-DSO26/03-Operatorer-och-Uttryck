bool ärGuldMedlem = false;
bool ärSenior = true;
decimal köpBelopp = 550.00m;


// && har högre precedens än ||, så det är viktigt att använda parenteser för att
// tydliggöra logiken om det behövs.
// I detta fall är det dock korrekt som det är.
bool fårRabatt = ärGuldMedlem || (ärSenior && köpBelopp > 500m);

Console.WriteLine($"Får rabatt: {fårRabatt}");




Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();