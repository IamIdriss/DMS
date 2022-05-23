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
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        // GET: api/<DocumentController>
        [HttpGet]
        public async Task<IEnumerable<DocumentDto>> Get()
        {
            var documentList = (await _documentService.GetAllDocumentsAsync()).ToList();
            return documentList.ToDocumentDtos();
        }

        // GET api/<DocumentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocumentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DocumentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocumentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
