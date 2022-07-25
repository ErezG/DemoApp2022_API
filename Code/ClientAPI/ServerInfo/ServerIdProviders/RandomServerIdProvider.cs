namespace ClientAPI.ServerInfoData.ServerID
{
    public class RandomServerIdProvider : IServerIdProvider
    {
        public async Task<int> GetServerId()
        {
            //await Task.Delay(TimeSpan.FromSeconds(30));
            var rnd = new Random();
            return rnd.Next(1, 1000);
        }
    }
}
