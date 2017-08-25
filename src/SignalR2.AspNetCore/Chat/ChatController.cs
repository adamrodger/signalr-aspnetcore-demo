using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR2.AspNetCore.Chat
{
    using System.IO;
    using System.Text;
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ChatMessage message)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            context.Clients.All.receiveMessage(message.Message);

            return this.Ok();
        }
    }
}
