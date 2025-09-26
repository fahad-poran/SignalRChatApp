using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SignalRChatApp;

var builder = WebApplication.CreateBuilder(args);

// Add SignalR service
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles(); // serve index.html by default
app.UseStaticFiles();  // serve static files (js/css)

// Map SignalR hub
app.MapHub<ChatHub>("/chatHub");

app.Run();