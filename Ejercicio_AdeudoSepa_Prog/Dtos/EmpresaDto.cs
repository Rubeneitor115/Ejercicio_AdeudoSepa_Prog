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
    internal class EmpresaDto
    {
        string nifEmpresa;
        string nombreEmpresa;
        string domicilioEmpresa;
        string cpEmpresa;
        string provinciaEmpresa;
        string paisEmpresa;

        public string NifEmpresa { get => nifEmpresa; }
        public string NombreEmpresa { get => nombreEmpresa; }
        public string DomicilioEmpresa { get => domicilioEmpresa; }
        public string CpEmpresa { get => cpEmpresa; }
        public string ProvinciaEmpresa { get => provinciaEmpresa; }
        public string PaisEmpresa { get => paisEmpresa; }
    }
}
