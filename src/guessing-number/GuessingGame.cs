using System;

namespace guessing_number;

public class GuessNumber
{
    //In this way we are passing the random number generator by dependency injection
    private IRandomGenerator random;
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;

        userValue = 0;
        randomValue = 0;
        maxAttempts = 5;
        currentAttempts = 0;
        gameOver = false;
        difficultyLevel = 1;
    }

    //user variables
    public int userValue;
    public int randomValue;

    public int maxAttempts;
    public int currentAttempts;

    public int difficultyLevel;

    public bool gameOver;

    //1 - Imprima uma mensagem de saudação
    public string Greet()
        {
            return "---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!";
        }

    //2 - Receba a entrada da pessoa usuária e converta para Int
    //5 - Adicione um limite de tentativas
    public string ChooseNumber(string userEntry)
    {
        if (gameOver) return "O jogo terminou. Deseja jogar novamente?";
        if (currentAttempts >= maxAttempts){
            gameOver = true;
            return "Você excedeu o número máximo de tentativas! Tente novamente.";
        }

        bool isValid = int.TryParse(userEntry, out int numericUserEntry);

        if (!isValid)
        {
            return "Entrada inválida! Não é um número.";
        }

        if (difficultyLevel == 1)
        {
            if (numericUserEntry < -100 || numericUserEntry > 100) {
                userValue = 0;
                return "Entrada inválida! Valor não está no range.";
            }
        }
        else if (difficultyLevel == 2)
        {
            if (numericUserEntry < -500 || numericUserEntry > 500) {
                userValue = 0;
                return "Entrada inválida! Valor não está no range.";
            }
        }
        else if (difficultyLevel == 3)
        {
            if (numericUserEntry < -1000 || numericUserEntry > 1000) {
                userValue = 0;
                return "Entrada inválida! Valor não está no range.";
            }
        }
        else {
            userValue = 0;
            difficultyLevel = 1;
            return "Entrada inválida! O nível de dificuldade vai de 1 a 3.";
        }

        userValue = numericUserEntry;
        currentAttempts++;
        return "Número escolhido!";
    }

    //3 - Gere um número aleatório
    public string RandomNumber()
    {
        randomValue = random.GetInt(-100,100);
        return "A máquina escolheu um número de -100 à 100!";
    }

    //6 - Adicione níveis de dificuldade
    public string RandomNumberWithDifficult()
    {
        if (difficultyLevel == 1) {
            randomValue = random.GetInt(-100,100);
            return "A máquina escolheu um número de -100 à 100!";
        }
        else if (difficultyLevel == 2) {
            randomValue = random.GetInt(-500,500);
            return "A máquina escolheu um número de -500 à 500!";
        }
        else if (difficultyLevel == 3) {
            randomValue = random.GetInt(-1000,1000);
            return "A máquina escolheu um número de -1000 à 1000!";
        }

        return "O nível de dificuldade precisa ser de 1 a 3.";
    }

    //4 - Verifique a resposta da jogada
    public string AnalyzePlay()
    {
        if (gameOver) return "O jogo terminou. O número era " + randomValue;
        else if (userValue < randomValue) return "Tente um número MAIOR";
        else if (userValue > randomValue) return "Tente um número MENOR";
        else if (userValue == randomValue) {
            gameOver = true;
            return "ACERTOU!";
        }
        return "O jogo terminou. O número era " + randomValue;
    }   

    //7 - Adicione uma opção para reiniciar o jogo
    public void RestartGame()
    {
        if (gameOver) {
            gameOver = false;
            currentAttempts = 0;
            randomValue = 0;
            userValue = 0;
            difficultyLevel = 1;
            maxAttempts = 5;
        }
    }
}