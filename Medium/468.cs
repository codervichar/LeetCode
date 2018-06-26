using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public string ValidIPAddress(string IP)
        {
            int ipV4Len = 4, ipV6Len = 8;

            string[] ipV4 = IP.Split('.');
            
            if (ipV4.Length == ipV4Len)
            {
                bool isIpV4 = false;
                foreach(string comp in ipV4)
                {
                    int num;
                    if (comp != null && 
                        Int32.TryParse(comp, out num) && 
                        num >= 0 && 
                        num <= 255 &&
                        comp[0] != '0')
                    {
                        isIpV4 = true;
                    }
                    else
                    {
                        isIpV4 = false;
                        break;
                    }
                }
                if (isIpV4)
                    return "IPv4";
            }

            string[] ipV6 = IP.Split(':');
            if (ipV6.Length == ipV6Len)
            {
                bool isIpV6 = false;
                foreach (string comp in ipV6)
                {
                    Convert.ToInt32(comp, 16);
                    int num;
                    if (comp != null && comp.Length <= 4 && 
                        Int32.TryParse(comp, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out num) &&
                        num >= 0 &&
                        num <= 65535 )
                    {
                        isIpV6 = true;
                    }
                    else
                    {
                        isIpV6 = false;
                        break;
                    }
                }
                if (isIpV6)
                    return "IPv6";
            }

            return "Neither";
        }

        
    }
}
