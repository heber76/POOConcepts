// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("=========================");

//Date date1 = new Date(2023,1,11);
try
{
	////Console.WriteLine(new Date(2024, 2, 29));
	////Console.WriteLine(new Date(1974, 9, 23));
	////Console.WriteLine(new Date(1985, 11, 30));
	
	Employee employee1= new SalaryEmployee()
	{ 
		Id=1010,
		FirstName="Sandra",
		LastName="Morales",
		BirthDate=new Date(1990,5,23),
		HiringDate= new Date(2022,1,15),
		IsActive=true,
		Salary=1815453.45M
	};
	Console.WriteLine(employee1);


    Employee employee2 = new  CommissionEmployee
    {
        Id = 2020,
        FirstName = "Patricia",
        LastName = "Gutierrez",
        BirthDate = new Date(1995, 5, 23),
        HiringDate = new Date(2022, 2, 15),
        IsActive = true,
        CommissionPercentaje =.03F,
		Sales = 320000000
    };
    Console.WriteLine(employee2);



}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}




