using Serilog;
using SignalR.Example.Service.Application;
using SignalR.Example.Service.Infrastructure.Interfaces;
using SignalR.Example.Service.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddHostedService<PusherHostedService>();
builder.Services.AddSignalR();
builder.Services.AddSingleton<IVehicleEventsRepository, VehicleEventsRepository>();
builder.Services.AddSingleton<INotifierHub, NotifierHub>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.MapHub<NotifierHub>("/notifierHub");

app.Run();
