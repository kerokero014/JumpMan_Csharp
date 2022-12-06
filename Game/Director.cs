namespace Unit03.Game
{

    public class Director
    {
        private Jumper jumper = new Jumper();
        private bool wordFound = false;
        private Puzzle puzzle = new Puzzle();
        private TerminalService terminalService = new TerminalService();

        private string currLetter = "";
        private bool isLetter = false;
        private static int lives = 8;

 
        public Director()
        {
        }

        public void StartGame()
        {
            while (!wordFound && lives > 0)
            {
                DoOutputs();
                GetInputs();
                DoUpdates();
            }

            // Display the end of game messages. 
            DoOutputs();
            if (wordFound)
            {
                terminalService.WriteText("Great job! You found the word!");
            }
            else if (lives == 0)
            {
                terminalService.WriteText("You didn't find the word :(");
                terminalService.WriteText("Better luck next time :)).\n");
            }
            
        }

        private void GetInputs()
        {
            currLetter = terminalService.ReadText("Guess a leter [a-z]: ");
            terminalService.WriteText(" ");
        }


        private void DoUpdates()
        {
            isLetter = puzzle.CompareLetter(currLetter);
            if (!isLetter)
            {
                lives -= 1;
            }
            wordFound = puzzle.CompareProgress();
        }

        private void DoOutputs()
        {
            terminalService.WriteList(puzzle.GetGuessedLetters());
            terminalService.WriteList(jumper.BuildParachute(lives));
        }
    }
}