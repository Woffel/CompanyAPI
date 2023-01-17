using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IDbService _db;
        public CompanyController(IDbService db) => _db = db;


        // GET api/<TestController>/
        [HttpGet]
        public async Task<IResult> Get() => 
            await _db.HttpGetAsync<Company.Data.Entities.Company, CompanyDTO>();

        // GET api/<TestController>/ id
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => 
            await _db.HttpSingleAsync<Company.Data.Entities.Company, CompanyDTO>(id);

        // POST api/<TestController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto) => 
            await _db.HttpPostAsync<Company.Data.Entities.Company, CompanyDTO>(dto);

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto) =>
            await _db.HttpPutAsync<Company.Data.Entities.Company, CompanyDTO>(id, dto);

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Company.Data.Entities.Company>(id);
        //aisdoai blobloblblop
            
    }
}
