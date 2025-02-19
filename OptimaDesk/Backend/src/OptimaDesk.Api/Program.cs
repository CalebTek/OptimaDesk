using OptimaDesk.Api.Extensions;
using OptimaDesk.Application;
using OptimaDesk.Common.Extensions;
using OptimaDesk.Infrastructure;
using OptimaDesk.Infrastructure.Seeder;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

builder.Logging.ClearProviders();

// Add services to the container.
builder.Services.ConfigureApplication(builder.Configuration);
builder.Services.ConfigureInfraStructure(builder.Configuration, builder.Environment);
builder.Services.AddDbContextAndConfigurations(builder.Configuration);
builder.Services.ConfigureIdentity();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
builder.Services.ConfigureAppServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();
AppLoggerFactory.Configure(loggerFactory);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(); 
    app.UseSwaggerUI();
}

app.UseDeveloperExceptionPage();
app.UseStaticFiles();

await SeederClass.SeedData(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Logger.LogInformation("Starting the app...New");

app.Run();
