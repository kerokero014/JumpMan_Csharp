namespace game
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
        private bool isPlaying = true;
        private SecretWord secretword = new SecretWord();
        private TerminalService terminalService = new TerminalService();
        private List<string> guessList = new List<string>();
        private List<string> parachute = new List<string>();
        private string userInput;
        private int valid;

        private char guess;
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            this.guessList = secretword.GetGuessList();
            this.parachute = jumper.getParachute();
            userInput = "";
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Gets the player's guess
        /// </summary>
        private void GetInputs()
        {
            userInput = terminalService.ReadText("Enter your guess: ");            
            terminalService.WriteText(" ");

            while(int.TryParse(userInput, out valid))
            {
                terminalService.WriteText("Invalid input");
                userInput = terminalService.ReadText("Enter your guess: ");
                terminalService.WriteText(" ");                
            }

            while (!char.TryParse(userInput, out guess))
            {
                terminalService.WriteText("Invalid input");
                userInput = terminalService.ReadText("Enter your guess: ");
                terminalService.WriteText(" ");
            }


        }

        /// <summary>
        /// 
        /// </summary>
        private void DoUpdates()
        {
            if (secretword.ContainsLetter(guess))
            {
                secretword.UpdateGuess(Convert.ToString(guess),secretword.word);
                secretword.gameWon(guessList);
            }
            else
            {
                jumper.removeLine();
                jumper.wrongGuesses();
                jumper.gameOver();
            }

            if(secretword.wordGuessed == true)
            {
                isPlaying = false;
            }

            if (jumper.isAlive == false)
            {
                isPlaying = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DoOutputs()
        {   
            terminalService.WriteListOneLine(this.guessList);
            terminalService.WriteText("");
            terminalService.WriteListManyLines(this.parachute);
            if (secretword.wordGuessed == true)
            {
                terminalService.WriteWinLine();
            }
            if (jumper.isAlive == false)
            {
                terminalService.WriteText($"Game Over. The correct word was: {secretword.GetWord()}.");                
            }
        }
    }
}