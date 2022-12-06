using System;


namespace Unit03.Game
{

    public class TerminalService
    {

        public TerminalService()
        {
        }

        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteList (List<string> letters)
        {
            int len = letters.Count;
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{letters[i]} ");
            }
            Console.WriteLine("");
        }
    }
}