namespace jumper.Game 
{

    public class Jumper 
    {
        TerminalService term;
        private char guess;
        private int parachute;

        public Jumper(TerminalService t)
        {
            term = t;
            parachute = 4;
        }

        public void MakeGuess()
        {
            guess = char.Parse(term.Input("Guess a letter [a-z]: "));
        }

        public char GetGuess()
        {
            return guess;
        }

        public void SubParachute()
        {
            parachute -= 1;
        }
        
        public int GetParachute()
        {
            return parachute;
        }

    }
    
}