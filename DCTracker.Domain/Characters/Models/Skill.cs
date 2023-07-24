using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DCTracker.Domain.Characters.Services;

namespace DCTracker.Domain.Characters.Models
{
    public class Skill
    {
        private CharacterManager.Skills _skill { get; set; }
        public string SkillName => _skill.SkillName();

        [Range(0, int.MaxValue, ErrorMessage = "Negative Number Not Allowed")]
        public int Value { get; private set; }
        public Dictionary<string, int> Specializations { get; private set; }

        public Skill(CharacterManager.Skills skill, int value)
        {
            _skill = skill;
            Value = value;
            Specializations = new Dictionary<string, int>();
        }

        public void IncrementSkill()
        {
            Value++;
            foreach (string key in Specializations.Keys)
            {
                Specializations[key] = Specializations[key] + 1;
            }
        }

        public void AddSpecialization(string specializationName, int specializationValue)
        {
            if (Specializations.Keys.Any(k => string.Equals(k, specializationName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Specialization already exists");
            }

            if (specializationValue <= Value)
            {
                throw new Exception("Specialization must be higher than base skill value");
            }

            Specializations.Add(specializationName, specializationValue);
        }
    }
}
