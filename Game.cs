using System;
using System.Reflection;
using static System.Random;
using System.Text;

namespace JumpMan{

    class director{
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jumpman");
            Console.WriteLine("");

            Console.WriteLine("  ___");
            Console.WriteLine(" /___\\");
            Console.WriteLine(" \\   /");
            Console.WriteLine("  \\ /");
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\  ");
            Console.WriteLine("  / \\");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^");        


            Random random = new Random();
            List<string> wordDictionary = new List<string>  {"sunflower", "vitamin", "dog", "diamond", "elephant", "fox", "hurricane", "steak", "superman", "spiderman", "nintendo", "tesla", "colombia", "headphones", "pikachu"};
            int index = random.Next(wordDictionary.Count); 
            string randomword = wordDictionary[index];

            foreach (char x in randomword)
            {
                Console.Write("_ ");
            }
            int lengthOfwordToGuess = randomword.Length;
            int amountOftimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (amountOftimesWrong != 6 && currentLettersRight != lengthOfwordToGuess)
            {
                Console.Write("\nLetters guessed so far:");
                foreach(char letter in currentLettersGuessed){
                    Console.Write(letter + " ");
                }
                //Prompt user for input
                Console.Write("\nGuess a letter [a-z]: ");

                char letterGuessed = Console.ReadLine()[0];
                ///
                if(currentLettersGuessed.Contains(letterGuessed))
                { 
                    Console.Write("\r\nYou have already guessed this letter.");
                    board.printHangman(amountOftimesWrong);
                    currentLettersRight = wordsList.printWord(currentLettersGuessed, randomword);
                    constructor.printLines(randomword);
                }
                else 
                {
                    bool right = false; 

                    for(int i = 0; i < randomword.Length; i++) { if(letterGuessed == randomword[i]) { right = true; }}

                    if(right)
                    {
                        board.printHangman(amountOftimesWrong);
                        currentLettersGuessed.Add(letterGuessed);
                        currentLettersRight = wordsList.printWord(currentLettersGuessed, randomword);
                        Console.Write("\r\n");
                        constructor.printLines(randomword);
                        
                    }
                    else
                    {
                        amountOftimesWrong++;
                        currentLettersGuessed.Add(letterGuessed);
                        board.printHangman(amountOftimesWrong);
                        currentLettersRight = wordsList.printWord(currentLettersGuessed, randomword);
                        Console.Write("\r\n");
                        constructor.printLines(randomword);
                    }
                }
            }
            Console.WriteLine("\r\nGame is over! Thank you for playing!");
        }
    }
}
///"  ___"
///" /___\\"
///" \\   /"
///"  \\ /"
///"   O   "
///"  /|\\  "
///"  / \\"
///""
///"^^^^^^^^"