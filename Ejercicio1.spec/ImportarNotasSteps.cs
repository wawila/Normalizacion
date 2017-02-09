using System;
using Moq;
using TechTalk.SpecFlow;

namespace Ejercicio1.spec
{
    [Binding]
    public class ImportarNotasSteps
    {
        private ImportarNotasGerente _importadorGerente;
        private Moq.Mock<IAlumnoRepositorio> _alumnoRepositorioMock = new Mock<IAlumnoRepositorio>();
        private Moq.Mock<IMateriaRepositorio> _materiaRepositorioMock = new Mock<IMateriaRepositorio>();
        private Moq.Mock<INotaRepositorio> _notaRepositorioMock = new Mock<INotaRepositorio>();
        private Moq.Mock<ICartaReporteParseador> _cartaReporteRepositorioMock = new Mock<ICartaReporteParseador>();

        public ImportarNotasSteps(ImportarNotasGerente importadorGerente)
        {
            _importadorGerente = importadorGerente;
        }


        [Given(@"La siguiente hoja electronica")]
        public void GivenLaSiguienteHojaElectronica(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Se importa la data")]
        public void WhenSeImportaLaData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"La siguiente informacion se inserto en la tabla Alumno")]
        public void ThenLaSiguienteInformacionSeInsertoEnLaTablaAlumno(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"La siguiente informacion se inserto en la tabla Materia")]
        public void ThenLaSiguienteInformacionSeInsertoEnLaTablaMateria(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"La siguiente informacion se inserto en la tabla Notas")]
        public void ThenLaSiguienteInformacionSeInsertoEnLaTablaNotas(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
