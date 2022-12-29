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

var app = builder.Build();

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Companies, CompanyDTO>().ReverseMap();
    cfg.CreateMap<Employees, EmployeeDTO>().ReverseMap();
    cfg.CreateMap<Positions, PositionDTO>().ReverseMap();
    cfg.CreateMap<Departments, DepartmentDTO>().ReverseMap();
});

var mapper = config.CreateMapper();



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
