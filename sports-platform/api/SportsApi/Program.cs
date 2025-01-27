using SportsApi.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var allowedOrigins = builder.Configuration.GetValue<string>("AllowedOrigins")?.Split(",") ?? new[] { "*" };

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sports API", Version = "v1" });
});
builder.Services.AddScoped<ISportService, SportService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
});

// // builder.Services.AddCors(options =>
// // {
// //     options.AddPolicy("AllowAll", builder =>
// //         builder.AllowAnyOrigin()
// //                .AllowAnyMethod()
// //                .AllowAnyHeader());
// // });

// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowAll", builder =>
//     {
//         builder.WithOrigins(allowedOrigins)
//                .AllowAnyMethod()
//                .AllowAnyHeader()
//                .AllowCredentials();
//     });
// });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sports API v1"));
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();