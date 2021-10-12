using practica.Data;
using practica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica.Negocio
{
    class ClsPersona : ClsRPersona
    {
        public void Guardar(persona per)
        {
            create(per);

        }

        public List<persona> ListFinal()
        {
            List<persona>lista= lisTablaDePersona();

            return lista;


        }

        
       
    }
             
  
             








    
}
