using System;
using WebClient.Shared.AuxClasses;

namespace WebClient.Server.Models
{
    public class BossData : BaseEntity
    {
        public BossData():base(){}

        public string Name { get; protected set; }

        public TimeSpan TimeSpawn { get; protected set; }

        public BossData(string name, TimeSpan time) : base()
        {
            Name = name;
            TimeSpawn = time;
        }

        public void Change(string name, TimeSpan time)
        {
            Name = name;
            TimeSpawn = time;
        }
    }
}