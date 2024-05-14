using static System.Console;

string? option;

do
{
    ShowMenu();
    WriteLine("Write the number of the option you want to make: ");
    option = ReadLine();
    Clear();
    switch (option)
    {
        case "1":
            Clear();
            WriteLine("Write a number to know if it is prime or not:");
            string? strnumber = ReadLine();
            int number = int.Parse(strnumber!);
            WriteLine(IsPrime(number));
            break;

        case "2":
            Clear();
            WriteLine("Write a number to start counting:");
            string? strnumber1 = ReadLine();
            int start = int.Parse(strnumber1!);

            WriteLine("Write a number to finish the count:");
            string? strnumber2 = ReadLine();
            int finish = int.Parse(strnumber2!);

            PrintInRange(start, finish);
            break;

        case "3":
            Clear();
            WriteLine("See you next time :)");
            break;

        default:
            WriteLine("That is not an option, try a valid one");
            break;
    }
} while (option != "3");


void ShowMenu()
{
    WriteLine("1.- write a number to see if is a prime number");
    WriteLine("2.- write two numbers to see a range of prime numbers");
    WriteLine("3.- Exit program :D");
}

bool IsPrime(int number)
{
    if (number == 2)
    {
        return true;
    }

    if (number <= 1 || number % 2 == 0)
    {
        return false;
    }

    // square because is not more than the square, if 
    //number has a divider bigger than its square, also has another divider that is smaller
    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0)
        {
            return false;
        }

    }
    return true;
}

void PrintInRange(int start, int finish)
{
    for (int i = start; i <= finish; i++)
    {
        if(IsPrime(i) == true)
        {
            Write($"{i} ");
        }
    }
    WriteLine();
}