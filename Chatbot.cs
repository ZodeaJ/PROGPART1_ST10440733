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

        // Variable to keep track of the current topic.
        private static string currentTopic = string.Empty;

        private static string userNameMemory = "";

        private static string favouriteTopicMemory = "";

        public static void StartChat(string userName, string favouriteTopic)
        {
            userNameMemory = userName;
            favouriteTopicMemory = favouriteTopic;

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
                string userInput = Console.ReadLine().ToLower();
                EmotionHandling.EmotionResponse(userInput);

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
                        continue;

                    //Case when user asks chat whats your purpose.
                    case "what's your purpose?":
                    case "whats your purpose":
                        Console.WriteLine("My purpose is to educate you on attacks online and help you avoid it");
                        continue;

                    //Case when user asks chat what can i ask you about
                    case "what can i ask you about?":
                    case "what can i ask you about":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You can ask me about:\n - Password Safety\n - Phishing\n - Safe Browsing \n - Device Safety " +
                            "\n - Social Engineering \n - Public Wifi Safety");
                        Console.ResetColor();
                        continue;
                }

                    //Key word detection.
                    if (userInput.Contains("password"))
                    {
                        if (favouriteTopicMemory == "password")
                        {
                            Console.WriteLine($"Ah yes, {userNameMemory}, your favourite topic! Here's some advice:");
                        }
                        advice.GetPasswordAdvice();
                        currentTopic = "password";
                    }
                    else if (userInput.Contains("phishing"))
                    {
                        if (favouriteTopicMemory == "phishing")
                        {
                            Console.WriteLine($"Ah yes, {userNameMemory}, your favourite topic! Here's some advice:");
                        }
                        advice.GetPhishingAdvice();
                        currentTopic = "phishing";
                    }
                    else if (userInput.Contains("browsing"))
                    {
                        if (favouriteTopicMemory == "browsing")
                        {
                            Console.WriteLine($"Ah yes, {userNameMemory}, your favourite topic! Here's some advice:");
                        }
                        advice.GetSafeBrowsingAdvice();
                        currentTopic = "browsing";
                    }
                    else if (userInput.Contains("device safety"))
                    {
                        if (favouriteTopicMemory == "device safety")
                        {
                            Console.WriteLine($"Ah yes, {userNameMemory}, your favourite topic! Here's some advice:");
                        }
                        advice.GetDeviceSafetyAdvice();
                        currentTopic = "device safety";
                    }
                    else if (userInput.Contains("social engineering"))
                    {
                        if (favouriteTopicMemory == "social engineering")
                        {
                            Console.WriteLine($"Ah yes, {userNameMemory}, your favourite topic! Here's some advice:");
                        }
                        advice.GetSocialEngineeringAdvice();
                        currentTopic = "social engineering";
                    }
                    else if (userInput.Contains("wifi"))
                    {
                        if (favouriteTopicMemory == "wifi")
                        {
                            Console.WriteLine($"Ah yes, {userNameMemory}, your favourite topic! Here's some advice:");
                        }
                        advice.GetPublicWifiSafetyAdvice();
                        currentTopic = "wifi";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, I didn't quite get that. Can you ask me about one of the topics?");
                        Console.ResetColor();
                        continue;
                    }

                // Follow-up for specific topics
                Console.Write("\nChatbot: ");
                if (userInput.Contains("tell me more") || userInput.Contains("explain") || userInput.Contains("know more about"))
                {
                    if (!string.IsNullOrEmpty(currentTopic))
                    {
                        Console.WriteLine($"Let me tell you more about {currentTopic}:");
                        advice.DisplayRandomTip(currentTopic);  
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("I haven't given you any advice yet. Please ask me about a topic first.");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}