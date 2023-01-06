using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using AutoMapper;
using Company.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Services
{
    public class DBService : IDbService
    {
        private readonly CompanyContext _db;
        private readonly IMapper _mapper;

        public DBService(CompanyContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<TDto>> GetAsync<TEntity, TDto>() where TEntity : class, IEntity where TDto : class
        {
            var entities = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);
        }
    }
}
