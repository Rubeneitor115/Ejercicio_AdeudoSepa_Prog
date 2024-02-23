/***
 * Ruben Bernal Ramos
 * CSI1
 */

using Ejercicio_AdeudoSepa_Prog.Dtos;
using Ejercicio_AdeudoSepa_Prog.Servicios;

namespace adeudoSepa
{
    class Program
    {
        static string rutaFichero = "C:\\Usuarios\\Ruben\\Escritorio\\";
        static List<ClienteDto> listaClientes = new List<ClienteDto>();

        public static void Main(string[] args)
        {
            OperativaInterfaz oi = new OperativaImplementacion();
            string entrada;

            //Recojo todos los clientes
            do
            {
                oi.crearNuevoCliente(listaClientes);

                Console.WriteLine("¿Introducirá otro cliente? (s/n): ");
                entrada = Console.ReadLine();

            } while (entrada.Equals("s"));

            //Generar ficheros
            foreach (ClienteDto cliente in listaClientes)
            {
                string[] nombreDesagregado = cliente.NombreDeudor.Split(" ");
                string nombreFichero = nombreDesagregado[0] + nombreDesagregado[1] + ".txt";
                string rutaCompletaFichero = rutaFichero + nombreFichero;

                using (StreamWriter ficheroAdeudo = new StreamWriter(rutaCompletaFichero))
                {
                    ficheroAdeudo.Write(oi.crearContenido(cliente));
                };
            }

        }
    }
}