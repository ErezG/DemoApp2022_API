using ClientAPI.ServerInfoData.ServerID;

namespace ClientAPI.ServerInfoData
{
    public class ServerInfo
    {
        static ServerInfo()
        {
            Instance = new ServerInfo();
        }
        private ServerInfo()
        {
            _initTask = _internalInit();
        }

        public static ServerInfo Instance { get; }

        private readonly Task _initTask;
        public Task InitTask => _initTask;

        private int _serverId;
        public int ServerId
        {
            get
            {
                _initTask.Wait();
                return _serverId;
            }
        }

        private async Task _internalInit()
        {
            var serverIdProvider = new RandomServerIdProvider();
            _serverId = await serverIdProvider.GetServerId();
        }
    }
}
