// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var person = new Person { 
    Id =1,
    FirstName="Mahesh",
    LastName="Sabnis"
};

WriteLine(person);

var otherperson = person with { Id = 2, LastName = "Kulkarni" };
WriteLine(otherperson);

var someOtherPerson = otherperson with { Id = 3, LastName = "Pandit" };
WriteLine(someOtherPerson);
Console.WriteLine(person.Equals(otherperson));
Console.WriteLine(otherperson.Equals(someOtherPerson));
Console.WriteLine(person == someOtherPerson );

static void WriteLine(Person person)
   => Console.WriteLine($"{person.Id}  {person.FirstName} {person.LastName}");
