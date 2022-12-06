namespace jumper.Game 
{

    public class Puzzle
    {

        private string[] words;
        private string secretWord;

        public Puzzle()
        {
            words = File.ReadAllLines(".\\Game\\words.txt");
        }

        public void GenerateNewWord()
        {
            Random r = new Random();
            secretWord = words[r.Next(1, words.Length+1)];
            // Take out later 
            Console.WriteLine(secretWord);
        }

        public bool GetisInWord(char guess)
        {
            for (int i=0; i<secretWord.Length; i++)
            {
                if (secretWord[i] == guess)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetSecretWord() 
        {
            return secretWord;
        }

    }
    
}