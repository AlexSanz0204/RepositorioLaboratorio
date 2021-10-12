using practica.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica.Vista
{
    public partial class Formspersona : Form
    {
        public Formspersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsPersona clspersona = new ClsPersona();
            var person = clspersona.ListFinal();
            foreach (var interar in person)
            {
                CUADROLIST.Rows.Add(interar.idpersona, interar.nombrePersona, interar.edadPersona, interar.descripcionPersona);

            }
        }
    }
}