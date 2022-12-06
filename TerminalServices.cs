namespace jumper.Game 
{

    public class TerminalService 
    {

        public TerminalService()
        {
        }

        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public string Input(string s)
        {
            Console.Write(s);
            string response = Console.ReadLine();
            Console.WriteLine();
            return response;
        }

        public void DisplayGame(GameBoard gb)
        {
            string spaces = "";
            foreach (string letter in gb.GetSpaces())
            {
                spaces += letter + " ";
            }
            Console.WriteLine(spaces);
            Console.WriteLine();
            foreach (string line in gb.GetBoard())
            {
                Console.WriteLine(line);
            }
        }
    }

}