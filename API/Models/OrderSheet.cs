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
    public partial class OrderSheet
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonIgnoreIfDefault]
        [JsonIgnore]
        public ObjectId Id { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("client_cpf")]
        public string ClientCpf { get; set; }

        [JsonProperty("created_date")]
        public string CreatedDate { get; set; }

        [JsonProperty("finished_date")]
        public string FinishedDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("products")]
        public List<OrderProduct> Products { get; set; }
    }

    public partial class OrderProduct
    {
        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("date_time")]
        public string DateTime { get; set; }
    }
}