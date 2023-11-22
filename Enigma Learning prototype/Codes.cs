using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Learning
{
    class Codes
    {
        private readonly List<string> theseCodes = new List<string>{ "C2Ag4yy", "D0Ft1op", "D0Ro1pp", "E3Og1js", "F5Ry3sc", "F8Ao0qk", "K1Ag4lh", "P2Dy1ah", "P5Fy1ts", "S9Gg9jf", "T1Wu6ss", "W7Ft8pq", "Z8Qa4lq" };
        public bool found = false;
        public void CheckCode(string enteredCode)
        {
            foreach (string code in theseCodes)
            {
                if (enteredCode == code)
                {
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
        }
        
    }
}
