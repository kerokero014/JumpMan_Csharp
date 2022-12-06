using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para>
    /// The responsibility of a Puzzle is to
    /// keep track of the key word and if the current letter
    /// is a part of the keyWord.
    /// </para>
    /// </summary>
    public class Puzzle
    {
        private List<string> wordList = new List<string>{"milk", "ice", "catastrophe", "orange", "fruit", "animal", "xylophone"};
        private string keyWord = "";
        private int iKeyWord = 0;
        private int lenKey = 0;
        private List<string> guessedLetters = new List<string>();
        private List<string> correctLetters = new List<string>();

        /// <summary>
        /// Constructs a new instance of Puzzle.
        /// </summary> 
        public Puzzle()
        {
            // Generate the key word here.
            Random rand = new Random();
            iKeyWord = rand.Next(wordList.Count);
            keyWord = wordList[iKeyWord];
            lenKey = keyWord.Length;

            // Generate the guessLetters.
            guessedLetters = Enumerable.Repeat("_", lenKey).ToList();

            // Generate list of strings with correct letters.
            for (int i = 0; i < lenKey; i++)
            {
                string currLetter = keyWord[i].ToString();
                correctLetters.Add(currLetter);
            }
        }

        /// <summary>
        /// Compares the current letter with the letters
        /// in the list. If it matches it updates the guessed 
        /// letters list.
        /// </summary>
        ///<param name="letter">The letter to be compared with the list.</param>
        /// <returns>True if letter is in key word and false if it is not.</returns>
        public bool CompareLetter(string letter)
        {
            bool isLetter = false;
            for (int i = 0; i < lenKey; i++)
            {
                if (letter == correctLetters[i])
                {
                    isLetter = true;
                    guessedLetters[i] = letter;
                }
                    }
            return isLetter;
        }

        /// <summary>
        /// Returns the list of guessedLetters.
        /// </summary>
        public List<string> GetGuessedLetters()
        {
            return guessedLetters;
        }

        /// <summary>
        /// Checks to see if the word has been found.
        /// </summary>
        /// <returns>true if all the letters in guessed letters have been 
        /// guessed, and false if empty spots remain. </returns>
        public bool CompareProgress()
        {
            bool areLettersSame = true;
            int i = 0;
            while (areLettersSame && i < lenKey)
            {
                if (guessedLetters[i] == "_")
                {
                    areLettersSame = false;
                }
                i++;
            }
            return areLettersSame;
        }

    }
}