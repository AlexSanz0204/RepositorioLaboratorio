using practica.Data;
using practica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica.Negocio
{
    class ClsPersona : ClsRPersona
    {
        public void Guardar(persona per)
        {
            create(per);

        }

        public void Restriccion()
        {
            int edadPersona = 0;
            if (edadPersona >= 18)
            {
                MessageBox.Show("Registro completado satisfactoriamente");
            }
            else
                if (edadPersona < 18)
            {
                MessageBox.Show("Registro no completado, necesita ser mayor de edad");
            }
        }

        public List<persona> ListFinal()
        {
            List<persona>lista= lisTablaDePersona();

            return lista;


        }

        
       
    }
             
  
             








    
}
