using System; 

namespace JumpMan{
internal class board{
    public static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("  ___");
                Console.WriteLine(" /___\\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
                Console.WriteLine("   O   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");

            }
            else if (wrong == 1)
            {
                Console.WriteLine(" /___\\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
                Console.WriteLine("   O   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
            else if (wrong == 2)
            {
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
                Console.WriteLine("   O   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("  \\ /");
                Console.WriteLine("   O   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
            else if (wrong == 4)
            {

                Console.WriteLine("   O   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
            else if (wrong == 5)
            {

                Console.WriteLine("   X   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^");
            }
        }
    }
}
        ///Console.WriteLine("  ___");
        ///Console.WriteLine(" /___\\");
        ///Console.WriteLine(" \\   /");
        ///Console.WriteLine("  \\ /");
        ///Console.WriteLine("   O   ");
        ///Console.WriteLine("  /|\\  ");
        ///Console.WriteLine("  / \\");
        ///Console.WriteLine("");
        ///Console.WriteLine("^^^^^^^^");   