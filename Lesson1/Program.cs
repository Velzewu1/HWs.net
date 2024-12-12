using Lesson1;
using Lesson1.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app= builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");
app.MapGet("/fruit/all", () => Data.all);
app.MapGet("/fruit/{id}", (int id) => Command.GetElement(id));
app.MapPost("fruit/add/{id}", (Chore fruit) => Command.AddElement(fruit));
app.MapPatch("fruit/patch/{id}", (int id, Chore fruit) => Command.PatchElement(id, fruit));
app.MapDelete("fruit/delete/{id}", (int id) => Command.RemoveElement(id));

app.Run();
