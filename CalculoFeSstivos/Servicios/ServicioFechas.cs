using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFeSstivos.Servicios
{
    public class ServicioFechas
    {
        public static DateTime ObtenerInicioSemanaSanta(int Año)
        {
            int a = Año % 19;
            int b = Año % 4;
            int c = Año % 7;
            int d = (19 * a + 24) % 30;

            int dias = d + (2 * b + 4 * c + 6 * d + 5) % 7;

            int dia = 15 + dias;
            int mes = 3;
            if (dia > 31)
            {
                dia = dia - 31;
                mes = 4;
            }
            return new DateTime(Año, mes, dia);
        }
        public static DateTime AgregarDias(DateTime fecha, int dias)
        {
            return fecha.AddDays(dias);
        }
        public static DateTime SiguienteLunes(DateTime fecha)
        {
            DayOfWeek diaSemana = fecha.DayOfWeek;
            if (diaSemana != DayOfWeek.Monday)
            {
                if (diaSemana > DayOfWeek.Sunday)
                {
                    fecha = AgregarDias(fecha, 8 - (int)diaSemana);
                }
                else 
                {
                    fecha = AgregarDias(fecha, 1);
                }
            }

            return fecha;
        }
    }
}
