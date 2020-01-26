using System;

namespace Nueva_carpeta
{
    class Program
    {
        static void Main(string[] args)
        {
            var tarea = new Sprintbacklog();

        string userstory;
        userstory =  tarea.solicitarus();           // ahora estas funciones de devuelven valores.... ya no son "void" 
        
        double horas;
        horas = tarea.solicitarhs();

        var clasificar = new Task();


        clasificar.definircomplejidad(horas);
        clasificar.calcularhstask(horas);

        
        }
    }
}
