int max = int.MaxValue; // Maxvärdet för en int = 2147483647
Console.WriteLine($"Max int: {max}");
int uncheckedResult = max + 1; // Detta kommer att orsaka overflow,
                               // men vi använder unchecked så det slår runt i tystnad

Console.WriteLine($"Unchecked resultat (med overflow): {uncheckedResult}");

checked {
    try
    {
        int checkedResult = checked(max + 1); // Kastar exception
    }
    catch (OverflowException)
    {
        Console.WriteLine("Kombinationen orsakade ett kontrollerat OverflowException!");
    }

}



Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();