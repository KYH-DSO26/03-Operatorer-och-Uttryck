// 13. Logisk 'Short-circuiting'
bool förstaVillkor = false;

// Med && utvärderas aldrig den andra metoden eftersom det första är false
bool test1 = förstaVillkor && KörExtraKontroll();
Console.WriteLine("---");

// Med & utvärderas BÅDA villkoren oavsett resultat på första
bool test2 = förstaVillkor & KörExtraKontroll();


bool KörExtraKontroll()
{
    Console.WriteLine("Extra säkerhetskontroll kördes!");
    return true;
}





Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();