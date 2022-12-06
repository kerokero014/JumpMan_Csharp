using System;
using System.Collections.Generic;

namespace jumper.Game
{

    public class GameBoard 
    {

        public string[] aBoard = 
        {
            "  ___  ",
            " /   \\ ",
           " \\   / ",
           "  \\ /  ",
            "   0   ",
            "  /|\\  ",
            "  / \\  ",
            "        ",
            "^^^^^^^^",
        };
        public List<string> board;
        public List<string> wordSpaces = new List<string>();

        public GameBoard(string word)
        {
            ResetBoard();
            for (int i=0; i<word.Length; i++)
            {
                wordSpaces.Add("_");
            }
        }

        public void addLetter(char c, string word) 
        {
            for (int i=0; i<word.Length; i++)
            {
                if (word[i] == c)
                {
                    wordSpaces[i] = c.ToString();
                }
            }
        }

        public List<string> GetBoard()
        {
            return board;
        }

        public List<string> GetSpaces()
        {
            return wordSpaces;
        }

        public bool isAWinner() 
        {
            foreach (string space in wordSpaces)
            {
                if (space == "_")
                {
                    return false;
                }
            }
            return true;
        }

        public void SubParachute()
        {
            board.RemoveAt(0);
        }

        public void ResetBoard()
        {
            board = new List<string>(aBoard);
        }

    }

}