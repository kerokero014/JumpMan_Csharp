namespace game
{
    public class Jumper
    {
        public bool isAlive;
        private List<string> parachute = new List<string>();
        int guessCount;

        public Jumper()
        {
            isAlive = true;
            guessCount = 0;
            string[] parachuteParts = new string[]{"  ---  ",
                                              " /   \\ ",
                                              "  ---  ",
                                              " \\   / ",
                                              "  \\ /  ",
                                              "   o   ",
                                              "  /|\\  ",
                                              "  / \\  ",
                                              "       ",
                                              "^^^^^^^"};
            parachute.AddRange(parachuteParts) ;
        }
        // guess parameter will be boolean from secretWord letter guess.
        
        //takes away the top line of the parachute drawing
        public void removeLine(){
                parachute.RemoveAt(0);
            }
            
        //counts up for each wrong guess to be used in guessesRemaining
        public void wrongGuesses(){
            guessCount+= 1;
        }
        
        // checks the guessCount value for 5 or more guesses. When that condition is met,
        // sets the game state, "isAlive" to false
        public void gameOver(){
            if (guessCount >= 5){
                isAlive = false;
            }
        }
        
        public List<string> getParachute()
        {
            return parachute;
        }

    }
}