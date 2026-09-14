string korrektAnvändarnamn = "admin";
string korrektLösenord = "hemligt";

Console.Write("Ange användarnamn: ");
string användarnamn = Console.ReadLine()!;
Console.Write("Ange lösenord: ");
string lösenord = Console.ReadLine()!;

bool inloggad = ((användarnamn == korrektAnvändarnamn) && (lösenord == korrektLösenord));
Console.WriteLine($"Inloggningen lyckades: {inloggad}");




Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();