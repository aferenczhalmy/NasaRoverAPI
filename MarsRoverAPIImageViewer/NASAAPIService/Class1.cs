using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NasaAPIService
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using NasaAPIService;
    //
    //    var welcome = Welcome.FromJson(jsonString);


    public partial class NasaRoverPhotos
    {
        [JsonProperty("photos")]
        public Photo[] Photos { get; set; }
    }

    public partial class Photo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sol")]
        public long Sol { get; set; }

        [JsonProperty("camera")]
        public PhotoCamera Camera { get; set; }

        [JsonProperty("img_src")]
        public Uri ImgSrc { get; set; }

        [JsonProperty("earth_date")]
        public DateTimeOffset EarthDate { get; set; }

        [JsonProperty("rover")]
        public Rover Rover { get; set; }
    }

    public partial class PhotoCamera
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public CameraName Name { get; set; }

        [JsonProperty("rover_id")]
        public long RoverId { get; set; }

        [JsonProperty("full_name")]
        public FullName FullName { get; set; }
    }

    public partial class Rover
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public RoverName Name { get; set; }

        [JsonProperty("landing_date")]
        public DateTimeOffset LandingDate { get; set; }

        [JsonProperty("launch_date")]
        public DateTimeOffset LaunchDate { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("max_sol")]
        public long MaxSol { get; set; }

        [JsonProperty("max_date")]
        public DateTimeOffset MaxDate { get; set; }

        [JsonProperty("total_photos")]
        public long TotalPhotos { get; set; }

        [JsonProperty("cameras")]
        public CameraElement[] Cameras { get; set; }
    }

    public partial class CameraElement
    {
        [JsonProperty("name")]
        public CameraName Name { get; set; }

        [JsonProperty("full_name")]
        public FullName FullName { get; set; }
    }

    public enum FullName { ChemistryAndCameraComplex, FrontHazardAvoidanceCamera, MarsDescentImager, MarsHandLensImager, MastCamera, NavigationCamera, RearHazardAvoidanceCamera };

    public enum CameraName { Chemcam, Fhaz, Mahli, Mardi, Mast, Navcam, Rhaz };

    public enum RoverName { Curiosity };

    public enum Status { Active };

    public partial class NasaRoverPhotos
    {
        public static NasaRoverPhotos FromJson(string json) => JsonConvert.DeserializeObject<NasaRoverPhotos>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NasaRoverPhotos self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
        {
            FullNameConverter.Singleton,
            CameraNameConverter.Singleton,
            RoverNameConverter.Singleton,
            StatusConverter.Singleton,
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
        };
    }

    internal class FullNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FullName) || t == typeof(FullName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Chemistry and Camera Complex":
                    return FullName.ChemistryAndCameraComplex;
                case "Front Hazard Avoidance Camera":
                    return FullName.FrontHazardAvoidanceCamera;
                case "Mars Descent Imager":
                    return FullName.MarsDescentImager;
                case "Mars Hand Lens Imager":
                    return FullName.MarsHandLensImager;
                case "Mast Camera":
                    return FullName.MastCamera;
                case "Navigation Camera":
                    return FullName.NavigationCamera;
                case "Rear Hazard Avoidance Camera":
                    return FullName.RearHazardAvoidanceCamera;
            }
            throw new Exception("Cannot unmarshal type FullName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FullName)untypedValue;
            switch (value)
            {
                case FullName.ChemistryAndCameraComplex:
                    serializer.Serialize(writer, "Chemistry and Camera Complex");
                    return;
                case FullName.FrontHazardAvoidanceCamera:
                    serializer.Serialize(writer, "Front Hazard Avoidance Camera");
                    return;
                case FullName.MarsDescentImager:
                    serializer.Serialize(writer, "Mars Descent Imager");
                    return;
                case FullName.MarsHandLensImager:
                    serializer.Serialize(writer, "Mars Hand Lens Imager");
                    return;
                case FullName.MastCamera:
                    serializer.Serialize(writer, "Mast Camera");
                    return;
                case FullName.NavigationCamera:
                    serializer.Serialize(writer, "Navigation Camera");
                    return;
                case FullName.RearHazardAvoidanceCamera:
                    serializer.Serialize(writer, "Rear Hazard Avoidance Camera");
                    return;
            }
            throw new Exception("Cannot marshal type FullName");
        }

        public static readonly FullNameConverter Singleton = new FullNameConverter();
    }

    internal class CameraNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CameraName) || t == typeof(CameraName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CHEMCAM":
                    return CameraName.Chemcam;
                case "FHAZ":
                    return CameraName.Fhaz;
                case "MAHLI":
                    return CameraName.Mahli;
                case "MARDI":
                    return CameraName.Mardi;
                case "MAST":
                    return CameraName.Mast;
                case "NAVCAM":
                    return CameraName.Navcam;
                case "RHAZ":
                    return CameraName.Rhaz;
            }
            throw new Exception("Cannot unmarshal type CameraName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CameraName)untypedValue;
            switch (value)
            {
                case CameraName.Chemcam:
                    serializer.Serialize(writer, "CHEMCAM");
                    return;
                case CameraName.Fhaz:
                    serializer.Serialize(writer, "FHAZ");
                    return;
                case CameraName.Mahli:
                    serializer.Serialize(writer, "MAHLI");
                    return;
                case CameraName.Mardi:
                    serializer.Serialize(writer, "MARDI");
                    return;
                case CameraName.Mast:
                    serializer.Serialize(writer, "MAST");
                    return;
                case CameraName.Navcam:
                    serializer.Serialize(writer, "NAVCAM");
                    return;
                case CameraName.Rhaz:
                    serializer.Serialize(writer, "RHAZ");
                    return;
            }
            throw new Exception("Cannot marshal type CameraName");
        }

        public static readonly CameraNameConverter Singleton = new CameraNameConverter();
    }

    internal class RoverNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RoverName) || t == typeof(RoverName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Curiosity")
            {
                return RoverName.Curiosity;
            }
            throw new Exception("Cannot unmarshal type RoverName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RoverName)untypedValue;
            if (value == RoverName.Curiosity)
            {
                serializer.Serialize(writer, "Curiosity");
                return;
            }
            throw new Exception("Cannot marshal type RoverName");
        }

        public static readonly RoverNameConverter Singleton = new RoverNameConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "active")
            {
                return Status.Active;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Active)
            {
                serializer.Serialize(writer, "active");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
