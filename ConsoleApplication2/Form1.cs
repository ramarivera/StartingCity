using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo.Entities;
using NHibernate.Cfg;
using NHibernate.Exceptions;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
                Nombre = textBoxNombre.Text.ToString(),
                Direccion = textBoxDireccion.Text.ToString(),
                Telefono = textBoxTelefono.Text.ToString(),
                Fax = textBoxFax.Text.ToString()
            };
            try
            {
                var hibernateConfiguration = new Configuration().Configure();
                var sessionFactory = hibernateConfiguration.BuildSessionFactory();
                var session = sessionFactory.OpenSession();
                var tx = session.BeginTransaction();
                session.Save(empleado);
                tx.Commit();
            }
            catch (GenericADOException ex)
            {
                throw ex.InnerException;
            }
            
        }
        
    }
}
