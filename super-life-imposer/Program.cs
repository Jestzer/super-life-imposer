if (args.Contains("-version"))
{
    Console.WriteLine("Version 0.0.1");
    Environment.Exit(0);
}

string? playerInput = "broken-playerInput";

Console.WriteLine("Hi.");
Console.ForegroundColor = ConsoleColor.Yellow;
while (true)
{
    Console.WriteLine("1. Hi. 2. It's been awhile.");
    playerInput = Console.ReadLine();

    if (playerInput == "1") { break; }
    else { continue; }
}

Console.ResetColor();
