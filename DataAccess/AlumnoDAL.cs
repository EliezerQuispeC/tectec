using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Dapper;
using System.Linq;

namespace DataAccess
{
    public class AlumnoDAL : Connection
    {
        public async Task<List<Alumno>> GetAlumnoAsync()
        {
            MySqlConnection connection = base.OpenConnection();
            try
            {
                List<Alumno> AlumnosList = null;
                if (connection != null)
                {
                    AlumnosList = (await connection.QueryAsync<Alumno>(
                        @"SELECT IdAlumno, Nombre, Apellido, Dni, Email FROM talumnos")).ToList();
                }
                return AlumnosList;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        //Obtener un solo alumno
        public Alumno GetAlumno(int IdAlumno)
        {
            MySqlConnection connection = base.OpenConnection();
            try { 
                Alumno Alumno = null;
                if (connection != null)
                {
                    Alumno = (connection.QueryFirst<Alumno>(
                    @"SELECT IdAlumno, Nombre, Apellido, Dni, Email FROM talumnos WHERE IdAlumno = @IdAlumno", new
                    {
                        IdAlumno = IdAlumno
                    }));

                }
                return Alumno;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Consultando: " + ex.Message);
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
