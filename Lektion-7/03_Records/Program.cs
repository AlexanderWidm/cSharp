using _03_Records.Records;

var user = new User("Alexander", "Widmark", "widmark.alexander@gmail.com");

Console.WriteLine($"{user.firstName} {user.lastName} <{user.email}>");
Console.ReadKey();