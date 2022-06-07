using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LRLogic
{
    public class ValidateDocument
    {
        public static bool ValidateDoc(string[] lines, string date)
        {
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 0, 0, 1, "1")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 0, 1, 10, "TESTCOMANY")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 0, 11, 10, "0071000288")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 0, 21, 6, date)) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 0, 39, 2, "03")) { return false; }

            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 1, 0, 1, "2")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 1, 1, 10, "0071000288")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 1, 11, 7, "0000001")) { return false; }

            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 2, 0, 1, "5")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 2, 6, 7, "0000001")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 2, 13, 6, date)) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 2, 19, 10, "0071000288")) { return false; }
            if (!ValidateFileStructure.VerifyLBXOneLine(lines, 2, 29, 5, "00000")) { return false; }

            if (!ValidateFileStructure.VerifyLBXLength(lines, 0, 45)) { return false; }
            if (!ValidateFileStructure.VerifyLBXLength(lines, 3, 45)) { return false; }
            return true;
        }
    }
}
