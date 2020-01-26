using System;
using Proyectmanager;
public class Task : Sprintbacklog
{

    private string complejidad;


    public Task()
    {
    }
    public void definircomplejidad(double horas) 
        {
        if(horas<3&&horas>0) 
        {
        this.complejidad = "facil";                                             // decir "this"  es hacer referencia a las variables que se crean arriba del constructor
        }
        else if(horas<13&&horas>2)
        {
        this.complejidad = "complicado";
        }
        else 
        {
        this.complejidad = "super complicado";
        }
  
        }

        public void calcularhstask(double horas)
        {
        if(this.complejidad.Equals("complicado"))                               //   complejidad == "Complicado"     se puede decir que es sinonimo o igual a 
        {                                                                       //   complejidad.Equals("Complicado")    la diferencia que el de arriba es un error y este es correcto
        horas = horas*1.20;
        }
        else if(this.complejidad.Equals("super complicado"))
        {
        horas = horas*1.5;
        }
        else 
        {
        horas = horas*1;
        }
        }
}
