using System.Collections.Generic;

namespace Ejercicio1.spec
{
    public interface ICartaReporteParseador
    {
        IEnumerable<HojaElectronicaEntrada> Parsear();
    }
}