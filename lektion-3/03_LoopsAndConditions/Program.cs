/*  Operander

    -----------------------------------------
    ==      lika med
    !=      inte lika med
    <       mindre än
    >       större än
    <=      mindre eller lika med
    >=      större eller lika med
    &&      och
    ||      eller
    !       inte
    ??      om första värdet är null välj det andra


    if (statement) {}
    
    if (statement) {} else {}
    
    if (statement) {} else if (statement) {} else {}
   
    (statement) ? do_this : else_do_this;



string name = "Alexander";
string firstName = "Marre";

if (name == firstName)
{
    Console.WriteLine("Namnen är lika.");
}
else
{
    Console.WriteLine("Namnen är inte lika.");
}



string firstName = "Alexander";
string lastName = "";

if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
{
    Console.WriteLine("Något av värderna är inte ifyllda.");
}

*/

/*    SWITCH
    -----------------------------------------------------------------------------------
    




string key = "black";

switch (key)
{
    case "blue":
        Console.WriteLine("Unlock blue door");
        break;

    case "orange":
        Console.WriteLine("Unlock the orange door");
        break;

    case "gray":
        Console.WriteLine("Unlock the grey door");
        break;

    default:
        Console.WriteLine("Go through the white door");
        break;
}

*/

/*  IF-Satser
    --------------------------------------------------
    if (statment) {}

    if (statement) {} else {}

    if (statement) {} else if (statement) {} else {}

    (statement) ? do_this : else_do_this;



    string firstName = "Hans";
    string lastName = null!;

    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("Något utav värdena är inte ifyllda.");
    }


    string firstName = "Hans";

    if (!string.IsNullOrEmpty(firstName))
    {
        Console.WriteLine("Nu gör vi någonting med förnamnet");
    }
    else
    {
        Console.WriteLine("Det finns inget förnamn");
    }



    string key = "blue";

    if (key == "blue")
    {
        Console.WriteLine("Unlock blue door");
    }
    else if (key == "orange")
    {
        Console.WriteLine("Unlock orange door");
    }
    else if (key == "gray")
    {
        Console.WriteLine("Unlock gray door");
    }
    else
    {
        Console.WriteLine("Go through white door");
    }



*/

/* FOR-LOOP
   -------------------------------------------------------------------------
    Vi loopar igenom en lista ller gör något ett givet antal gånger
    
    for (int = i; u < 10; i++)
    {
    
    }

    for (initialize value; condition; increment initialized value)
    {
    
    }



for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}
*/

/* FOREACH-LOOP
 --------------------------------------------
Vi loopar igenom alla objekt i en lista/array

    foreach(var object in list)
    {

    }



string[] names = new string[] { "Alex", "Erik", "Emanuel", "Yasin" };

foreach(var name in names)
{
    Console.WriteLine(name);
}

*/

/*  Arrays
----------------------------------------
    En array är en statisk lista med fixerat antal platser man varken kan lägga till nya eller ta bort stuff

 */

/*  WHILE-LOOP
 -------------------------------------------------------
    Gör en sak om och om igen tills ett tillstånd är uppnått.
    Varav kontrollen sker i början.

    while (statement)
    {
    }

    int number = 0;
    while (number < 10)
    {

    }

    i++ gör något sen öka med 1
    i-- gör något sen minska med 1
    ++i öka med 1 sen gör något
    --i minska med 1 sen gör något


    int number = 0;
    while (number < 10)
    {
    Console.WriteLine(number);
    number++;
    }
*/

/*  DO-WHILE LOOP
   ---------------------------------
    Gör loopen minst en gång sedan kollar den tillståndet

    do
    {
    } while (statement)


    int number = 0;

    do
    {
        Console.WriteLine(number);
        number++;
    } while (number < 10);

*/

