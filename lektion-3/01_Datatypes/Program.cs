/* String - till för text

    string firstName = "Alex";
    var lastName = "Widmark";


string firstName = "Alex";
var lastName = "Widmark";

string sentence = "Jag är \"bäst\" i hela världen";
string uri_1 = "c:\\users\\alex\\document";
string uri_2 = @"c:\users\hans\document";

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);



string email = "widmark.alexander@gmail.com";
Console.WriteLine($"Original: {email}");
Console.WriteLine($"toUpper: {email.ToUpper()}");
Console.WriteLine($"toUpper: {email.ToLower()}");

string firstName = "Alex ";
string lastName = "Widmark";
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}");

string sentence = "Här har vi en text som är på svenska.";
Console.WriteLine(sentence.Replace("ä", "a"));

string name = "Alexander Widmark";
string domain = "domain.com";
string emailadress = $"{name}@{domain}";
Console.WriteLine(emailadress);

emailadress = emailadress.Replace(" ", ".").ToLower();
Console.WriteLine(emailadress);

String - till för text...
*/

/*
    INTEGRALS & FLOATING POINTS
--------------------------------------------

    Type        Bits        Range (min, max)
--------------------------------------------
   *byte        8           0               255
    sbyte       8           -128            127
    short       16          -32768          32767
    ushort      16          0               65535
   *int         32          -2147483648     2145483647
    uint        32          0               4294967295
   *long        64          skitlite        skitmycket
    ulong       64          0               jävligt skitmycket

    
    Type        Bytes       DECIMAL RANGE       SUFFIX
    ------------------------------------------------------
    float       4           6-9 digits          f eller F
    double      8           15-16 digits        inget eller d eller D
   *decimal     16          28-29 digits        m eller M

    int age = 28;
    long age = 28;


    float floatValue = 0.1f + 0.1f + 0.1f; //0.3
    Console.WriteLine(floatValue);

    float = 1.123456789f;
    double = 1.123456789012345;
    decimal = 1.1234567890123456789012345678m

    double doubleValue = 0.1 + 0.1 + 0.1;
    Console.WriteLine(doubleValue);




    decimal decimalValue = 0.1m + 0.1m + 0.1m;
    Console.WriteLine(decimalValue);

*/

/*
    BOOLEAN - Sant/falskt

    TYPE        Bits
    ---------------------------------------
    bool        0/1         false/true


bool isEnabled = false;
bool isActive = true;

*/

/*
    GUID/UUID (Globally Unique Identifier)
    
    TYPE        Bits
    -----------------------------------------------------------------------------------------
    Guid        16 bytes        Guid.NewGuid();         34d6989c-17e9-4dd1-81a2-9690fd41e27f
    


Guid userId = Guid.NewGuid();
Console.WriteLine(userId);

*/

