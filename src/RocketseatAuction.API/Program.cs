using MediatR;
using RocketseatAuction.Application.Contracts.Repositories;
using RocketseatAuction.Application.Contracts.Services;
using RocketseatAuction.Application.Services.Auction;
using RocketseatAuction.Infraestructure.Contexts;
using RocketseatAuction.Infraestructure.Repositories;

namespace RocketseatAuction.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<RocketseatAuctionDbContext>();
        builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        builder.Services.AddScoped<IUnityOfWork, UnityOfWork>();
        builder.Services.AddScoped<IAuctionRepository, AuctionRepository>();
        builder.Services.AddScoped<IAuctionService, AuctionService>();

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
    }
}
