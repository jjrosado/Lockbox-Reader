using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LRLogic
{
    public class ValidateFileStructure
    {
        public static bool VerifyLBXOneLine(string[] lines, int lineToValidate, int startIndex, int length, string valueToValidate)
        {
            if (lines[lineToValidate].Substring(startIndex, length) != valueToValidate)
            {
                return false;
            }
            return true;
        }

        public static bool VerifyLBXLength(string[] lines, int maxLines, int maxLength)
        {
            int count = lines.Length - maxLines;
            for (int i = count; i < maxLines; i++)
            {
                if (lines[i].ToString().Length > maxLength)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
