namespace jumper.Game 
{

    public class Director
    {

        private Jumper jumper;
        private Puzzle puzzle = new Puzzle();
        private GameBoard gameBoard;
        private TerminalService term = new TerminalService();
        private bool gameOver = false;

        public Director()
        {
            jumper = new Jumper(term);
            puzzle.GenerateNewWord();
            gameBoard = new GameBoard(puzzle.GetSecretWord());
        }

        public void StartGame()
        {
            while (!gameOver)
            {
                GetInput();
                DoGameplay();
            }
        }

        public void GetInput()
        {
            term.DisplayGame(gameBoard);
            Console.WriteLine();
            jumper.MakeGuess();
        }

        public void DoGameplay()
        {
            string secretWord = puzzle.GetSecretWord();
            char guess = jumper.GetGuess();
            if (puzzle.GetisInWord(guess))
            {
                gameBoard.addLetter(guess, secretWord);
                if (gameBoard.isAWinner())
                {
                    gameOver = true;
                    term.Output("You win!! The word was \"" + secretWord + "\".");
                }
            }
            else
            {
                term.Output($"Oops! " + guess + " is not in the word!");
                gameBoard.SubParachute();
                jumper.SubParachute();
            }
            
            if (jumper.GetParachute() == 0)
            {
                gameOver = true;
                term.Output("\nGame over, man!");
            }

        }

    }

}