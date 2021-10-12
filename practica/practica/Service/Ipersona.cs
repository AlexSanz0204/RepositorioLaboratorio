using practica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practica.Service
{
    interface Ipersona
    //CRUD = CREAR, LEER, ACTULIZAR, BORRAR
    {
        void create(persona persona);

        List<persona> lisTablaDePersona();

    }
}
