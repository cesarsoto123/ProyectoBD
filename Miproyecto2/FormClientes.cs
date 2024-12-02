using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miproyecto2
{
    public partial class FormClientes : Form
    {
        ClaseCliente cliente = new ClaseCliente();

        public void MostrarCliente()
        {
            try
            {
                DataTable dt = cliente.MuestraClientes();
                if (dt != null)
                {
                    dtgclientes.DataSource = dt;
                    dtgclientes.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public FormClientes()
        {
            InitializeComponent();
        }


        private void agbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.clave_cliente = int.Parse(tbclave.Text.Replace("-", ""));
                cliente.nombre = tbnombre.Text;
                cliente.direccion = tbdireccion.Text;
                cliente.telefono = tbtel.Text;


                cliente.agregarcliente(cliente);
                //MessageBox.Show("Cliente agregado exitosamente", "Mi Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbclave.Clear();
                tbnombre.Clear();
                tbdireccion.Clear();
                tbtel.Clear();
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void salbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.clave_cliente = int.Parse(tbclave.Text.Replace("-", ""));
                cliente.nombre = tbnombre.Text;
                cliente.direccion = tbdireccion.Text;
                cliente.telefono = tbtel.Text;

                cliente.ActualizarCliente(cliente);
                tbclave.Clear();
                tbnombre.Clear();
                tbdireccion.Clear();
                tbtel.Clear();
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.clave_cliente = int.Parse(tbclave.Text.Replace("-", ""));
                cliente.nombre = tbnombre.Text;
                cliente.direccion = tbdireccion.Text;
                cliente.telefono = tbtel.Text;

                cliente.EliminarCliente(cliente);
                tbclave.Clear();
                tbnombre.Clear();
                tbdireccion.Clear();
                tbtel.Clear();
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
