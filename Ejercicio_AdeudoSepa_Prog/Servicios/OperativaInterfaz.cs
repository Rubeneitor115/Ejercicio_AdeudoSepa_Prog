/***
 * Ruben Bernal Ramos
 * CSI1
 */

using Ejercicio_AdeudoSepa_Prog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_AdeudoSepa_Prog.Servicios
{
    internal interface OperativaInterfaz
    {
        public void crearNuevoCliente(List<ClienteDto> listaclientes);

        public string crearContenido(ClienteDto cliente);
    }
}
