using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    internal static class EmotionHandling
    {
        //Array list for all negative words.
        private static List<string> negativeKeywords = new List<string>
        {
            "worried", "scared", "concerned", "frustrated", "anxious", "nervous", "overwhelmed", "unsure", "afraid"
        };

    //Method to provide a response regarding the negative words.
    public static void EmotionResponse(string userInput)
        {
            foreach (var word in negativeKeywords)
            {
                if (userInput.Contains(word))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nChatbot: I understand this can feel a bit overwhelming. ");
                    Console.WriteLine("But you're taking the right steps by learning. I'm here to help, one step at a time! Here's a tip: ");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}