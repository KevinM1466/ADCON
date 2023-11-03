using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BIT_ADCON.Forms;
using BIT_ADCON.Forms.Compañia;
using BIT_ADCON.Forms.Contratos;
using BIT_ADCON.Forms.Productos;
using BIT_ADCON.Forms.Reportes;

using Common;

using Domain.CrudsD;

using Guna.UI2.WinForms;

namespace BIT_ADCON {
    public partial class frmPrincipal : Form {
        userModel permisos = new userModel();
        private Panel leftBorderBtn;
        public Form currentChildForm;
        public frmPrincipal() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size( 7, 60 );
            pnlMenu.Controls.Add( leftBorderBtn );

            //Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void frmPrincipal_Load( object sender, EventArgs e ) {
            //lblUser.Text = UserLoginCache.firstName + " " + UserLoginCache.lastName;
            permisos.Permisos(btnContratos, btnProductos, btnCompañia, btnReportes);
        }

        private void OpenChildForm( Form childForm ) {
            if ( currentChildForm != null ) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlDesktop.Controls.Add( childForm );
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnInicio_Click( object sender, EventArgs e ) {
            if ( currentChildForm == null ) {
                //Code
            } else {
                currentChildForm.Close();
            }
        }

        private void btnContratos_Click( object sender, EventArgs e ) {
            OpenChildForm(new frmMenuContratos());
        }

        private void btnProductos_Click( object sender, EventArgs e ) {
            OpenChildForm( new frmMenuProductos() );
        }

        private void btnCompañia_Click( object sender, EventArgs e ) {
            OpenChildForm( new frmMenuCompania() );
        }

        private void btnReportes_Click( object sender, EventArgs e ) {
            OpenChildForm( new frmMenuReportes());
        }

        private void btnCerrarSesion_Click( object sender, EventArgs e ) {
            const string message = "¿Está seguro de que desea cerrar sesión?";
            const string caption = "Cerrar Sesión";
            var result = MessageBox.Show( message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question );

            if ( result == DialogResult.Yes ) {
                this.Close();
            }
        }

        private void btnSalir_Click( object sender, EventArgs e ) {
            const string message = "¿Está seguro de que desea cerrar el programa?";
            const string caption = "Cierre de formulario";
            var result = MessageBox.Show( message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question );

            if ( result == DialogResult.Yes ) {
                Application.Exit();
            }
        }
    }
}
