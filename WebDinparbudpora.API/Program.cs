using WebDinparbudpora.Infrastructure;
using WebDinparbudpora.Application;
using System.Data.Common;
// 1.Entri awal ASP.NET CORE
var builder = WebApplication.CreateBuilder(args);

// 2.Register Controller
// builder.Services.AddOpenApi(); Ganti menjadi
builder.Services.AddControllers();
// Menambahkan Layer Infrastructure
builder.Services.AddInfrastructure(builder.Configuration);
// Menambahkan Layer Application
// builder.Services.AddApplication;



//3. Finalisasi Konfigurasi
var app = builder.Build();

// 4. Middleware Swagger Dokumentasi API
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }
// Endpoint API Sementara
// app.MapGet("health/db", async (DbConnectionFactory factory) =>
// {
//     using var connect = factory.Create();
//     connect.Open();
//     return Results.Ok("Postgrest DB Connected");
// });

// app.UseHttpsRedirection();
app.MapControllers();
// 5.Menjalankan Aplikasi
app.Run();
