using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDP_GUI.CONTROLLER
{
    public class CsvNotReadyException : Exception
    {
        public CsvNotReadyException()
        {
        }

        public void CsvFileNotValid(string message)
            
        {
        }

        public void CsvFileEmpty(string message)
            
        {
        }
    }
}
