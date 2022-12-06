using System;


namespace Unit03.Game
{

    public class Puzzle
    {
        private List<string> wordList = new List<string>{"milk", "ice", "catastrophe", "orange", "fruit", "animal", "xylophone"};
        private string keyWord = "";
        private int iKeyWord = 0;
        private int lenKey = 0;
        private List<string> guessedLetters = new List<string>();
        private List<string> correctLetters = new List<string>();


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


        public List<string> GetGuessedLetters()
        {
            return guessedLetters;
        }

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