using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace BasicSample
{
    [HubName("myHub")]
    public class DemoHub : Hub
    {
        static int _Counter = 0;

        public override Task OnConnected()
        {
            _Counter += 1;

            Clients.All.connectionCounted(_Counter);

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            _Counter -= 1;

            Clients.All.connectionCounted(_Counter);

            return base.OnDisconnected(stopCalled);
        }

        public void MoveObject(double x, double y)
        {
            Clients.Others.objectMoved(x, y);
        }

    }
}