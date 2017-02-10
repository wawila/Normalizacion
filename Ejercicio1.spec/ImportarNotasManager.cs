using System.Collections.Generic;
using System.Net.Sockets;

namespace Ejercicio1.spec
{
    public class ImportarNotasGerente
    {
        private readonly IAlumnoRepositorio _alumnoRepositorio;
        private readonly ICartaReporteParseador _cartaReporteParseador;
        private readonly IMateriaRepositorio _materiaRepositorio;
        private readonly INotaRepositorio _notaRepositorio;
        private readonly Dictionary<int, string> _alumnos = new Dictionary<int, string>();
        private readonly Dictionary<int, string> _materia = new Dictionary<int, string>();

        public ImportarNotasGerente(IAlumnoRepositorio alumnoRepositorio, ICartaReporteParseador cartaReporteParseador, IMateriaRepositorio materiaRepositorio, INotaRepositorio notaRepositorio)
        {
            this._alumnoRepositorio = alumnoRepositorio;
            this._cartaReporteParseador = cartaReporteParseador;
            this._materiaRepositorio = materiaRepositorio;
            this._notaRepositorio = notaRepositorio;
        }
        
        public void ImportarData()
        {
            var entrada = _cartaReporteParseador.Parsear();
            foreach (var fila in entrada)
                Normalizar(fila);
        }

        private void Normalizar(HojaElectronicaEntrada fila)
        {
            ImportarAlumno(fila);
            ImportarMateria(fila);
            ImportarNota(fila);
        }

        private void ImportarNota(HojaElectronicaEntrada fila)
        {
            _notaRepositorio.Agregar(new Notas
            {
                AlumnoId = fila.AlumnoId,
                MateriaId = fila.MateriaId,
                Nota = fila.Nota
            });
        }

        private void ImportarMateria(HojaElectronicaEntrada fila)
        {
            if (_materia.ContainsKey(fila.MateriaId)) return;
            _materia.Add(fila.MateriaId, fila.MateriaNombre);
            _materiaRepositorio.Agregar(new Materia
            {
                MateriaId = fila.MateriaId,
                MateriaNombre = fila.MateriaNombre
            });
        }

        private void ImportarAlumno(HojaElectronicaEntrada fila)
        {
            if (_alumnos.ContainsKey(fila.AlumnoId)) return;
            _alumnos.Add(fila.AlumnoId, fila.AlumnoNombre);
            _alumnoRepositorio.Agregar(new Alumno
            {
                AlumnoId = fila.AlumnoId,
                AlumnoNombre = fila.AlumnoNombre
            });
        }
    }
}