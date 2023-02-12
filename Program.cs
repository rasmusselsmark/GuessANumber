// opret instans af vores spil klasse
var game = new GuessANumberGame();

// og start spillet
game.Start();


/// <summary>
/// Vores C# klasse som indeholder gæt-et-tal spillet
/// </summary>
public class GuessANumberGame
{
    // her definerer vi maximum for tallet der skal gættes
    private const int Max = 100;

    // tallet vi skal gætte
    private int secretNumber;

    public void Start()
    {
        WriteWelcomeMessage();
        FindSecretNumber();

        int guess;
        do
        {
            guess = GetUserGuess();

            if (guess < secretNumber)
            {
                Console.WriteLine("Du gættede for lavt, prøv igen.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Du gættede for højt, prøv igen.");
            }
            Console.WriteLine();
        } while (guess != secretNumber);

        Console.WriteLine("Du gættede tallet, flot klaret!");
    }

    /// <summary>
    /// Skriv en velkomstbesked til spilleren.
    /// </summary>
    private void WriteWelcomeMessage()
    {
        Console.WriteLine($"Hej, jeg tænker på et tal mellem 1 og {Max}, prøv at gætte det!");
        Console.WriteLine();
    }

    /// <summary>
    /// Find det hemmelige tal, som spilleren skal gætte.
    /// </summary>
    private void FindSecretNumber()
    {
        secretNumber = new Random().Next(Max);
    }

    /// <summary>
    /// Lad spilleren indtaste gæt. Fortsætter indtil man har indtastet et heltal.
    /// </summary>
    /// <returns>Heltal med brugerens gæt</returns>
    private int GetUserGuess()
    {
        while (true)
        {
            Console.Write("Indtast dit gæt: ");
            var input = Console.ReadLine();

            // check at vi indtastede integer / heltal
            if (int.TryParse(input, out int guess))
            {
                return guess;
            }

            Console.WriteLine("Du skal indtaste et heltal.");
        }
    }
}
