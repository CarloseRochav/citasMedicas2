﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoEquipo3_1.Connection;
using ProyectoEquipo3_1.Models;
using System.Data.SqlClient;

namespace ProyectoEquipo3_1.DAO
{
    class AdminDAO
    {
        private const string sql_insertar = "INSERT INTO ADMINISTRADOR VALUES (?,?)";
        Conexion conexion = new Conexion();//Objeto de la conexion       



        //Insertar Datos
        public string insertarRegistro(Admin adm)
        {
            SqlConnection conn = null;
            SqlCommand stmt = null;

            try
            {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_insertar, conn);
                stmt.Parameters.AddWithValue("@correo", adm.getCorreo());
                stmt.Parameters.AddWithValue("@contrasenia", adm.getContrasenia());
                stmt.ExecuteNonQuery();
                conn.Close();
                return "Inserccion Exitosta desde el DAO";


            }
            catch (Exception ex)
            {
                return ex.ToString();
                //throw new HttpResponseException(HttpStatusCode.NotFound);                
                //throw new Exception("Outer", ex);//Detiene la app y muestra mensaje                
            }
        }

    }
}
