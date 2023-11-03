using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.SqlServer;

using Guna.UI2.WinForms;

namespace Domain.CrudsD {
    public class userModel {
        userDao userDao = new userDao();

        //attributes
        private int userID;
        private string correo;
        private string contrasenia;
        private string confirmarContrasenia;
        private DateTime fechaModi;
        private int empleadoID;
        private string nombres;
        private string apellidos;
        private byte[] imagen;

        public userModel( int _userID, string _correo, string _contrasenia, string _confirmarContrasenia, DateTime _fechaModi, int _empleadoID, string _nombres, string _apellidos, byte[] _imagen ) {
            this.userID = _userID;
            this.correo = _correo;
            this.contrasenia = _contrasenia;
            this.confirmarContrasenia = _confirmarContrasenia;
            this.fechaModi = _fechaModi;
            this.empleadoID = _empleadoID;
            this.nombres = _nombres;
            this.apellidos = _apellidos;
            this.imagen = _imagen;
        }

        public userModel() {

        }

        public bool isLoginUser( string user, string password ) {
            return userDao.Login( user, password );
        }

        public void Permisos( Guna2Button contratos, Guna2Button productos, Guna2Button compania, Guna2Button reportes ) {
            userDao.Permisos( contratos, productos, compania, reportes );
        }
    }
}
