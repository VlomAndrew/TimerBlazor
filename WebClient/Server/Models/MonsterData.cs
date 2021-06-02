using System;
using System.Drawing;
using System.Net.Mime;
using WebClient.Shared.AuxClasses;

namespace WebClient.Server.Models
{
    public class MonsterData : BaseEntity
    {
        public MonsterData() : base() { }

        public string Name { get; protected set; }

        public TimeSpan TimeSpawn { get; protected set; }

        public string Color { get; set; }

        public byte[] LogoImageData { get; protected set; }

        public MonsterData(string name, TimeSpan time, byte[] logoImageData, string color) : base()
        {
            Name = name;
            TimeSpawn = time;
            LogoImageData = logoImageData;
            Color = color;
        }

        public void Change(string name, TimeSpan time, byte[] logoImageData, string color)
        {
            Name = name;
            TimeSpawn = time;
            LogoImageData = logoImageData;
            Color = color;
        }
    }
}