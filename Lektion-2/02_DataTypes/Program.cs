/*
    C# Standard datatyper som används
    ___________________________________________
    string          till för text               string name = "Alex";
    int             till för heltal             int age = 28;
    long            till för heltal             long age = 28;
    decimal         till för decimaltal         decimal length = 178m;
    double          till för decimaltal         double length = 178;
    float           till för decimaltal         double length = 178f;
    bool            till för sant/falskt        bool isHuman = true;
    char            till för enskild tecken     char gender = 'M';
    dynamic         kan inntehålla vad som      dynamic lastName = "Widmark";
    dynamic         kan inntehålla vad som      dynamic weight = "80.2";
    Guid            globalt unikt id            Guid id = Guid.NewGuid();
    byte
    null            är ingenting alls
    object
*/

/*
    Deklarera variabler i C#
    ___________________________________________
    Hur skriver vi variabelnamn:
    
    camelCase       firstName                   string firstName = "Alex";
    Pascal          FirstName                   string FirstName = "Alex";
    kebab-case      first-name                  string first-name = "Alex";
    snake_case      first_name                  string first_name = "Alex";

    C# använder sig primärt av Pascal men även camelCase

    Korrekt sätt att deklarera:                 string firstName = "Alex";
    Latmansättet att deklarera:                 var firstName = "Alex";
    
    
*/

/*
    STRING - textbaserade värden
    ------------------------------------------
    string firstName = "Alex";
    var lastName = "Widmark";

    string firstName = "Alex";
    var lastName = "Widmark";

    string sentence_1 = "Jag heter Alexander och jag är goated.";
    string sentence_2 = "Jag heter Alexander och jag är \"goated\".";

    string url_1 = "c:\\Skola\\C-Sharp";
    string url_2 = @"c:\Skola\C-Sharp";

    string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
    string placeholder_2 = $"Hej jag heter {firstName} {lastName}"; //Use this
    string placeholder_3 = string.Format("Hej jag heter {0} {1}", firstName, lastName);

    Shoutout2myboyChatGPT

*/

