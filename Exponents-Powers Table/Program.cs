Console.WriteLine("Welcome to the Exponents/Powers Table!");

bool runProgram = true;
while (runProgram)
{
    int input = 0;
    while (input <= 0 || input >= 1290)
    {
        Console.WriteLine("Please enter an integer for calculations: ");
        input = int.Parse(Console.ReadLine());
    }

    for (int i = 1; i <= input; i++)
    {
        Console.WriteLine($"{i}\t{SquaredFunction(i)}\t{CubedFunction(i)}");
    }
//methods

static int SquaredFunction(int input)
{
    return (input * input);
}

static int CubedFunction(int input)
{
    return (input * input * input);
}


    Console.WriteLine("Would you like to enter another integer? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        runProgram = false;
    }
}



































Console.ReadLine();