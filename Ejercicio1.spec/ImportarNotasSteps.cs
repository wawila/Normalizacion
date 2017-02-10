using System;
using Moq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Ejercicio1.spec
{
    [Binding]
    public class ImportarNotasSteps
    {
        private ImportarNotasGerente _importadorGerente;
        private Moq.Mock<IAlumnoRepositorio> _alumnoRepositorioMock = new Mock<IAlumnoRepositorio>();
        private Moq.Mock<IMateriaRepositorio> _materiaRepositorioMock = new Mock<IMateriaRepositorio>();
        private Moq.Mock<INotaRepositorio> _notaRepositorioMock = new Mock<INotaRepositorio>();
        private Moq.Mock<ICartaReporteParseador> _cartaReporteParseadorMock = new Mock<ICartaReporteParseador>();

        
        public ImportarNotasSteps()
        {
            _importadorGerente = new ImportarNotasGerente(
                _alumnoRepositorioMock.Object, _cartaReporteParseadorMock.Object,
                _materiaRepositorioMock.Object, _notaRepositorioMock.Object);

        }


        [Given(@"La siguiente hoja electronica")]
        public void GivenLaSiguienteHojaElectronica(Table table)
        {
            var entrada = table.CreateSet<HojaElectronicaEntrada>();
            _cartaReporteParseadorMock.Setup(i => i.Parsear()).Returns(entrada);
        }
        
        [When(@"Se importa la data")]
        public void WhenSeImportaLaData()
        {
            _importadorGerente.ImportarData();
        }
        
        [Then(@"La siguiente informacion se inserto en la tabla Alumno")]
        public void ThenLaSiguienteInformacionSeInsertoEnLaTablaAlumno(Table table)
        {
            var alumnos = table.CreateSet<Alumno>();
            foreach (var alumno in alumnos)
            {
                _alumnoRepositorioMock.Verify(i => i.Agregar(alumno), Times.Once);
            }
        }
        
        [Then(@"La siguiente informacion se inserto en la tabla Materia")]
        public void ThenLaSiguienteInformacionSeInsertoEnLaTablaMateria(Table table)
        {
            var materias = table.CreateSet<Materia>();
            foreach (var materia in materias)
            {
                _materiaRepositorioMock.Verify(i => i.Agregar(materia), Times.Once);
            }
        }
        
        [Then(@"La siguiente informacion se inserto en la tabla Notas")]
        public void ThenLaSiguienteInformacionSeInsertoEnLaTablaNotas(Table table)
        {
            var notas = table.CreateSet<Notas>();
            foreach (var nota in notas)
            {
                _notaRepositorioMock.Verify(i => i.Agregar(nota), Times.Once);
            }
        }
    }
}
