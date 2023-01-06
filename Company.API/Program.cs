

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CompanyContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("CourseConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDbService, DBService>();



var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Company.Data.Entities.Company, CompanyDTO>().ReverseMap();
    cfg.CreateMap<Employee, EmployeeDTO>().ReverseMap();
    cfg.CreateMap<Position, PositionDTO>().ReverseMap();
    cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
