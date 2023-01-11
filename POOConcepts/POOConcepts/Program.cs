// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("=========================");

//Date date1 = new Date(2023,1,11);
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23
		));
	Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}




