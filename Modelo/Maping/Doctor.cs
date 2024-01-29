using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Maping
{
    public class Doctor : Abstractdatemodel
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Documento { get; set; }
        public String Ruc { get; set; }
        public Especialidad Especialidad { get; set; }
        public Genero Sexo { get; set; }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "\t Apellido: " + this.Apellido + "\t Telefono: " + this.Telefono + "\t Documento: " + this.Documento + "\t Ruc: " + this.Ruc +"Especialidad: "+this.Especialidad +"\t Sexo: "+this.Sexo;
        }
        public override void Guardar()
        {
            if(0 == base.id)
            {
                base.id = new Random().Next(1000);
            }
            Utilitarios.Lista_doctor[base.id] = this; 
        }
        public static Array ObtenerDatosdoctor()
        {
            return Utilitarios.Lista_doctor.Values.ToArray();
        }
        public override void Borrar()
        {
            Utilitarios.Lista_doctor.Remove(this.id);
        }
    }
}
