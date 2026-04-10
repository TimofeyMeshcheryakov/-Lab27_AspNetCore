var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-234(Мещеряков, Фёдоров)");

app.Run();
