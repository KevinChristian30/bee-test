using Microsoft.AspNetCore.SignalR;

namespace BeeTest.Hubs
{
    public class ClockHub : Hub
    {
        public Task SendMessage()
        {
            return Clients.All.SendAsync("ReceiveMessage", DateTime.Now.ToString());
        }
    }
}
