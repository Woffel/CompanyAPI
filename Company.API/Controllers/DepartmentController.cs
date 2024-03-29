﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDbService _db;
        public DepartmentController(IDbService db) => _db = db;


        // GET api/<TestController>/
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Department, DepartmentDTO>();

        // GET api/<TestController>/ id
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Department, DepartmentDTO>(id);

        // POST api/<TestController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartmentDTO dto) =>
            await _db.HttpPostAsync<Department, DepartmentDTO>(dto);

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto) =>
            await _db.HttpPutAsync<Department, DepartmentDTO>(id, dto);

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Department>(id);
        //aisdoai blobloblblop
    }
}
