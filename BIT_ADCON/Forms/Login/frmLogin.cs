using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Domain.CrudsD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BIT_ADCON.Forms.Login {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void frmLogin_Load( object sender, EventArgs e ) {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click( object sender, EventArgs e ) {
            if ( txtUsuario.Text != "" ) {
                if ( txtPassword.Text != "" ) {
                    userModel user = new userModel();
                    var validLogin = user.isLoginUser( txtUsuario.Text, txtPassword.Text );
                    if ( validLogin == true ) {
                        frmPrincipal frmPrincipal = new frmPrincipal();
                        frmPrincipal.Show();
                        frmPrincipal.FormClosed += Logout;
                        this.Hide();
                    } else {
                        MessageBox.Show( "Correo o Contraseña incorrectos", "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        txtUsuario.Focus();
                        txtPassword.Clear();
                    }
                } else {
                    MessageBox.Show( "Por favor ingrese su contraseña", "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information );

                }
            } else {
                MessageBox.Show( "Por favor ingrese su correo", "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void Logout( object sender, FormClosedEventArgs e ) {
            limpiar();
            this.Show();
            txtUsuario.Focus();
        }

        public void limpiar() {
            txtUsuario.Clear();
            txtPassword.Clear();
        }
    }
}