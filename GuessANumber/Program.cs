Random Number = new Random();
int computerNumber = Number.Next(1, 101);
while (true)
{
    Console.WriteLine("Guess a number (1-100):");
    string input = Console.ReadLine();
    bool isValid = int.TryParse(input, out int playerNumber);

    switch (isValid)
    {
        case true:
            if (playerNumber == computerNumber)
            {
                Console.WriteLine("You guessed it!");
                return;
            }
            else if (playerNumber < computerNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (playerNumber > computerNumber)
            {
                Console.WriteLine("Too High");
            }
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}