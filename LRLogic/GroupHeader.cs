using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LRLogic
{
    public class GroupHeader
    {
        public static string GetHeader(string code)
        {
            string result = "";
            switch (Convert.ToInt32(Convert.ToInt32(code).ToString().Substring(0, 1)))
            {
                case 3:
                    result = "Correo ";
                    break;
                case 5:
                    result = "Correo ";
                    break;
                case 6:
                    result = "PER ";
                    break;
                case 8:
                    result = "Cyclops ";
                    break;
                case 2:
                    result = "Electronico ";
                    break;
                case 9:
                    result = "Sucursal ";
                    break;
                default:
                    result = "Payment Type ";
                    break;
            }
            return result + Convert.ToInt32(code).ToString();
        }
    }
}
