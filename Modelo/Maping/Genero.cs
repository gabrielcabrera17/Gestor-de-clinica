using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Maping
{
    public class Genero : Abstractdatemodel
    {
        public string descripcion { get; set; }
        public Genero(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public Genero(int iD, string descripcions)
        {
            id = iD;
            descripcion = descripcions;
        }

        public override void Guardar()
        {
            if (0 == base.id)
            { 
                base.id = new Random().Next(1000);
            } 
            Utilitarios.Lista_generos[base.id]= this;
        }
        public static Array obtenerDatos()
        {
            return Utilitarios.Lista_generos.Values.ToArray();
        }
        public override void Borrar()
        {
            Utilitarios.Lista_generos.Remove(this.id);
        }

    }
}
