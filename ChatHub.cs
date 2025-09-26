using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace SignalRChatApp
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Broadcast to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}