using CSharp_DependencyInjection.Services;
using CSharp_DependencyInjection.Services.DepServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<SingletonService>();
builder.Services.AddTransient<TransientService>();
builder.Services.AddScoped<ScopedService>();

builder.Services.AddTransient<GuidServiceOne>();
builder.Services.AddTransient<GuidServiceTwo>();

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
