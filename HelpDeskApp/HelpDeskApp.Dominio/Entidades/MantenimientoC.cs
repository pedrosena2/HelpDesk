using System;

namespace HelpDeskApp.Dominio
{
    public class MantenimientoC
    {
        public int Id {get ; set;}
        public Incidente Incidente {get ; set;}
        public Ambiente Ambiente {get ; set;}
        public DateTime ManFechaSolucion {get ; set;}
        public string ManDescripcion {get ; set;}
  

    }
}