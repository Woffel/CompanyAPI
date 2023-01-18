using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePositionsController : ControllerBase
    {

        private readonly IDbService _db;
        public EmployeePositionsController(IDbService db) => _db = db;

        [HttpDelete]
        public async Task<IResult> Delete(EmployeePositionsDTO dto) =>
            await _db.HttpDeleteAsync<EmployeePositions, EmployeePositionsDTO>(dto);

        [HttpPost]
        public async Task<IResult> Post(EmployeePositionsDTO dto) =>
            await _db.HttpAddAsync<EmployeePositions, EmployeePositionsDTO>(dto);

    }
}
