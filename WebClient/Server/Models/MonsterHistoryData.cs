using System;

namespace WebClient.Server.Models
{
    public class MonsterHistoryData : BaseEntity
    {
        public ServerMonster ServerMonster { get; init; }

        public string UserName { get; init; }

        public DateTime ActionLastDate { get; init; }

        public string Comment { get; protected set; }

        public string Action { get; init; }

        public MonsterHistoryData(string comment) : base()
        {
            Comment = comment;
        }

        public void SetNewComment(string comment)
        {
            Comment = comment;
        }
    }
}