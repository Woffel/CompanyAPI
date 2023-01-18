using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyDepartmentsController : ControllerBase
    {

        private readonly IDbService _db;
        public CompanyDepartmentsController(IDbService db) => _db = db;

        [HttpDelete]
        public async Task<IResult> Delete(CompanyDepartmentDTO dto) =>
            await _db.HttpDeleteAsync<CompanyDepartment, CompanyDepartmentDTO>(dto);

        [HttpPost]
        public async Task<IResult> Post(CompanyDepartmentDTO dto) =>
            await _db.HttpAddAsync<CompanyDepartment, CompanyDepartmentDTO>(dto);



        //aisdoai blobloblblop
    }
}
