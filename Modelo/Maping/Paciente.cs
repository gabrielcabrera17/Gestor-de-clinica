using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo.Maping
{
    public class Paciente : Abstractdatemodel
    {
        
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public DateTime Fecha  { get; set; }
        public String Documento { get; set; }
        public String Ruc { get; set; }
        public Genero Sexo { get; set; }

        public override string ToString()
        {
        return "Nombre: "+this.Nombre +"\t Apellido: "+this.Apellido + "\t Telefono: "+this.Telefono+"\t Sexo: "+this.Sexo + "\t Documento: "+this.Documento +"\t Ruc: "+this.Ruc + "\t Fecha:" + this.Fecha;
        }
        public override void Guardar()
        {
            if(0 == base.id)
           {
                base.id = new Random().Next(1000);
           }
            Utilitarios.Lista_paciente[base.id] = this;
        }
        public static Array obtenerDatos()
        {
            return Utilitarios.Lista_paciente.Values.ToArray();
        }
        public override void Borrar()
        { 
            Utilitarios.Lista_paciente.Remove(this.id);
        }
    }
    
    
}
