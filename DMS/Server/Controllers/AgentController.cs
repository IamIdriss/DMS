using DMS.Abstraction;
using DMS.Domain.Entities;
using DMS.Dto;
using DMS.Dto.Extention;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IAgentService _agentService;

        public AgentController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        // GET: api/<AgentController>
        [HttpGet]
        public async Task<IEnumerable<AgentDto>> Get()
        {
           var agentList = (await _agentService.GetAllAgentsAsync()).ToList();
            return agentList.ToAgentDtos();
        }

        // GET api/<AgentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AgentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
