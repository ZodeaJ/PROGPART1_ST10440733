using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    // Class named Chatbot that inherits from class named CyberAdvice.
    internal class Chatbot : CyberAdvice
    {
        //Array list for example for passwords.
        private static List<string> passwords = new List<string>
    {
        "P@ssw0rd!",
        "Tr0ub4dor&3",
        "S3cur3Key#1"
    };
        // Static Random instance to ensure proper randomization
        private static Random rng = new Random();

        public static void StartChat(string userName)
        {
            // Instance of CyberAdvice.
            CyberAdvice advice = new CyberAdvice();

            //Personalised greeting to user with instructions.
            Console.WriteLine("Chat: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Ask me about cybersecurity topics like:");
            Console.WriteLine("  - How are you?");
            Console.WriteLine("  - What's your purpose?");
            Console.WriteLine("  - What can I ask you about?");
            Console.WriteLine("  - Exit (to quit)\n");
            Console.ResetColor();

            //Chat Loop.
            while (true)
            {
                Console.Write("\nYou: ");
                string userInput = Console.ReadLine()?.Trim().ToLower();

                //IF statement for when user enters incorrectly or nothing at all.
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I didn't quite understand that. Please make sure you entered correctly");
                    Console.ResetColor();
                    continue;
                }

                //IF statement for when user wants to exit.
                if (userInput == "exit")
                {
                    //Goodbye message when user chooses to exit.
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Goodbye! Stay safe online.");
                    Console.ResetColor();
                    break;
                }

                Console.Write("Chatbot: ");
                switch (userInput)
                {
                    //Case when user asks chat how are you.
                    case "how are you?":
                    case "how are you":
                        Console.WriteLine("I'm doing well, thanks for asking!");
                        break;

                    //Case when user asks chat whats your purpose.
                    case "what's your purpose?":
                    case "whats your purpose":
                        Console.WriteLine("My purpose is to educate you on attacks online and help you avoid it");
                        break;

                    //Case when user asks chat what can i ask you about
                    case "what can i ask you about?":
                    case "what can i ask you about":
                        Console.ForegroundColor= ConsoleColor.Cyan;
                        Console.WriteLine("You can ask me about:\n 1) Password Safety\n 2) Phishing\n 3) Safe Browsing \n 4) Device Safety " +
                            "\n 5) Social Engineering \n 6) Public Wifi Safety");
                        Console.ResetColor();
                        break;

                    //Multiple cases to try an cover all different options the user would choose for password.
                    case "tell me about password safety":
                    case "password safety":
                    case "strong password":
                    case "1":
                    case "how can i create a strong password?":
                        advice.GetPasswordAdvice();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Example password:" + passwords[rng.Next(passwords.Count)]);
                        Console.ResetColor();
                        break;

                    //Multiple cases to try an cover all different options the user would choose for phishing.
                    case "phishing":
                    case "tell me about phishing":
                    case "2":
                        advice.GetPhishingAdvice();
                        break;

                    //Multiple cases to try an cover all different options the user would choose for safe browsing.
                    case "safe browsing":
                    case "tell me about safe browsing":
                    case "3":
                        advice.GetSafeBrowsingAdvice();
                        break;

                    //Multiple cases to try an cover all different options the user would choose for device safety.
                    case "device safety":
                    case "tell me about device security":
                    case "4":
                        advice.GetDeviceSafetyAdvice();
                        break;

                    //Multiple cases to try an cover all different options the user would choose for social engineering.
                    case "social engineering":
                    case "tell me about social engineering":
                    case "5":
                        advice.GetSocialEngineeringAdvice();
                        break;

                    //Multiple cases to try an cover all different options the user would choose for public wifi safety.
                    case "public wifi safety":
                    case "tell me about public wifi safety":
                    case "6":
                        advice.GetPublicWifiSafetyAdvice();
                        break;

                    //Default case for when user chooses options not covered.
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("I'm not sure about that. Please check if you have chosen the options listed.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
