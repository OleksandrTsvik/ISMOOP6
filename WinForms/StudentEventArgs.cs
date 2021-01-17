using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class StudentEventArgs : EventArgs
    {
        public string Message { get; }

        public StudentEventArgs(string message)
        {
            Message = message;
        }
    }
}
