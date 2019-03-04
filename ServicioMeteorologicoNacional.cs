using System;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using ClimatologiaMX.Models;

namespace ClimatologiaMX
{
    public class ServicioMeteorologicoNacional
    {
        private String baseUrl = "https://smn.cna.gob.mx";
        private HttpClient client { get; set; }
        public ServicioMeteorologicoNacional()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
        }
        public async Task<Respuesta> ObtenerInformacion()
        {
            HttpResponseMessage response = await client.GetAsync("/webservices/?method=1");
            Respuesta data = null;
            if (response.IsSuccessStatusCode)
            {
                var serializer = new DataContractJsonSerializer(typeof(Respuesta));
                using (var message = await response.Content.ReadAsStreamAsync())
                using (var decompressionStream = new GZipStream(message, CompressionMode.Decompress))
                {
                    data = (Respuesta)serializer.ReadObject(decompressionStream);
                }
            }
            return data;
        }
    }
}