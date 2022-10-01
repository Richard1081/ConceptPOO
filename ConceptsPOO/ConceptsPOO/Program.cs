// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");
try
{
	Console.WriteLine(new Date(2022, 10, 10));
	Console.WriteLine(new Date(1981, 7, 10));
	Console.WriteLine(new Date(1985, 2, 48));
}
catch (Exception error)
{

	Console.WriteLine(error.ToString());
}
