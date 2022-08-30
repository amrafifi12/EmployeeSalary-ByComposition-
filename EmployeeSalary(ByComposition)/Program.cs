using EmployeeSalary_ByComposition_;

var choice = 0;
var Employee = new Base();
do
{
    Console.Clear();
    choice = ReadChoice(choice);
    if (choice >= 1 && choice <= 3)
    {
        Adds adds = null;
        switch (choice)
        {
            case 1:
                adds = new Hour();
                break;
            case 2:
                adds = new PartTime();
                break;
            case 3:
                adds = new ExtraDay();
                break;
            default:
                break;
        }
        Employee.AddSalary(adds);
        Console.WriteLine("Press any key to continue");
    }
    Console.ReadKey();
} while (choice != 0);
Console.WriteLine(Employee);
Console.ReadKey();
        

static int ReadChoice(int choice)
{
    Console.WriteLine("Available Adds");
    Console.WriteLine("------------");
    Console.WriteLine("1. Hour");
    Console.WriteLine("2. PartTime");
    Console.WriteLine("3. Extra Day");
    if (int.TryParse(Console.ReadLine(), out int ch))
    {
        choice = ch;
    }

    return choice;
}
    
