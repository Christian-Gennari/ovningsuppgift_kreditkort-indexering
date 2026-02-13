using System.Diagnostics;
using System.Diagnostics;
using ovningsuppgift_kreditkort_indexering;

// Create and initialize the database
Db db = new();
db.Initialize();

Stopwatch stopwatch = new Stopwatch();

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
    Console.WriteLine("Hur många namn vill du generera? ");
    if (int.TryParse(Console.ReadLine() ?? "100000", out int input))
    {
        stopwatch.Start();

        // Ge databasen ansvaret att generera och spara namnen
        db.GenerateAndInsertUsers(input);

        stopwatch.Stop();
        Console.WriteLine(
            $"Processed {input} names in {stopwatch.Elapsed.TotalSeconds:F2} seconds."
        );
    }
}


return;
