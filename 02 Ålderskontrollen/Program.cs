//Console.WriteLine("02 Ålderskontrollen");
//Console.WriteLine("======================");


const int myndighetsÅlder = 18;
Console.Write("Hur gammal är du?: ");
bool ärMyndig = int.TryParse(Console.ReadLine(), out int ålder) && ålder >= myndighetsÅlder;
string svar = ärMyndig ? "Du är myndig." : "Du är inte myndig.";
Console.WriteLine(svar);




//int ålder = int.Parse(Console.ReadLine()!);
//bool ärMyndig = ålder >= 18;
//Console.WriteLine($"Du är myndig: {ärMyndig}");
//Console.WriteLine("======================");



Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();  