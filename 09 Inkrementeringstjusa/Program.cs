int a = 5;
int b = 5;

Console.WriteLine($"Prefix (++a): {++a}");  // Ökar först, skriver sedan ut värdet
Console.WriteLine($"Postfix (b++): {b++}"); // Skriver först ut värdet, ökar sedan

Console.WriteLine($"Värdet på b efteråt: {b}");

Console.WriteLine($"\n\nPrefix (--a): {--a}");  // Minskar först, skriver sedan ut värdet
Console.WriteLine($"Postfix (b--): {b--}"); // Skriver först ut värdet, minskar sedan

Console.WriteLine($"Värdet på b efteråt: {b}");





Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();