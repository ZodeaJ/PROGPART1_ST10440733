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

                // Personalized greeting
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Welcome," + userName + "! I'm the Cybersecurity Awareness Bot.");
                Console.ResetColor();

                // Display chatbot options
                Chatbot.StartChat(userName);
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
