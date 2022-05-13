using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class creaHorario
    {
        DateTime fechaActual { get; set; } = new DateTime();
        DateTime fechaHorario { get; set; } = new DateTime();

        public creaHorario()
        {
            fechaActual = DateTime.Today;
            fechaHorario = DateTime.Today;

        }
        public int ValidaTipo(string tipo)
        {
            if (tipo == "Once") { return 0; }
            else if (tipo == "Recurring"){return 1; }
            else { return -1; }
        }
        public void SumaRecurrencia(string recurrencia, int cantidad)
        {
            switch (recurrencia)
            {
                case "Dialy":
                    fechaHorario.AddDays(cantidad);
                    break;
                case "Weekly":
                    fechaHorario.AddDays(cantidad);
                    break;
                case "Monthly":
                    fechaHorario.AddMonths(cantidad);
                    break;
                default:
                    fechaHorario.AddYears(cantidad);
                    break;               

            }
            
           
        }



    }
}
