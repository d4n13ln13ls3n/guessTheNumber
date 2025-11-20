using System;

namespace guessing_number;

public class Program
{
    public static void Main()
    {
        string playAgain;

        do
        {
            GameFlow();

            Console.WriteLine("Você quer jogar novamente? Digite SIM ou NÃO.");
            string? input = Console.ReadLine();   // nullable
            playAgain = input?.ToUpper() ?? "";   // safe normalization
        }
        while (playAgain == "SIM");
            
        Console.WriteLine("Obrigado pela participação. Até o próximo jogo!");
    }
    public static void GameFlow()
        {
            GuessNumber game = new GuessNumber();
            Console.WriteLine(game.Greet());

            int difficultyLevel;

            Console.WriteLine(
            "Escolha um nível de dificuldade para o jogo:\n" +
            "1: nível fácil (-100 a 100)\n" +
            "2: nível médio (-500 a 500)\n" +
            "3: nível difícil (-1000 a 1000)"
            );

            string? inputDifficulty = Console.ReadLine();
            string difficultyByUser = inputDifficulty ?? "";

            // while difficultyByUser is not a number or it's not a number between 1 and 3, asks user to type a valid option

            while (!int.TryParse(difficultyByUser, out difficultyLevel) || difficultyLevel < 1 || difficultyLevel > 3)
            {
                Console.WriteLine("Entrada inválida! Digite 1, 2 ou 3.");
                difficultyByUser = Console.ReadLine() ?? "";
            }

            game.difficultyLevel = difficultyLevel;

            Console.WriteLine(game.RandomNumberWithDifficult());

            do
            {
                Console.WriteLine("Agora tente adivinhar o número que eu pensei:");

                string? inputGuess = Console.ReadLine();

                string userEntry = inputGuess ?? "";

                Console.WriteLine(game.ChooseNumber(userEntry));

                Console.WriteLine(game.AnalyzePlay());
            }
            while (!game.gameOver);
        }
}
