using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore6APIMySQL.Data.Repositories;
using NetCore6APIMySQL.Model;

namespace API_NetCore6APIMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllUsuarios()
        {
            return Ok(await _usuarioRepository.GetAllUsuarios());
        }

        [HttpGet("{ID}")]

        public async Task<IActionResult> GetUsuariosDetails(int ID)
        {
            return Ok(await _usuarioRepository.GetDetails(ID));
        }
        
        [HttpPost]

        public async Task<IActionResult> CreateUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _usuarioRepository.InsertUsuario(usuario);

            return Created("created", created);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _usuarioRepository.UpdateUsuario(usuario);

            return NoContent();
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteUsuario(int ID)
        {
            await _usuarioRepository.DeleteUsuario(new Usuario { ID = ID });

            return NoContent();
        }

    }   
       
}
