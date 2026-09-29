void DisplayMenu()
{
    Console.WriteLine("Please enter a valid option:");
    Console.WriteLine("1. French?");
    Console.WriteLine("2. Spanish?");
    Console.WriteLine("3. German?");
    Console.WriteLine("4. Italian?");
    Console.WriteLine("0. Exit application");

    String choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.WriteLine("Bonjour!");
            break;
        case "2":
            Console.WriteLine("Hola!");
            break;
        case "3":
            Console.WriteLine("Hallo!");
            break;
        case "4":
            Console.WriteLine("Ciao!");
            break;
        case "0":
            Console.WriteLine("Exiting application...");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
DisplayMenu();

