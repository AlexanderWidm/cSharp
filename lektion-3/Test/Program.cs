Console.WriteLine("Yabastas tävling");
Console.Write("Välj en av lådorna: 1, 2 eller 3: ");
var userInput = Console.ReadLine();
var message = (userInput == "1") ? "bil" : "kolbit";
Console.WriteLine("Du skrev in {0}, därför vann du en {1}.", userInput, message);