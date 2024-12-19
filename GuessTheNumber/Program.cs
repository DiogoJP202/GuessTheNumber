Random random = new Random();
int secretNumber = random.Next(1, 101);
int userGuess = 0;
int count = 0;

while(userGuess != secretNumber)
{
    Console.WriteLine("Enter your guess: ");
    userGuess = int.Parse(Console.ReadLine());
    count++;

    if(userGuess < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    } else if(userGuess > secretNumber)
    {
        Console.WriteLine("Too high! Try again.");
    } else
    {
        Console.WriteLine($"Congratulations! You guessed the number right! It took you {count} tries.");
    }
}

Console.ReadKey();