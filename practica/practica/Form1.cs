using practica.Data;
using practica.Negocio;
using practica.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona per21 = new persona();
            per21.nombrePersona = txtNombre.Text;
            per21.descripcionPersona = txtDescripcion.Text;
            per21.edadPersona = int.Parse(txtEdad.Text);
            ClsPersona clspersona = new ClsPersona();
            clspersona.Guardar(per21);
            clspersona.Guardar(per21);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Formspersona formspersona = new Formspersona();
            formspersona.Show();

        }
    }
}
