namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Jumper jumper = new Jumper();
        private bool wordFound = false;
        private Puzzle puzzle = new Puzzle();
        private TerminalService terminalService = new TerminalService();

        private string currLetter = "";
        private bool isLetter = false;
        private static int lives = 8;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
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

        /// <summary>
        /// Gets the letter guess from the player.
        /// </summary>
        private void GetInputs()
        {
            currLetter = terminalService.ReadText("Guess a leter [a-z]: ");
            terminalService.WriteText(" ");
        }

        /// <summary>
        /// Compares the guess and checks to see if the word has been found
        /// </summary>
        private void DoUpdates()
        {
            isLetter = puzzle.CompareLetter(currLetter);
            if (!isLetter)
            {
                lives -= 1;
            }
            wordFound = puzzle.CompareProgress();
        }

        /// <summary>
        /// Displays the letters guessed and the the state of the parachute.
        /// </summary>
        private void DoOutputs()
        {
            terminalService.WriteList(puzzle.GetGuessedLetters());
            terminalService.WriteList(jumper.BuildParachute(lives));
        }
    }
}