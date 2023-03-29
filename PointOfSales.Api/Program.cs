using Microsoft.AspNetCore.Builder;
using PointOfSales.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.ConfigureService().ConfigurePipeline();

app.MapGet("/swagger", () => "Hello World!");

app.Run();
