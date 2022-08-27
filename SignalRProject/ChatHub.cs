using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRProject
{
    public class ChatHub : Hub
    {
        public void Send(string username, string password)
        {
            //Clients.All.broadcastMessage(username, password);
            Clients.All.broadcastMessage(username, password);
        }
    }
}