// C# 9.0 Code for Lambda

// We used to declare the function as like shown in the following code
// the below function returns a string

Func<string> printMessage = () => "Hi, I am a Lambda";

Console.WriteLine(printMessage());

// But writig the above code with was not having default type inference 
// e.g. wrting the following code was producting the error
// Having <LangVersion>9</LangVersion> in project file will generate an error

// But this is allowed in C# 10

var printMessageNew = () => "Hi, I am a New Lambda";
Console.WriteLine(printMessageNew());



