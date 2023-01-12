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

    Employee employee1 = new SalaryEmployee()
    {
        Id = 1010,
        FirstName = "Sandra",
        LastName = "Morales",
        BirthDate = new Date(1990, 5, 23),
        HiringDate = new Date(2022, 1, 15),
        IsActive = true,
        Salary = 1815453.45M
    };
    //Console.WriteLine(employee1);


    Employee employee2 = new CommissionEmployee
    {
        Id = 2020,
        FirstName = "Patricia",
        LastName = "Gutierrez",
        BirthDate = new Date(1995, 5, 23),
        HiringDate = new Date(2022, 2, 15),
        IsActive = true,
        CommissionPercentaje = .03F,
        Sales = 320000000
    };
    //Console.WriteLine(employee2);

    Employee employee3 = new HourlyEmployee
    {
        Id = 3030,
        FirstName = "Gonzalo",
        LastName = "Perez",
        BirthDate = new Date(1983, 5, 23),
        HiringDate = new Date(2022, 2, 15),
        IsActive = true,
        Hours = 123.5F,
        HourValue = 12356.56M
    };
    //Console.WriteLine(employee3);

    Employee employee4 = new BaseCommissionEmployee()
    {
        Id = 4040,
        FirstName = "Yasmin",
        LastName = "Salazar",
        BirthDate = new Date(1998, 6, 15),
        HiringDate = new Date(2021, 1, 19),
        IsActive = true,
        CommissionPercentaje = .015F,
        Sales = 58000000,
        Base = 860678.45M
    };
    //Console.WriteLine(employee4);


    ICollection<Employee> employees = new List<Employee>()
    {
        employee1,employee2,employee3,employee4
    };

    //employees.Add(employee1);
    //employees.Add(employee2);
    //employees.Add(employee3);
    //employees.Add(employee4);


    decimal payroll = 0;
    foreach (Employee employee in employees)
    {
        Console.Write($"{employee}");
        payroll += employee.GetValueToPay();
     
    }
    Console.WriteLine("\n\t                     ====================");
    Console.WriteLine($"\n\tTOTAL                  {$"{payroll:C2}",18}");


    Invoice invoice1 = new Invoice()
    {
        Id = 1,
        Description = "Iphone 13",
        Price = 5300000M,
        Quantity = 6
    };
    Console.WriteLine(invoice1);

    Invoice invoice2= new Invoice()
    {
        Id = 2,
        Description = "Pasta Premiun",
        Price = 32000M,
        Quantity = 17.5F
    };

    Console.WriteLine(invoice2);

}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}




