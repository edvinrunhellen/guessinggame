namespace Guessinggame;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the secret word within 5 guesses or you lose!");
        string secretWord = "github";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 5;
        bool outOfGuesses = false;
        int guessesLeft = 5; 
        
        while (guess != secretWord && !outOfGuesses)
        {
            if (guessCount < guessLimit)
            {
                Console.Write($"{guessesLeft} guesses left .. Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
                guessesLeft--;
            }
            else
            {
                outOfGuesses = true;
            }
        }

        if (outOfGuesses)
        {
            Console.Write("You lose!");
        }
        else
        {
            Console.Write("You guessed it!");
        }
    }
}