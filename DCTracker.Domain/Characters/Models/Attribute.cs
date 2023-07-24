using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using DCTracker.Domain.Characters.Services;

namespace DCTracker.Domain.Characters.Models
{
    public class Attribute
    {
        internal Character.Attributes _attribute { get; private set; }
        public string AttributeName => _attribute.ToString();

        [Range(0, int.MaxValue, ErrorMessage = "Negative Number Not Allowed")]
        public int Value { get; internal set; }

        public Attribute(Character.Attributes attribute, int value)
        {
            _attribute = attribute;
            Value = value;
        }
    }
}
