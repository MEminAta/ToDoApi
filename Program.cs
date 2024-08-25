var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

const string allowOrigins = "_allowOrigins";
builder.Services.AddCors(options =>
    options.AddPolicy(name: allowOrigins, policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));


var app = builder.Build();

app.UseCors(allowOrigins);

app.UseHttpsRedirection();

app.MapControllers();

await app.RunAsync();