using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    internal class CyberAdvice : ICyberAdvice
    {
        // Method to display a message when user wants advice on password.
        public void GetPasswordAdvice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Password Tip: " +
                "\nCreate strong, unique passwords for each account, combining uppercase and lowercase letters, numbers, and special characters, and avoid using personal information or common words.");
            Console.ResetColor();
        }

        // Method to display a message when user wants advice on phising.
        public void GetPhishingAdvice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Phishing Tip: " +
                "\nAlways verify the sender’s email address, avoid clicking on links in uninvited emails, and never provide personal or financial information unless you're certain the request is legitimate.");
            Console.ResetColor();
        }
        // Method to display a message when user wants advice on safe browsing.
        public void GetSafeBrowsingAdvice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Safe Browsing Tip: " +
                "\n Use HTTPS websites, avoid clicking on suspicious links, and keep your browser and security software updated.");
            Console.ResetColor();
        }

        //Method to display a message when a user wants advice on social engineering.
        public void GetSocialEngineeringAdvice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Social Engineering Tip: " +
            "\nBe cautious of uninvited phone calls, emails, or messages asking for sensitive information; always verify the request through official channels before responding.");
            Console.ResetColor();
        }

        //Method to display a message when a user wants advice on public wifi safety.
        public void GetPublicWifiSafetyAdvice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Public Wifi Safety: " +
            "\nAvoid accessing sensitive information or logging into accounts while using public Wi-Fi; use a Virtual Private Network (VPN) to secure your connection when necessary.");
            Console.ResetColor();
        }

        //Method to display a message when a user wants advice on device safety.
        public void GetDeviceSafetyAdvice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Device Safety Tip: " +
            "\nKeep your devices secure by enabling password protection, using encryption, and regularly updating software to protect against vulnerabilities.");
            Console.ResetColor();
        }
    }
}