using DCTracker.Domain.Characters.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

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
