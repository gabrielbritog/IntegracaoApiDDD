using Domain.Dto;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }
        [HttpGet("buscar/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<ResponseGenerico>> BuscarEndereco([FromRoute] string cep)
        {
            
            try
            {
                var response = await _enderecoService.BuscarEndereco(cep);
                return Ok(new ResponseGenerico(true, response, "Endereço Obtido com sucesso"));
                //return Ok(response.DadosRetorno);

            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseGenerico(false, ex.Message, "Não foi possível obter os dados"));              
                
            }

        }
    }
}