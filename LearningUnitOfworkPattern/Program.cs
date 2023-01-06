using LearningUnitOfworkPattern.core;
using LearningUnitOfworkPattern.core.Interfaces;
using LearningUnitOfworkPattern.EF;
using LearningUnitOfworkPattern.EF.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"], change => change.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
);

});
//builder.Services.AddTransient(typeof(IBaseRepository<>) , typeof(BaseRepository<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>(); 
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
