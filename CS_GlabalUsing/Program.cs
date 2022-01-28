// using System.Text.Json;


var Characters = new List<string>() { 
   "James Bond", "Ethan Hunt", "Jack Reacher", "Indiana Jnes", "Jason Bourn"
};

Console.WriteLine($"Characters {JsonSerializer.Serialize(Characters)}");
 