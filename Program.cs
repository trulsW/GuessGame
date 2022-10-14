
internal class Program
{
    private static void Main(string[] args)
    {
        bool isCorrecktGuess = false;
        Random random = new Random();   

        int randonNum = random.Next(1, 11);

        Console.WriteLine("Welcome ti the number guessing game");
        Console.WriteLine("A number between 1 and 10 will be generated.");
        Console.WriteLine("If you huess the correct number, you win! ");

        while (!isCorrecktGuess)
        {
            Console.WriteLine("Please enter your guess!");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess > randonNum)
            {
                Console.WriteLine("Your guess is to high. ");
            }
            else if (guess < randonNum)
            {
                Console.WriteLine("Your guess is to low. ");
            }
            else
            {
                Console.WriteLine("Correct");
                isCorrecktGuess = true; 
            }
        }

        Console.WriteLine("Congratulations, you have won the game!");

        Console.ReadKey();

    }
}