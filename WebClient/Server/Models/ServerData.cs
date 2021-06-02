namespace WebClient.Server.Models
{
    public class ServerData : BaseEntity
    {
        public string ServerName { get; init; }

        public ServerData(string serverName) : base()
        {
            ServerName = serverName;
        }
    }
}