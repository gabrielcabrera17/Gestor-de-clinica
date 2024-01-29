using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modelo.Maping
{
    public abstract class Abstractdatemodel
    {
        public Int32 id { get;  set; }
        public abstract  void Guardar() ;
        public abstract void Borrar();
        
    }
  
}
