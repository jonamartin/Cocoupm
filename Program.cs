using System;
using Proyectmanager;

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

        horas = clasificar.calcularhstask(horas);
        string complejidad = clasificar.definircomplejidad(horas);

        Console.WriteLine("La cantidad de horas estimada de esta tarea es {0} hs",horas);

        Console.WriteLine("La user story de la tarea es: {0}",userstory);  

        Console.WriteLine("La tarea esta clasificada como: {0}",complejidad);    

        }
    }
}
