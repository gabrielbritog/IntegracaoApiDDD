using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class ResponseGenerico
    {
        //public HttpStatusCode CodigoHttp { get; set; }
        public bool Sucess { get; set; }
        public string Mensage { get; set; }
        public object DadosRetorno { get; set; }
        //public ExpandoObject? ErroRetorno { get; set; }
        public ResponseGenerico()
        {

        }
        public ResponseGenerico(bool sucess , object dadosRetorno, string mensage)
        {
            Sucess = sucess;
            Mensage = mensage;
            DadosRetorno = dadosRetorno;
        }
    }
}
