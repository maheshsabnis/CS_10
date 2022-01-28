

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using C# 9.0 Records");

Employee employee = new Employee()
{ 
   EmpNo = 101, EmpName = "Mahesh", DeptName = "IT", Salary = 2300000
};
Console.WriteLine($"Data = {JsonSerializer.Serialize(employee)}");

Console.WriteLine("Creating a Copy using the 'with' ");
var employee2 = employee with { EmpNo = 102, EmpName = "Tejas", Salary = 300000 };
Console.WriteLine($"Data Employee2 = {JsonSerializer.Serialize(employee)}");

Console.WriteLine("Value Equality");
Employee e1 = new();
Employee e2 = new();
Console.WriteLine(e1 == e2); // This will print 'true' because there are no values set for properties

Employee e3 = new() { EmpNo = 103 };
Employee e4 = new() { EmpNo = 104 };
Console.WriteLine(e3 == e4); // This will print 'false' because there are different values set for properties


// Using the Manager Record 
Manager manager = new Manager()
{
     EmpNo = 105, EmpName="Kumar",DeptName="IT", Salary=450000, Allowance=34000
};

Console.WriteLine($"Data Manager = {JsonSerializer.Serialize(manager)}");

public record Employee 
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; } 
    public string DeptName { get; set; }
    public int Salary { get; set; }
}


// derivtion

public record Manager : Employee 
{
    public int Allowance { get; set; }
}




 

