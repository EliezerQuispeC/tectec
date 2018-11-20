using System;

namespace Entities
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("ID={0} , DNI={1}, NOMBRE={2}, APELLIDO={3}, EMAIL={4}", this.IdAlumno, this.Dni, this.Nombre, this.Apellido, this.Email);
        }
    }


}
