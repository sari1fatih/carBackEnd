using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebAPI.Hubs
{
    public class CarHub : Hub
    {
        public async Task SendMEssageAsync()
        {
            await Clients.All.SendAsync("receiveMessage", "Merhaba");
        }
    }
}
