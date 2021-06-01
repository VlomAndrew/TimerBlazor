using System;
using WebClient.Shared.AuxClasses;

namespace WebClient.Shared.Models
{
    [Serializable]
    public class BossBaseModel
    {
        public string Name { get; set; }
        public string TimeSpawn { get; set; }
    }
}