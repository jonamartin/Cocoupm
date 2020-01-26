using System;
using Proyectmanager;
public class Sprintbacklog : ProductBacklog
    {
   
    public Sprintbacklog()
    {
    }


    public string userstory;
    public string complejidad;


    public string solicitarus( )
        {
        Console.WriteLine("Ingrese la user story");
        this.userstory = Console.ReadLine();                // aca guarda en su variable userstory

        return this.userstory;                              // aca retorna ese valor para optenerlo en el programa principal 
        }


    public double solicitarhs()
        {
        Console.WriteLine("Ingrese la cantiad de horas de la carta seleccionada en estimacion");
        double horas;
        horas = Int32.Parse(Console.ReadLine());

        return horas;
        }
}
