namespace ClientAPI.ServerInfoData.ServerID
{
    public interface IServerIdProvider
    {
        Task<int> GetServerId();
    }
}
