using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot
{
    //Interface calss IsecurityAdvice
    internal interface ICyberAdvice
    {
        //Methods for GetPasswordAdvice, GetPhishingAdvice and GetSafeBrowsingAdvice.
        void GetPasswordAdvice();
        void GetPhishingAdvice();
        void GetSafeBrowsingAdvice();
        void GetSocialEngineeringAdvice();
        void GetPublicWifiSafetyAdvice();
        void GetDeviceSafetyAdvice();
    }
}