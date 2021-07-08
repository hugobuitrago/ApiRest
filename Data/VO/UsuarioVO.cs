using Perfius.Data;
using Perfius.Hypermedia;
using Perfius.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Perfius.Data
{
    public class UsuarioVO : ISupportHyperMedia
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }

        [JsonPropertyName("senha")]
        public string Senha { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
