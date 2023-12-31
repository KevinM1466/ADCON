﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class PaisesD {
        private PaisesDA paises = new PaisesDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = paises.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string pais, string ISO ) {
            DataTable tabla = new DataTable();
            tabla = paises.Insertar( pais, ISO );
            return tabla;
        }

        public DataTable Actualizar( int codigo, string pais, string ISO ) {
            DataTable tabla = new DataTable();
            tabla = paises.Actualizar(codigo, pais, ISO );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = paises.Eliminar( codigo );
            return tabla;
        }

        //Ciudades
        public DataTable MostrarCiudades() {
            DataTable tabla = new DataTable();
            tabla = paises.MostrarCiudades();
            return tabla;
        }

        public DataTable InsertarCiudades( string ciudad, int pais ) {
            DataTable tabla = new DataTable();
            tabla = paises.InsertarCiudades( ciudad, pais );
            return tabla;
        }

        public DataTable ActualizarCiudades( int codigo, string ciudad, int pais ) {
            DataTable tabla = new DataTable();
            tabla = paises.ActualizarCiudades( codigo, ciudad, pais );
            return tabla;
        }

        public DataTable EliminarCiudades( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = paises.EliminarCiudades( codigo );
            return tabla;
        }
    }
}
