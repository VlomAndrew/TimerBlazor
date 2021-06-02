using System.Collections;
using System.Collections.Generic;

namespace WebClient.Server.Models
{
    public class ServerMonster : BaseEntity
    {
        public ICollection<MonsterHistoryData> History { get; init; }

        public MonsterData Monster { get; init; }

        public ServerData Server { get; init; }

        public ServerMonster() : base()
        {
        }

    }
}