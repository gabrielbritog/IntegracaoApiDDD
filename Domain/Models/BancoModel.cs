using Newtonsoft.Json;
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
        [JsonProperty(PropertyName = "ispb")]
        public string? Ispb;

        [JsonProperty(PropertyName = "name")]      
        public string? NomeAbreviado;

        [JsonProperty(PropertyName = "code")]       
        public int? Codigo;

        [JsonProperty(PropertyName = "fullName")]    
        public string? NomeCompleto;
    }
}
