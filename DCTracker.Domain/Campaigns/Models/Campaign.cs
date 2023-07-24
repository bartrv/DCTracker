using System;
using System.Collections.Generic;
using System.Text;

namespace DCTracker.Models
{
    public class Campaign
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
    }
}
