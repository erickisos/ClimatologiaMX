# Climatologia MX

En este repositorio se encuentra un ejemplo de aplicación que consume el _WebService_ del Servicio Meteorológico Nacional.
La aplicación de ejemplo está escrita en C# para .NET Core, usando únicamente librerías standard para facilitar la implementación.

La url del servicio es `https://smn.cna.gob.mx/webservices/?method=1` y devuelve un _JSON_ comprimido en _GZip_.

El siguiente es un ejemplo de la estructura de la respuesta

```json
[
    {
        "CityId": "MXAS0002",
        "Name": "Aguascalientes",
        "StateAbbr": "AGU",
        "DayNumber": "0",
        "ValidDateUtc": "20190303T000000Z",
        "LocalValidDate": "20190303T070000Z",
        "HiTempF": "88",
        "LowTempF": "49",
        "HiTempC": "31",
        "LowTempC": "9",
        "PhraseDay": "Cielo mayormente despejado. Máxima de 31 C. Vientos del SO y variable.",
        "PhraseNight": "Cielo mayormente despejado. Mínima de 9 C. Vientos del ESE de 10 a 15 km/h.",
        "SkyText": "Mayormente despejado",
        "ProbabilityOfPrecip": "0",
        "RelativeHumidity": "35",
        "WindSpeedMph": "6",
        "WindSpeedKm": "10",
        "WindDirection": "114",
        "WindDirectionCardinal": "ESE",
        "CloudCoverage": "7",
        "UvIndex": "0",
        "UvDescription": "Bajo",
        "IconCode": "65",
        "IconCodeNight": "102",
        "SkyTextNight": "Mayormente despejado",
        "Latitude": "21.87982",
        "Longitude": "-102.296"
    }
]
```

En la carpeta Models se encuentran los `DataContract` utilizados para la deserialization de la información obtenida, y en el archivo `SMN.cs` se encuentra la clase que se encarga de la llamada al _WebService_