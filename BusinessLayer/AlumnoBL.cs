using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BusinessLayer
{
    public class AlumnoBL
    {
        public async Task<List<Alumno>> GetAlumnosAsync()
        {
            AlumnoDAL dal = new AlumnoDAL();
            List<Alumno> Alumnos = await dal.GetAlumnoAsync();
            return Alumnos;

        }
        public Alumno GetAlumno(int IdAlumno)
        {
            AlumnoDAL dal1 = new AlumnoDAL();
            Alumno Alumno = dal1.GetAlumno(IdAlumno);
            return Alumno;
        }
    }
}
