using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Project
{
    class Validator
    {
        public bool LengthCheck(string input, int min, int max)
        {
            if (input.Length <= max && input.Length >= min)
            {
                return true;
            }
            return false;
        }

        public bool PrensenceCheck(string input)
        {
            if (input == "")
            {
                return false;
            }
            return true;
        }

        public bool BlackList(string input, string [] list)
        {
            if (list.Contains(input))
            {
                return false;
            }
            return true;
        }

        public bool WhiteList(string input, string[] list)
        {
            if (list.Contains(input))
            {
                return true;
            }
            return false;
        }
    }
} 
