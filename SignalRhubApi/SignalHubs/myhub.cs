using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRhubApi.SignalHubs
{
    //Hub is a abstract class
    public class myhub : Hub
    {
        public async Task sendMessageToAllClients(string msg)
        {
            await Clients.All.SendAsync("clientmessages", msg);
        }

        //When a user sings in of the hub
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("clientSignIn", Context.ConnectionId);
        }

        //When a user sings out of the hub
        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("clientSignOut", Context.ConnectionId);
        }
    }
}
