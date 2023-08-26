using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DCTracker.Domain.Characters.Services;
using System.Collections.Immutable;

namespace DCTracker.Domain.Characters.Models
{
    public class Skill
    {
        private Character.Skills _skill { get; set; }
        private Dictionary<string, int> _specializations { get; set; }
        public string SkillName => _skill.SkillName();

        [Range(0, int.MaxValue, ErrorMessage = "Negative Number Not Allowed")]
        public int Value { get; internal set; }
        public ImmutableDictionary<string,int> Specializations => _specializations.ToImmutableDictionary(e => e.Key, e => e.Value);

        public Skill(Character.Skills skill)
        {
            _skill = skill;
            Value = 0;
            _specializations = new Dictionary<string, int>();
        }

        public Skill(Character.Skills skill, int value)
        {
            _skill = skill;
            Value = value;
            _specializations = new Dictionary<string, int>();
        }

        //TODO: Does this need to move?
        internal virtual void IncrementSkill()
        {
            Value++;
        }

        internal virtual void AddSpecialization(string specializationName, int specializationValue)
        {
            _specializations.Add(specializationName, specializationValue);
        }
    }
}
