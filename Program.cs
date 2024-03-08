using airbnb_clone_BE.Data;
using airbnb_clone_BE.Interface;
using airbnb_clone_BE.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// connect sql sv
var connectString = builder.Configuration.GetConnectionString("AirBnbDb") ?? throw new Exception("ConnectionString is empty or null.");
builder.Services.AddDbContext<DataContext>(option =>  option.UseSqlServer(connectString));

//Add Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

//di
builder.Services.AddTransient<IAmenityService, AmenityServices>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();
app.UseDirectoryBrowser();

app.Run();
