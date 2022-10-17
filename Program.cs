using Microsoft.OpenApi.Models;
using InformacoesSilasVasconcelos.DB;
using Microsoft.AspNetCore.Http.Json;

//Developer: Silas Vasconcelos

var builder = WebApplication.CreateBuilder(args);

// Configure JSON options.
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.IncludeFields = true;
});
    
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
     s.SwaggerDoc("v7",
                  new OpenApiInfo { Title = "SilasVasconcelosCruz API",
                  Description = "Sejam Bem Vindos API Silas ", Version = "v7" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
     app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(s =>
{
   s.SwaggerEndpoint("/swagger/v7/swagger.json", "SilasVasconcelosCruz API V7");
});

app.MapGet("/home/{id}", (int id) => PessoaDB.getPessoa(id));

app.Run();