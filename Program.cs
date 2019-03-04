using System;

namespace ClimatologiaMX
{
    class Program
    {
        static void Main(string[] args)
        {
            var smn = new ServicioMeteorologicoNacional();
            var resultado = smn.ObtenerInformacion().GetAwaiter().GetResult();
            Console.WriteLine("La solicitud regresó un total de {0} registros!", resultado.Count);
        }
    }
}
