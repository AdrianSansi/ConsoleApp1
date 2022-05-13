using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ValidaEntradas
    {
        public int ValidaTipo(string tipo)
        {
            if (tipo == "Once") { return 0; }
            else if (tipo == "Recurring") { return 1; }
            else { return -1; }
        }
}
