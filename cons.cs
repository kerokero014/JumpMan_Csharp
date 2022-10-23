using System;

namespace JumpMan{
    class constructor
    {
        public static void printLines(string randomword)
        {
            Console.Write("\r");
            foreach(char c in randomword)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
        }
    }
}