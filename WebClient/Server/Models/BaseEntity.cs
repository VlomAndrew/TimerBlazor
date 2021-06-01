using System;
using System.Collections.Generic;

namespace WebClient.Server.Models
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}