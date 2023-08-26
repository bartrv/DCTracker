using DCTracker.Domain.Characters.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

namespace DCTracker.Domain.Characters.Services
{
    public class CharacterCreator
    {
        public Character Character { get; private set; }

        public CharacterCreator()
        {
            Character = new Character();
        }

        public CharacterCreator(Character character) 
        {
            Character = character;
        }

        public void SetAttributeValue(Character.Attributes attribute, int value)
        {
            Models.Attribute newAttribute = new(attribute,value);
            PropertyInfo attributeProperty = typeof(Character).GetProperty(attribute.ToString());
            attributeProperty.SetValue(this, Convert.ChangeType(newAttribute, attributeProperty.PropertyType), null);
        }

        public void SetSkill(Character.Skills skill, int value)
        {
            PropertyInfo skillProperty = typeof(Character).GetProperty(skill.ToString());
            Skill characterSkill = (Skill)skillProperty.GetValue(Character);
            characterSkill.Value = value;
            skillProperty.SetValue(Character,characterSkill,null);
        }

        public void SetSkillSpecialization(Character.Skills skill, string specializationName, int value)
        {
            Skill skillProperty = (Skill)typeof(Character).GetProperty(skill.ToString()).GetValue(Character);
            if (skillProperty.Specializations.Keys.Any(k => string.Equals(k, specializationName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Specialization already exists");
            }

            if (value <= skillProperty.Value)
            {
                throw new Exception("Specialization must be higher than base skill value");
            }

            skillProperty.AddSpecialization(specializationName,value);
        }

        internal virtual void SaveAttributeValue(Models.Attribute attribute)
        {
            CharacterDataManager.UpdateAttributeValue(Character.Id, attribute);
        }

        internal virtual void SaveSkillValue(Skill skill)
        {
            CharacterDataManager.UpdateSkillValue(Character.Id, skill);
        }
    }
}
