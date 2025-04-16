using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    internal class Features
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                //Writen text message todisplay when audio meassage is playing.
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('═', 100));
                Console.WriteLine("Hi there! The Cyber Security Awareness Bot welcomes you! Helping you stay secure online is my goal!", 30);
                Console.WriteLine(new string('═', 100));
                Console.ResetColor();

                string path = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "VoicePlayer.wav");

                // Play audio synchronously so that audio greeting is played before proceeding.
                using (SoundPlayer player = new SoundPlayer(path))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing audio: " + ex.Message);
                Console.ResetColor();
            }
        }

        public static void TypeLine(string message, int delay = 25)
        {
            foreach (char c in message)
            {
                Console.Write(c);

                // Delay in milliseconds between each character
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        // Method to display ASCII Art as a header/logo
        public static void DisplayASCIIArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            //ASCII ART Credited to Roland Hangg from ASCII Archive
            Console.WriteLine(@"
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |           Cyber Security                |    |
           |   |              ChatBot                    |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/
                ___________________________________________
             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
 _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
:-------------------------------------------------------------------------:
`---._.-------------------------------------------------------------._.---'
                              

                             
            ");
            Console.ResetColor();
            Thread.Sleep(50);
        }
    }
}