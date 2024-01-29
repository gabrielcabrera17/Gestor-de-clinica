using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Maping
{
    public class Funcionario : Abstractdatemodel
    {
        public String Correo { get; set; }
        public String Nomnbre { get; set; }
        public String Apellido { get; set; }
        public String Rol { get; set; }
        public Genero Sexo { get; set; }
        public override string ToString()
        {
            return "\t Nombre: "+this.Nomnbre+"\t Apellido: "+this.Apellido+"\t Rol: "+this.Rol+"\t Correo: "+this.Correo + "\t Sexo: "+this.Sexo;
        }
        public override void Guardar()
        {
            if (0 == base.id)
            {
                base.id = new Random().Next(1000);
            }
            Utilitarios.Lista_funcionario[base.id] = this;
        }
        public static Array Obtenerdatos()
        {
            return Utilitarios.Lista_funcionario.Values.ToArray();
        }
        public override void Borrar()
        {
            Utilitarios.Lista_funcionario.Remove(this.id);
        }
    }
}
