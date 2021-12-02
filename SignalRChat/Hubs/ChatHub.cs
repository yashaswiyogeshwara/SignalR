using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageAsync(string user, string message) {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
