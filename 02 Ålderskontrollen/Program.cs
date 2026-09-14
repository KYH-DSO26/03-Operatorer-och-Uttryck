//Console.WriteLine("02 Ålderskontrollen");
//Console.WriteLine("======================");
Console.Write("Hur gammal är du?: ");
int ålder = int.Parse(Console.ReadLine()!);
bool ärMyndig = ålder >= 18;
Console.WriteLine($"Du är myndig: {ärMyndig}");
//Console.WriteLine("======================");



Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();  