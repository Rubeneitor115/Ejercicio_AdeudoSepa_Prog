/***
 * Ruben Bernal Ramos
 * CSI1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_AdeudoSepa_Prog.Dtos
{
    internal class ClienteDto
    {
        long referenciaOrden;
        string nombreDeudor;
        string direccionDeudor;
        string cpDeudor;
        string ibanDeudor;
        string swiftBancoDeudor;
        DateTime fechaInicioAdeudo = DateTime.Today;
        char tipoPagoDeudor;

        public long ReferenciaOrden { get => referenciaOrden; set => referenciaOrden = value; }
        public string NombreDeudor { get => nombreDeudor; set => nombreDeudor = value; }
        public string DireccionDeudor { get => direccionDeudor; set => direccionDeudor = value; }
        public string CpDeudor { get => cpDeudor; set => cpDeudor = value; }
        public string IbanDeudor { get => ibanDeudor; set => ibanDeudor = value; }
        public string SwiftBancoDeudor { get => swiftBancoDeudor; set => swiftBancoDeudor = value; }
        public DateTime FechaInicioAdeudo { get => fechaInicioAdeudo; set => fechaInicioAdeudo = value; }
        public char TipoPagoDeudor { get => tipoPagoDeudor; set => tipoPagoDeudor = value; }
    }
}
