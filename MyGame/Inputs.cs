using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    internal class Inputs
    {
        //Load list of available keyboard buttons
        private static Hashtable keyTable=new Hashtable();

        //perform a check to create if a particular button is pressed.
        public static bool keyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }
        //detect if a keyboard button is pressed
        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
