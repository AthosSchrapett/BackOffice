
using BackOfficeApi.Data;
using BackOfficeApi.Data.Infra;
using BackOfficeApi.Model.Entities.Person;
using BackOfficeApi.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnityOfWork, UnityOfWork>();
builder.Services.AddScoped<IPersonService<LegalPerson>, LegalPersonService>();
builder.Services.AddScoped<IPersonService<NaturalPerson>, NaturalPersonService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

builder.Services.AddDbContext<BackOfficeContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("BackOfficeConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
