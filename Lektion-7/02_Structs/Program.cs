using _02_Structs.Structs.Interopability;
using _02_Structs.Structs.Mathematic_Models;
using _02_Structs.Structs.Performance_Sensitive;
using _02_Structs.Structs.Value_Semantics;

/* Matematiska Modeller */
Vector2D vector = new Vector2D(3.0, 4.0);
Console.WriteLine($"Vector X={vector.X}, Y={vector.Y}");
Console.ReadKey();

/* Interobrabilitet */
Todo todo = new Todo() { userId = 1, id = 1, title = "delectus aut autem", completed = false };
Console.WriteLine($"Todo: {todo.id} - {todo.title}");
Console.ReadKey();

/* Prestandakänsliga Applikationer */
RGBColor color = new RGBColor(255, 0, 0);
Console.WriteLine($"Color: R={color.R} G={color.G} B={color.B}");
Console.ReadKey();

/* Värdesemantik */
Money salary = new Money(5000M, "SEK");
Console.WriteLine($"Money: Amount={salary.Amount}, Currency={salary.Currency}");
Console.ReadKey();