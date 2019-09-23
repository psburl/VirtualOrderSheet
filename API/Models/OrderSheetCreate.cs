using System;
using System.Collections.Generic;
using System.Globalization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API.Models
{
    public partial class OrderSheetCreate
    {

        [JsonProperty("client_cpf")]
        public string ClientCpf { get; set; }
    }
}