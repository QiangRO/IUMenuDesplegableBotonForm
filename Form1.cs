using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUMenuDesplegableBotonFormV1._0
{
    public partial class InterfazUsuario : Form
    {
        public InterfazUsuario()
        {
            InitializeComponent();
            personalizarDiseño();
        }
        private void personalizarDiseño()
        {
            pnlSubMenuUsuarios.Visible = false;
            pnlSubMenuCompra.Visible = false;
            pnlSubMenuVenta.Visible = false;
            pnlSubMenuContactanos.Visible = false;
        }
        private void ocultarSubMenu()
        {
            if (pnlSubMenuUsuarios.Visible== true)
                pnlSubMenuUsuarios.Visible = false;
            if (pnlSubMenuCompra.Visible == true)
                pnlSubMenuCompra.Visible = false;
            if (pnlSubMenuVenta.Visible == true)
                pnlSubMenuVenta.Visible = false;
            if (pnlSubMenuContactanos.Visible == true)
                pnlSubMenuContactanos.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuUsuarios);
        }
        #region Submenu_Usuarios
        private void BtnUsuario1_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormUsuarios());
            ocultarSubMenu();
        }

        private void BtnUsuario2_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormUsuarios());
            ocultarSubMenu();
        }

        private void BtnUsuario3_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormUsuarios());
            ocultarSubMenu();
        }

        private void BtnUsuario4_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormUsuarios());
            ocultarSubMenu();
        }
        #endregion
        private void BtnCompra_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuCompra);
        }
        #region Submenu_Compra
        private void BtnDisponibles_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormCompra());
            ocultarSubMenu();
        }

        private void BtnAgotados_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormCompra());
            ocultarSubMenu();
        }

        private void BtnReserva_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormCompra());
            ocultarSubMenu();
        }

        private void BtnOferta_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormCompra());
            ocultarSubMenu();
        }
        #endregion
        private void BtnVenta_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuVenta);
        }
        #region Submenu_Venta
        private void BtnDatos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormVenta());
            ocultarSubMenu();
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormVenta());
            ocultarSubMenu();
        }

        private void BtnImpuestos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormVenta());
            ocultarSubMenu();
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormulariosSecundarios.FormVenta());
            ocultarSubMenu();
        }
        #endregion
        private void BtnContactanos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuContactanos);
        }
        #region Submenu_Contactame
        private void BtnInvitame_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnRedesSociales_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnWhatsApp_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void BtnSugerencias_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }
        #endregion  
        private Form formularioActivo = null;
        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}