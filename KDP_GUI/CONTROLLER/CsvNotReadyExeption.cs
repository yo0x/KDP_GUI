using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDP_GUI.CONTROLLER
{
    public class EmployeeListNotFoundException : Exception
    {
        public EmployeeListNotFoundException()
        {
        }

        public void CsvFileNotValid(string message)
            : base(message)
        {
        }

        public void CsvFileEmpty(string message)
            : base(message )
        {
        }
    }
}
