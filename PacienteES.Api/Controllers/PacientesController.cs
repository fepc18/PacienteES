using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Abstract;
using Application.Implements;
using Context;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Context;
using Repository.Repositories;
using UnitOfWork;


namespace PacienteES.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
   
        private readonly IPacienteService _service;
        private readonly IConfiguration _configuration;

        private ILogger<PacientesController> _logger { get; }

        public PacientesController(ApplicationDbContext db,ILogger<PacientesController> logger,IConfiguration configuration)
        {
            ApplicationDbContext _context = db;
            _service = new PacienteService(new UnitOfWorkContainer(_context), new PacienteRepository(_context));
            _logger = logger;
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        // GET api/Pacientes/Cache
        [HttpGet("Cache")]
        [ResponseCache(Duration = 15)]
        public ActionResult<string> GetCache()
        {
            return DateTime.Now.Second.ToString();
        }
        // GET api/Pacientes/Cache
        [HttpGet("TestConfiguration")]      
        public ActionResult<string> GetConfiguration()
        {
             return _configuration["Environment"];
        }
        [HttpGet("TestVariableEntorno")]
        public ActionResult<string> GetConfigurationEntorno()
        {
            return _configuration["TestVariableAmbiente"];
        }

        // GET: api/Pacientes
        [HttpGet]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Paciente>> Get()
        {
            _logger.LogInformation("Obteniendo los Pacientes");
            return Ok(_service.GetAll());
        }
        [HttpGet("Paged")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public ActionResult<DataCollection<Paciente>> Paged(int page, int take)
        {
            if (page == 0 || take == 0)
                return BadRequest("page y take deben ser números mayores a cero");
            if (take> 100)
                return BadRequest("Máximo de datos por página 100");
            var result = _service.Paged(page, take);
            Response.Headers["X-Pagina-Actual"] = result.Page.ToString();
            Response.Headers["X-Total-Registros"] = result.Total.ToString();
            Response.Headers["X-Cantidad-Paginas"] = result.Pages.ToString();               
            return Ok(result.Items);
            
        }

        // GET: api/Paciente/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        public ActionResult<Paciente> Get(int id)
        {
            
            var paciente = _service.Find(id);
            if(paciente==null)
            {
                _logger.LogWarning($"El paciente de Id {id} no ha sido encontrado");
                return NotFound();
            }
            return Ok(paciente);
        }

        // POST: api/Paciente
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult Post([FromBody] Paciente paciente)
        {
            // Esto no es necesario en asp.net core 2.1 en adelante
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            _service.Create(paciente);
            return new CreatedAtRouteResult("Get", new { id = paciente.Id }, paciente);
        }

        // PUT: api/Paciente/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public ActionResult Put(int id, [FromBody] Paciente paciente)
        {
           /* if (id != paciente.Id)
                return BadRequest();*/
            _service.Update(paciente);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NoContent)]
       // [ProducesResponseType(typeof(void), (int)HttpStatusCode.BadRequest)]//Si se desea eliminar un registro y no esta permitido
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        public ActionResult<Paciente> Delete(int id)
        {
            var paciente = _service.Find(id);
            if (paciente == null)
                return NotFound();
            _service.Delete(paciente);
            return NoContent();
           //return Ok(paciente);
        }
    }
}
