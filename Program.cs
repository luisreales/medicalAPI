using System.Data;
using MedicalAPI.Application.Interface;
using MedicalAPI.Application.Services;
using MedicalAPI.Infrastructure.Data;
using MedicalAPI.Presentation.Middleware;
using Npgsql;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    
    //services for Serilog
    builder.Services.AddSerilog();
    //services for Controller
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //Add the database Configuration Service
    builder.Services.AddScoped<IDbConnection>(provider =>
    {
        var configuration = provider.GetRequiredService<IConfiguration>();
        /// <summary>
        /// Retrieves the connection string from the configuration file.
        /// </summary>
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        return new NpgsqlConnection(connectionString);
    });

    builder.Services.AddScoped<IPatientService, PatientService>();
    builder.Services.AddScoped<IPatientRepository, PatientRepository>();  


    var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMiddleware<ExceptionHandlingMiddleware>();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
catch (System.Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}


