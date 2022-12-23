using MediatR;

using Infrastructure.InMemoryRepositorys;
using Application.Repositorys.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.EntityFrameworkDatabase;
using Infrastructure.EntityFrameworkDataBase.Data;
using System.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using Application.Repositorys;
using Infrastructure.EFRepositoryies;
using Application.CQRS.Users.Commands.CreateUser;
using Application.Repositorys.Rooms;
using Infrastructure.EFRepositoryies.Rooms;
using Infrastructure.EFRepositoryies.Users;
using Application.Repositorys.Movies;
using Infrastructure.EFRepositoryies.Movies;
using Application.Services;
using Infrastructure.Hubs;
using Microsoft.AspNetCore.SignalR;
using API.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("ConnectionStringAmdarisProject");
//var connectionString2 = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var assemblies = AppDomain.CurrentDomain.GetAssemblies();

var builderConfiguration = builder.Configuration;

var assembly = AppDomain.CurrentDomain.Load("Application");



builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddScoped<ICinemaRoomRepository, EFCoreCinemaRepository>();
builder.Services.AddScoped<IUserRepository, EFCoreUserRepository>();
builder.Services.AddScoped<IMovieLibraryRepository, EFCoreMovieLibraryRepository>();
builder.Services.AddScoped<IMoviePlayerRepository, EFCoreMoviePlayerRepository>();
builder.Services.AddScoped<IChatRepository, EFCoreChatRepository>();
builder.Services.AddScoped<IMessageRepository, EFCoreMessageRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

/*builder.Services.AddScoped<IRealTimeVideoService, MovieHub>();
builder.Services.AddScoped<IRealTime>*/

builder.Services.AddMediatR(typeof(IUserRepository));
builder.Services.AddMediatR(typeof(EFCoreCinemaRepository));
builder.Services.AddMediatR(typeof(Program));

builder.Services.AddSignalR();

/*
builder.Services
    .AddScoped<ICinemaRoomRepository, EFCoreCinemaRepository>()
    .AddScoped<IUserRepository, EFCoreUserRepository>()
    .AddScoped<IUnitOfWork, UnitOfWork>()
    .AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(connectionString))
   // .AddMediatR(assembly);
   // .AddMediatR(assenblies);
   // .AddMediatR(typeof(Program));

*/
//var assemblyInfo = typeof(Program).GetTypeInfo().Assembly;
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

/*
app.Use(async (context, next) =>
{
    var hubContext = context.RequestServices
                            .GetRequiredService<IHubContext<CinemaConnectionHub>>();


    if (next != null)
    {
        await next.Invoke();
    }
});
*/

app.MapControllers();
app.MapHub<CinemaConnectionHub>("/CinemaConnectionHub");
app.MapHub<ChatHub>("/ChatHub");
app.Run();
/*
var mediator = app.Services.GetRequiredService<IMediator>();
mediator.Send(new CreateUserCommand
{
    userInfo = null
});*/
/*
        


*/