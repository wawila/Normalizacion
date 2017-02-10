using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.spec
{
    public class HojaElectronicaEntrada
    {
        public int AlumnoId { get; set; }
        public string AlumnoNombre { get; set; }
        public int MateriaId { get; set; }
        public string MateriaNombre { get; set; }
        public int Nota { get; set; }
    }

    public class Alumno
    {
        public override bool Equals(object obj)
        {
            var alumno = (Alumno) obj;
            return alumno != null && (alumno.AlumnoId == AlumnoId && alumno.AlumnoNombre == AlumnoNombre);
        }
       
        public int AlumnoId { get; set; }
        public string AlumnoNombre { get; set; }
    }

    public class Materia
    {
        public override bool Equals(object obj)
        {
            var materia = (Materia)obj;
            return materia != null && (materia.MateriaId == MateriaId && materia.MateriaNombre == MateriaNombre);
        }

        public int MateriaId { get; set; }
        public string MateriaNombre { get; set; }
    }

    public class Notas
    {
        public override bool Equals(object obj)
        {
            var notas = (Notas)obj;
            return notas != null && (notas.MateriaId == MateriaId && notas.AlumnoId == AlumnoId && notas.Nota == Nota);
        }

        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public int Nota { get; set; }
    }

}
