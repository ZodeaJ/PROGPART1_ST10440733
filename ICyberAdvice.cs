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
        public void GetPasswordAdvice();
        public void GetPhishingAdvice();
        public void GetSafeBrowsingAdvice();
        public void GetSocialEngineeringAdvice();
        public void GetPublicWifiSafetyAdvice();
        public void GetDeviceSafetyAdvice();
    }
}