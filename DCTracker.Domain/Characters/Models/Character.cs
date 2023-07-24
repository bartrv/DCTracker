using System;
using System.Collections.Generic;
using System.Text;

namespace DCTracker.Models
{
    public class Character
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
    }
}
