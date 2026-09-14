// 1 = Read (001), 2 = Write (010), 4 = Execute (100)
int read = 1;
int write = 2;
int execute = 4;
int minaRättigheter = read | write; // Slår ihop (011) - Read och Write
Console.WriteLine($"Har Read: {(minaRättigheter & read) == read}");
Console.WriteLine($"Har Execute: {(minaRättigheter & execute) == execute}");




Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();