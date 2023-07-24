using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using DCTracker.Domain.Characters.Services;

namespace DCTracker.Domain.Characters.Models
{
    public class Attribute
    {
        private Character.Attributes _attribute { get; set; }
        public string AttributeName => _attribute.ToString();

        [Range(0, int.MaxValue, ErrorMessage = "Negative Number Not Allowed")]
        public int Value { get; private set; }

        public Attribute(Character.Attributes attribute, int value)
        {
            _attribute = attribute;
            Value = value;
        }
    }
}
