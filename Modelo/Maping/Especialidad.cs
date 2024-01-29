using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Maping
{
    public class Especialidad : Abstractdatemodel
    {
        public string descripcion { get; set; }

        //constructor
        public Especialidad(string descripcions)
        {
            this.descripcion = descripcions;
        }
        public Especialidad(int iD, string descripcions)
        {
            this.id = iD;
            this.descripcion = descripcions;
        }
        public string nombreEspecialidad()
        {
            return descripcion +"("+id+")";
        }
        public override void Guardar()
        {
            if(0 == base.id)
            {
                base.id = new Random().Next(1000);
            }
            Utilitarios.Lista_especialidades[base.id] = this;
        }
        public static Array obtenerDatosEspecialidad()
        {
            return Utilitarios.Lista_especialidades.Values.ToArray();
        }
        public override void Borrar()
        {
            Utilitarios.Lista_especialidades.Remove(this.id);
        }
    }
}
