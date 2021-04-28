using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHR_Interview_WebApp_Final.Models
{
    public class StateCodes
    {
        public string InputCode
        {
            get;
            set;
        }

        public List<string> Results
        {
            get;
            set;
        }

        public int? InputCodeToInt(string code) //Takes state code input and converts it to an int for traversing the binary tree.
        {
            switch (code)
            {
                case "USA":
                case "usa":
                    return 99;
                    
                case "CAN":
                case "can":
                    return 100;
                   
                case "MEX":
                case "mex":
                    return 80;
                   
                case "BEL":
                case "bel":
                    return 85;
                   
                case "GTM":
                case "gtm":
                    return 40;
                    
                case "HND":
                case "hnd":
                    return 41;
                    
                case "SLV":
                case "slv":
                    return 1;
                    
                case "NIC":
                case "nic":
                    return 42;
                    
                case "CRI":
                case "cri":
                    return 43;
                    
                case "PAN":
                case "pan":
                    return 44;
                    
                default:

                    break;
            }
            return null;
        }
    }
}
