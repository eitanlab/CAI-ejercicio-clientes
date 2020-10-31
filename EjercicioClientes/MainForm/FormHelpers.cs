using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public abstract class FormHelpers
    {
        public bool emptyField(string fieldContent)
        {
            if(fieldContent == null)
            {
                return true;
            }
            return false;
        }
    }
}
