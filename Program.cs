using System.ComponentModel.Design;

namespace CyberSecurityChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Calling the voice greeting from Utilities class.
                Features.PlayVoiceGreeting();

                // Calling ASCII Art from Ultilities class in order to be displayed.
                Features.DisplayASCIIArt();

                // Prompt user for name.
                Console.Write("\n Please enter your name: ");
                string userName = Console.ReadLine()?.Trim();

                // Validate name input
                while (string.IsNullOrEmpty(userName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Name cannot be empty. Please enter your name.");
                    Console.ResetColor();
                    Console.Write("\nPlease enter your name: ");
                    userName = Console.ReadLine()?.Trim();
                }

                // Asks for favourite topi.
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\nChatbot: Before we start, {userName}, what’s your favourite cybersecurity topic? ");
                Console.Write("Choose one from the list: password, phishing, browsing, device safety, social engineering, wifi");
                Console.ResetColor();
                Console.Write("\nYou: ");

                string favouriteTopic = Console.ReadLine()?.Trim().ToLower();
                var validTopics = new List<string> { "password", "phishing", "browsing", "device safety", "social engineering", "wifi" };

                while (!validTopics.Contains(favouriteTopic))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That’s not a valid option. Please choose from the list:");
                    Console.ResetColor();
                    Console.Write("\nYour favourite topic: ");
                    favouriteTopic = Console.ReadLine()?.Trim().ToLower();
                }


                // Personalized greeting
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Welcome," + userName + "! I'm the Cybersecurity Awareness Bot.");
                Console.ResetColor();

                // Display chatbot options
                Chatbot.StartChat(userName, favouriteTopic);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
