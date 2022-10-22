using System;

namespace JumpMan{
class wordsList{

    public static int printWord(List<char>guessedLetters, string randomword)
    {
        int counter = 0;
        int rightletters = 0;
        Console.WriteLine("\r\n");

        foreach(char c in randomword){

            if(guessedLetters.Contains(c))
            {
                Console.Write(c + " ");
                rightletters++;
            }
            else
            {
                Console.Write(" ");
            }
            counter++;
        }
        return rightletters;    
    }
}
}
