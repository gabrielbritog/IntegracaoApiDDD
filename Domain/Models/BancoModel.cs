using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb;

        [JsonPropertyName("name")]
        public string? NomeAbreviado;

        [JsonPropertyName("code")]
        public int? Codigo;

        [JsonPropertyName("fullName")]
        public string? NomeCompleto;
    }
}
