using System;
using System.Collections.Generic;
using System.Text;

namespace DCTracker.Models
{
    public class UserCharacters
    {
        public string UserName { get; set; }
        public IEnumerable<Character> Characters { get; set; } = new List<Character>();
    }
}
