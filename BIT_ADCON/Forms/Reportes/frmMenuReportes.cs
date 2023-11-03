using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BIT_ADCON.Reportes.Forms;

namespace BIT_ADCON.Forms.Reportes {
    public partial class frmMenuReportes : Form {

        public Form currentChildForm;
        public frmMenuReportes() {
            InitializeComponent();
        }

        private void frmMenuReportes_Load( object sender, EventArgs e ) {

        }

        private void OpenChildForm( Form childForm ) {
            if ( currentChildForm != null ) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlMenu.Controls.Add( childForm );
            pnlMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnReporte1_Click( object sender, EventArgs e ) {
            OpenChildForm(new frmReporte1() );
        }

        private void btnReporte2_Click( object sender, EventArgs e ) {
            OpenChildForm( new frmReporte2() );
        }
    }
}
