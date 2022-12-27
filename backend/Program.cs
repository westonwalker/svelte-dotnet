var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Setup cors sveltekit-test-production-b388.up.railway.app
var AllowSpecificOrigins = "_AllowSubdomainPolicy";
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: AllowSpecificOrigins,
		policy =>
		{
			policy.WithOrigins("https://*.railway.app")
				.SetIsOriginAllowedToAllowWildcardSubdomains();
		});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
	"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weather-types", () =>
{
	return summaries;
});

app.Run();
