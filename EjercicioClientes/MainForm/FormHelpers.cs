using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public static class FormHelpers
    {
        public static bool ValidarNull(string content)
        {
            if (content != null)
            {
                return true;
            }
            return false;
        }
        public static bool ValidarDni(string content)
        {
            if(ValidarNull(content))
                if(content != null && content.Length == 8)
                    return true;
            return false;
        }
    }
}
