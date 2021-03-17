using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRhubApi.SignalHubs
{
    public class myhub : Hub
    {
        public async Task sendMessageToAllClients(string msg)
        {
            await Clients.All.SendAsync("clientmessages", msg);
        }
    }
}
