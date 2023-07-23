using System;
using System.Collections.Generic;
using System.Text;

namespace DCTracker.Models
{
    public class Player
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
    }
}
