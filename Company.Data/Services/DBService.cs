using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using AutoMapper;

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
    }
}
