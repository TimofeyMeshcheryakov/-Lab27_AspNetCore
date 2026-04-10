var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Привет от ИСП-234(Мещеряков, Фёдоров)");

// app.Run();

app.MapGet("/", () => "Добро пожаловать на сервер");

app.MapGet("/about", () => "Это мой первый ASP.NET Core сервер");

app.MapGet("/time", () => $"Время на сервер: {DateTime.Now}");

app.MapGet("/hello/{name}", (string name) => $"Привет, {name}!");

app.MapGet("/sum/{a}/{b}", (int a, int b) =>
$"{10 + 25}");

app.Run();


