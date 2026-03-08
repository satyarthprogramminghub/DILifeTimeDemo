var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

// Register the IGuidService with the desired lifetime (Singleton, Scoped, or Transient)
// Uncomment one of the following lines to choose the desired lifetime for IGuidService
// Note: Only one of these lines should be uncommented at a time to avoid multiple registrations of the same service
builder.Services.AddSingleton<IGuidService, GuidService>();
//builder.Services.AddScoped<IGuidService, GuidService>();
//builder.Services.AddTransient<IGuidService, GuidService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();
app.Run();
