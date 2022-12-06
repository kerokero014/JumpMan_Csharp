namespace game
{
        /// <summary>
    /// <para>The Secret Word.</para>
    /// <para>
    /// The responsibility of SecretWord is to choose a random word from a list, store that word as an attribute, 
    /// check to see if the player guess is in that word, store the player's guess as a new variable, and allow other classes
    /// to get the guess.
    /// </para>
    /// </summary>
    public class SecretWord
    {
        private List<string> wordlist;
        private List<string> guessList;
        int index;
        public string word;
        string guess;

        public bool wordGuessed;
        Random random = new Random();

        /// <summary>
        /// Constructs a new instance of SecretWord. 
        /// </summary>
        public SecretWord()
        {
            //Create an array from the words txt file and then add it to a list
            string[] words = System.IO.File.ReadAllLines("game/Words.txt");
            wordlist = new List<string>(words);
            //Creates an array for player guesses that will update with correct guesses
            guessList = new List<string>();
            
            guess = "";
            word = "";

            //Sets the current win condition to false
            wordGuessed = false;

            //Choose a random word from the words list
            ChooseWord();
            CreateUnderscores();
            
        }
        /// <summary>
        /// Chooses a random word from the word list. 
        /// </summary>
        private void ChooseWord()
        {
            index = random.Next(wordlist.Count);
            word = wordlist[index];
        }

        public string GetGuess()
        {
            return guess;
        }

        public string GetWord()
        {
            return word;
        }

        public void CreateUnderscores() 
        {
            for (int i = 0; i < word.Length; i++)
            {
                guessList.Add("_");
            }
        }
        public void UpdateGuess(string guess, string word)
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                if (guess == Convert.ToString(word[i]))
                {
                    guessList[i] = Convert.ToString(word[i]);
                }
            }
        }

        public List<string> GetGuessList()
        {
            return guessList;
        }

        // Checks if the player still has any letters to guess. Returns a boolean.
        public void gameWon(List<string> guessList)
        {
            if (guessList.Contains("_") == false)
            {
                wordGuessed = true;
            }
        }

        /// <summary>
        /// Checks if the player's guess exists in the secret word. Returns a boolean. 
        /// </summary>
        public Boolean ContainsLetter(Char letter)
        {
            return word.Contains(letter);
        }
        
    }
}