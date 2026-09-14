int godisar = 23;
int vänner = 4;

int perPerson = godisar / vänner;
int över = godisar % vänner;

Console.WriteLine($"Varje person får {perPerson} godisar. Det blir {över} kvar i påsen");




Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();