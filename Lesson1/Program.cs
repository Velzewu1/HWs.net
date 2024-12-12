using Lesson1;
using Lesson1.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app= builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");
app.MapGet("/product/all", () => Data.all);
app.MapGet("/product/{id}", (int id) => Command.GetElement(id));
app.MapPost("product/add/{id}", (Product product) => Command.AddElement(product));
app.MapPatch("product/patch/{id}", (int id, Product product) => Command.PatchElement(id, product));
app.MapDelete("product/delete/{id}", (int id) => Command.RemoveElement(id));

app.Run();
