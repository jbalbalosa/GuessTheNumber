// See https://aka.ms/new-console-template for more information

Random random = new Random();
int secretNumber = random.Next(1, 100);
int userGuess = 0;
int userTries = 0;
int maxTries = 5;

Console.WriteLine($"Guess the Number I'm thinking of between 1 to 100, you have only 5 tries");

while (userGuess != secretNumber)
{
    Console.Write("Enter your guess:");
    userGuess = int.Parse( Console.ReadLine());

    userTries++;
    if (userGuess < secretNumber)
    {
        if (userTries < maxTries)
        {
            Console.WriteLine($"Too low, try again {userTries}/{maxTries}");
        }
        else
        {
            Console.WriteLine($"You failed! {userTries}/{maxTries}, Good bye!");
            break;
        }
    }
    else if (userGuess > secretNumber)
    {
        if (userTries < maxTries)
        {
            Console.WriteLine($"Too high, try again {userTries}/{maxTries}");
        }
        else
        {
            Console.WriteLine($"You failed! {userTries}/{maxTries}, Good bye!");
            break;
        }
    }
    else if(userGuess == secretNumber)
    {
        Console.WriteLine($"The secret is number:{secretNumber} Your guess is correct!");
    }
}

Console.ReadKey();