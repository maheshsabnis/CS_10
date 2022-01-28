# C# 9.0
1. C# 9.0 introduces record types. You use the record keyword to define a reference type that provides built-in functionality for encapsulating data. 
	- While records can be mutable, they are primarily intended for supporting immutable data models
	- They don't support inheritance.
	- They use more memory in some scenarios, since every instance has a complete copy of all of the data. 
	- A record can inherit from another record. However, a record can't inherit from a class, and a class can't inherit from a record.
	- Syntax
```csharp
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

```

# C#10
1. Glabal Using
	- Instead of having a 'using' statement for importing namespaces in each code file, add a new file in the project e.g. Using.cs and in this file import namespaces as
		- global using [NAMESPACE]
			- e.g. global using System.Text.json;
		- so now the 'System.Text.json' namespace will be available for all code files in the project and we can use classes under this namespaces.
	- Alternatively you can also modify the Project file (.csproj) and and the using tag under the Itemgroup tag as shown below
```html
	<ItemGroup>
		<Using Include="System.Text.Json"/>
	</ItemGroup>	
```
2. File Scoped Namespaces
	- Earlier we were having the class declaraed inside the namespace
	- Now, instead of having the namespace block as shown in following code
		- 
```csharp
		namespace MyNamespace
		{
			internal class MyClass
			{
				public int Id { get; set; }
				public string Name { get; set; }
			}
		}
```
	- We can write code as shown below
		- File Scoped Namespace
```csharp
namespace MyNamespace;

    internal class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class MyClass1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

```
	- all classes in this file will be under the MyNamespace

3. Constant Interpolated Strigs
```csharp
namespace CS10_ConstantStringInterpolation;

public static class ConstaniStringInterpolation
{
    private const string BaseUrl = "/data/api";

    public static class Urls
    {
        public const string GetAll = $"{BaseUrl}/Employees";
        // C# 10 Constant String Interpolation
        public const string GetById = $"{BaseUrl}/{{eno:guid}}";
        // Traditional Concatination
        public const string GetByName = BaseUrl + "/{name:string}";
        // Earlier
        public static readonly string GetByLastName  = $"{BaseUrl}/{{eno:guid}}";
    }
}


```

4. Lambda Improvements

- C# 9.0 Code for Lambda
	- We used to declare the function as like shown in the following code
	- the below function returns a string
```csharp
Func<string> printMessage = () => "Hi, I am a Lambda";
Console.WriteLine(printMessage());
```


	- But writig the above code with was not having default type inference 
		-  e.g. wrting the following code was producting the error
		- Having 
```html		
		<LangVersion>9</LangVersion> 
```
		
	- in project file will generate an error
			- Feature 'Inferred delegate type is not available in C3 9.0'

	- But this is allowed in C# 10

```csharp
var printMessageNew = () => "Hi, I am a New Lambda";
Console.WriteLine(printMessageNew());
```