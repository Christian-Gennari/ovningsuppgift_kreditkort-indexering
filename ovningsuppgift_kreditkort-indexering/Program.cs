using ovningsuppgift_kreditkort_indexering;




Console.WriteLine("What do you want to do?");
Console.WriteLine("1. Generate credit mock data");
Console.WriteLine("2. List people");
Console.WriteLine("3. List cards");
Console.WriteLine("4. List transactions");
Console.Write("\n\nEnter your choice: ");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Generating mock data...");
        namn();
        break;
    case "2":
        Console.WriteLine("Listing people...");
        break;
    case "3":
        Console.WriteLine("Listing cards...");
        break;
    case "4":
        Console.WriteLine("Listing transactions...");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

void namn()
{
    Random random = new Random();

    Db db = new Db();
    Console.WriteLine("Hur många namn vill du generera? ");
    string? inputStr = Console.ReadLine();
    int input;
    if (int.TryParse(inputStr, out input))
    {
        for (int i = 0; i < input; i++)
        {
            string slumpFornamn = db.firstName[random.Next(db.firstName.Count)];
            string slumpEfternamn = db.lastName[random.Next(db.lastName.Count)];

            Console.WriteLine($"Generating name {i + 1}. {slumpFornamn} {slumpEfternamn}");

        }
    }
    else
    {
        Console.WriteLine("Invalid number entered.");
    }
}
return;

   void namn()
{
    Db db = new Db();
    Console.WriteLine("Hur många namn vill du generera? ");
    string inputStr = Console.ReadLine();
    int input;
    if (int.TryParse(inputStr, out input))
    {
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine($"Generating name {i + 1} {db.firstName} ");
            Console.ReadLine();
            
        } 
        
    }
    else
    {
        Console.WriteLine("Invalid number entered.");
    }
  }
