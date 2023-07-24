using System;
using System.Collections.Generic;
using System.Text;
using DCTracker.Domain.Characters.Services;

namespace DCTracker.Domain.Characters
{
    public static class ExtensionMethods
    {
        public static string SkillName(this CharacterManager.Skills skill)
        {
            switch (skill)
            {
                case CharacterManager.Skills.MartialArts:
                    return "Martial Arts";
                case CharacterManager.Skills.MeleeWeapons:
                    return "Melee Weapons";
                case CharacterManager.Skills.MissileWeapons:
                    return "Missile Weapons";
                case CharacterManager.Skills.SleightOfHand:
                    return "Sleight Of Hand";
                case CharacterManager.Skills.ThrownWeapons:
                    return "Thrown Weapons";
                case CharacterManager.Skills.ComputerOps:
                    return "Computer Ops";
                case CharacterManager.Skills.AnimalHandling:
                    return "Animal Handling";
                default:
                    return skill.ToString();
            }
        }

        public static CharacterManager.Attributes SkillParentAttribute(this CharacterManager.Skills skill)
        {
            switch (skill)
            {
				case CharacterManager.Skills.Acrobatics:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Boating:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Brawling:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Climbing:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Dodge:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Driving:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.MartialArts:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.MeleeWeapons:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Piloting:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Riding:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Sneak:
					return CharacterManager.Attributes.Reflexes;
				case CharacterManager.Skills.Catch:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.Lockpicking:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.Marksmanship:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.MissileWeapons:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.SleightOfHand:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.Thievery:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.ThrownWeapons:
					return CharacterManager.Attributes.Coordination;
				case CharacterManager.Skills.Flying:
					return CharacterManager.Attributes.Physique;
				case CharacterManager.Skills.Leap:
					return CharacterManager.Attributes.Physique;
				case CharacterManager.Skills.Lifting:
					return CharacterManager.Attributes.Physique;
				case CharacterManager.Skills.Resistance:
					return CharacterManager.Attributes.Physique;
				case CharacterManager.Skills.Running:
					return CharacterManager.Attributes.Physique;
				case CharacterManager.Skills.Swimming:
					return CharacterManager.Attributes.Physique;
				case CharacterManager.Skills.ArcaneLore:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.ComputerOps:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Criminology:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Demolitions:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Forgery:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Languages:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Medicine:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Navigation:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Research:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Scholar:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Science:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Security:
					return CharacterManager.Attributes.Knowledge;
				case CharacterManager.Skills.Artist:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Engineering:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Hide:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Invent:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Repair:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Search:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Shadowing:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Streetwise:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Surveillance:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Survival:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.Tracking:
					return CharacterManager.Attributes.Perception;
				case CharacterManager.Skills.AnimalHandling:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Bluff:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Charm:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Command:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Disguise:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Interrogation:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Intimidation:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Persuasion:
					return CharacterManager.Attributes.Presence;
				case CharacterManager.Skills.Willpower:
					return CharacterManager.Attributes.Presence;
				default:
					throw new Exception("Invalid Skill Passed");
			}
        }
    }
}
