# C#10
1. Glabal Using
	- Instead of having a 'using' statement for importing namespaces in each code file, add a new file in the project e.g. Using.cs and in this file import namespaces as
		- global using [NAMESPACE]
			- e.g. global using System.Text.json;
		- so now the 'System.Text.json' namespace will be available for all code files in the project and we can use classes under this namespaces.
	- Alternatively you can also modify the Project file (.csproj) and and the using tag under the Itemgroup tag as shown below
		- 