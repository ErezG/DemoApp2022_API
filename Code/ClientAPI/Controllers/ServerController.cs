using ClientAPI.ServerInfoData;
using Microsoft.AspNetCore.Mvc;

namespace ClientAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        public ServerController(ServerInfo serverInfo)
        {
            _serverInfo = serverInfo;
        }

        private readonly ServerInfo _serverInfo;

        [HttpGet("", Name = "ServerText")]
        public string GetServerText() => $"This is server number {_serverInfo.ServerId}";
        [HttpGet("Number", Name = "ServerNumber")]
        public int GetServerNumber() => _serverInfo.ServerId;
    }
}