using Domain.Dto;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;
        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;

        }

        [HttpGet("buscar/{cod}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ResponseGenerico>> BuscarBanco([FromRoute] string cod)
        {
            try { 
            var response = await _bancoService.BuscarBanco(cod);
            return Ok(new ResponseGenerico(true, response, "Endereço Obtido com sucesso"));
            }catch(Exception e)
            {
                return BadRequest(new ResponseGenerico(false, e, "Dados não obtidos"));
            }
        }
    }
}