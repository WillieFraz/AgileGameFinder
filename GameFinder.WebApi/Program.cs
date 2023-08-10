using GameFinder.Service.GameService;
using GameFinder.Data;
using Microsoft.EntityFrameworkCore;
using GameFinder.Data.Entities;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IGameService,GameService>();
// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<User>(
    options => {
        options.Password.RequiredLength=4;
        options.Password.RequireDigit=false;
        options.Password.RequireUppercase=false;
        options.Password.RequireNonAlphanumeric=false;
    }
).AddRoles<IdentityRole<int>>().AddEntityFrameworkStores<ApplicationDbContext>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
