object input1 = "Hej Båten!";
string? text1 = input1 as string; // Säker typkonvertering med "as"
Console.WriteLine($"Resultat av as: {text1 ?? "Inte en sträng"}");

object input2 = 42;
string? text2 = input2 as string; // Säker typkonvertering med "as"
Console.WriteLine($"Resultatet av as vid fel typ: {text2 ?? "Detta var inte en sträng!"}");




Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();


