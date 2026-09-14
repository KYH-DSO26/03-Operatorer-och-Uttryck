string? text = null;

int längd = text?.Length ?? 0;  // Om text är null, blir text?.Length null
                                // och ?? operatorn sätter längd till 0

Console.WriteLine($"Strängens längd är: {längd}");

text = "Claes";
längd = text?.Length ?? 0;  // Om text är null, blir text?.Length null
                            // och ?? operatorn sätter längd till 0

Console.WriteLine($"Strängen: {text} längd är: {längd}");


Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();