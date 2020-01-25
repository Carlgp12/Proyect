using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.NEmpleado.Login(this.txtUsuario.Text, this.txtClave.Text);

            //Evaluar si existe el usuario
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("NO tiene acceso al Sistema porque el usuario o la clave no existe","Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.IDEmpleado = Datos.Rows[0][0].ToString();
                frm.Nombre = Datos.Rows[0][1].ToString();
                frm.Apellido = Datos.Rows[0][2].ToString();
                frm.Cargo = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();
            }
        }

        private void lbRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmRecuperacionContra cs = new fmRecuperacionContra();
                cs.Show();
                
        }

      
    }
}
