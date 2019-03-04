using System;
using System.Runtime.Serialization;

namespace ClimatologiaMX.Models
{
    [DataContract]
    public class Registro
    {
        [DataMember(Name = "CityId")]
        public String idCiudad { get; set; }
        [DataMember(Name = "Name")]
        public String Nombre { get; set; }
        [DataMember(Name = "StateAbbr")]
        public String Estado { get; set; }
        [DataMember(Name = "DayNumber")]
        public Int32 NumeroDeDia { get; set; }
        [DataMember(Name = "ValidDateUtc")]
        public String FechaUtc { get; set; }
        [DataMember(Name = "LocalValidDate")]
        public String FechaLocal { get; set; }
        [DataMember(Name = "HiTempF")]
        public Double TemperaturaMaximaF { get; set; }
        [DataMember(Name = "LowTempF")]
        public Double TemperaturaMinimaF { get; set; }
        [DataMember(Name = "HiTempC")]
        public Double TemperaturaMaximaC { get; set; }
        [DataMember(Name = "LowTempC")]
        public Double TemperaturaMinimaC { get; set; }
        [DataMember(Name = "PhraseDay")]
        public String DescripcionDia { get; set; }
        [DataMember(Name = "PhraseNight")]
        public String DescripcionNoche { get; set; }
        [DataMember(Name = "SkyText")]
        public String DescripcionCielo { get; set; }
        [DataMember(Name = "ProbabilityOfPrecip")]
        public Int32 ProbabilidadPrecipitacion { get; set; }
        [DataMember(Name = "RelativeHumidity")]
        public Double HumedadRelativa { get; set; }
        [DataMember(Name = "WindSpeedMph")]
        public Double VelocidadVientoMPH { get; set; }
        [DataMember(Name = "WindSpeedKm")]
        public Double VelocidadVientoKM { get; set; }
        [DataMember(Name = "WindDirection")]
        public Int32 DireccionViento { get; set; }
        [DataMember(Name = "WindDirectionCardinal")]
        public String DireccionVientoCardinal { get; set; }
        [DataMember(Name = "CloudCoverage")]
        public Int32 CoberturaNubes { get; set; }
        [DataMember(Name = "UvIndex")]
        public Int32 IndiceUV { get; set; }
        [DataMember(Name = "UvDescription")]
        public String DescripcionUV { get; set; }
        [DataMember(Name = "IconCode")]
        public Int32 CodigoIconoDia { get; set; }
        [DataMember(Name = "IconCodeNight")]
        public Int32 CodigoIconoNoche { get; set; }
        [DataMember(Name = "SkyTextNight")]
        public String DescripcionCieloNoche { get; set; }
        [DataMember(Name = "Latitude")]
        public Double Latitud { get; set; }
        [DataMember(Name = "Longitude")]
        public Double Longitud { get; set; }
    }
}