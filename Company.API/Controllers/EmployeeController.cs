using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeeController(IDbService db) => _db = db;

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Employee, EmployeeDTO>();

        // GET api/<TestController>/ id
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Employee, EmployeeDTO>(id);

        // POST api/<TestController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeDTO dto) =>
            await _db.HttpPostAsync<Employee, EmployeeDTO>(dto);

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO dto) =>
            await _db.HttpPutAsync<Employee, EmployeeDTO>(id, dto);

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Employee>(id);
        //aisdoai blobloblblop
    }
}
