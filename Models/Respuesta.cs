using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace ClimatologiaMX.Models
{
    [CollectionDataContract]
    public class Respuesta : Collection<Registro>
    {
    }
}