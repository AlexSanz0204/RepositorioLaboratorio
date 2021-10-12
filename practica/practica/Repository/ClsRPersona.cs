using practica.Data;
using practica.Negocio;
using practica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace practica.Repository
{
    class ClsRPersona :Ipersona
    {
        public void create(persona persona)
        {
           
            using (almacendepersonasEntities1 conxonBD = new almacendepersonasEntities1())
            {
                try
                {
                    persona per21 = new persona();

                    per21.nombrePersona = per21.nombrePersona;
                    per21.edadPersona = per21.edadPersona;
                    per21.descripcionPersona = per21.descripcionPersona;

                    conxonBD.persona.Add(persona);
                    conxonBD.SaveChanges();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("a ocurrido un error conla base de datos" + ex);

                    

                }
            }
        }

        public List<persona> LisTablaDeDatos() 
        {
            using (almacendepersonasEntities1 conxonBD = new almacendepersonasEntities1())
            {
                List<persona> lisTablaDePersona = conxonBD.persona.ToList();
                return lisTablaDePersona;
            }
                
                   
        
        
        }





        public List<persona> lisTablaDePersona()
        {
            throw new NotImplementedException();
        }
    }
}
