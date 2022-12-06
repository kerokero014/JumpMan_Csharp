using System;
using System.Collections.Generic;


namespace Unit03.Game 
{

    public class Jumper
    {
            private string top = "    ___\n";
            private string tside ="  /___\\\n";
            private string btside ="  \\   /\n";
            private string bbside ="   \\ /\n";
            private string head ="    O \n";
            private string torso ="   /|\\\n";
            private string legs ="   / \\\n"; 
            private string air = " \n";
            private string ground = "^^^^^^^^^^^";
       
        public Jumper()
        {
        } 
 
        public List<string> BuildParachute(int lives){
            switch(lives){
                case 7: 
                top = "\n";
                break;

                case 6: 
                top = "\n";
                tside ="   ___\\\n";
                break;

                case 5: 
                top = "\n";
                tside ="   ___\n";
                break;

                case 4:
                top = "\n";
                tside ="\n";
                break;

                case 3: 
                top = "\n";
                tside ="\n";
                btside ="  \\\n";
                break;

                case 2: 
                top = "\n";
                tside ="\n";
                btside ="\n";
                break;

                case 1: 
                top = "\n";
                tside ="\n";
                btside ="\n";
                bbside ="     /\n";
                break; 

                case 0: 
                top = "\n";
                tside = "\n";
                btside = "\n";
                bbside = "\n";
                head ="    X \n";
                break;

                default:
                top = "    ___\n";
                tside ="  /___\\\n";
                btside ="  \\   /\n";
                bbside ="   \\ /\n";
                head ="    O \n";
                torso ="   /|\\\n";
                legs ="   / \\\n"; 
                air = " \n";
                ground = "^^^^^^^^^^^";
                break;
                }

            List<string> parachute = new List<string>{top, tside, btside, bbside, head, torso, legs, air, ground};
            return parachute;


        }
        




    }
}