using System;
using System.Collections.Generic;
using System.Text;
using DCTracker.Domain.Characters.Models;
using DCTracker.Domain.Characters.Services;

namespace DCTracker.Domain.Characters
{
    public static class ExtensionMethods
    {
        public static string SkillName(this Character.Skills skill)
        {
            switch (skill)
            {
                case Character.Skills.MartialArts:
                    return "Martial Arts";
                case Character.Skills.MeleeWeapons:
                    return "Melee Weapons";
                case Character.Skills.MissileWeapons:
                    return "Missile Weapons";
                case Character.Skills.SleightOfHand:
                    return "Sleight Of Hand";
                case Character.Skills.ThrownWeapons:
                    return "Thrown Weapons";
                case Character.Skills.ComputerOps:
                    return "Computer Ops";
                case Character.Skills.AnimalHandling:
                    return "Animal Handling";
                default:
                    return skill.ToString();
            }
        }

        public static Character.Attributes SkillParentAttribute(this Character.Skills skill)
        {
            switch (skill)
            {
				case Character.Skills.Acrobatics:
					return Character.Attributes.Reflexes;
				case Character.Skills.Boating:
					return Character.Attributes.Reflexes;
				case Character.Skills.Brawling:
					return Character.Attributes.Reflexes;
				case Character.Skills.Climbing:
					return Character.Attributes.Reflexes;
				case Character.Skills.Dodge:
					return Character.Attributes.Reflexes;
				case Character.Skills.Driving:
					return Character.Attributes.Reflexes;
				case Character.Skills.MartialArts:
					return Character.Attributes.Reflexes;
				case Character.Skills.MeleeWeapons:
					return Character.Attributes.Reflexes;
				case Character.Skills.Piloting:
					return Character.Attributes.Reflexes;
				case Character.Skills.Riding:
					return Character.Attributes.Reflexes;
				case Character.Skills.Sneak:
					return Character.Attributes.Reflexes;
				case Character.Skills.Catch:
					return Character.Attributes.Coordination;
				case Character.Skills.Lockpicking:
					return Character.Attributes.Coordination;
				case Character.Skills.Marksmanship:
					return Character.Attributes.Coordination;
				case Character.Skills.MissileWeapons:
					return Character.Attributes.Coordination;
				case Character.Skills.SleightOfHand:
					return Character.Attributes.Coordination;
				case Character.Skills.Thievery:
					return Character.Attributes.Coordination;
				case Character.Skills.ThrownWeapons:
					return Character.Attributes.Coordination;
				case Character.Skills.Flying:
					return Character.Attributes.Physique;
				case Character.Skills.Leap:
					return Character.Attributes.Physique;
				case Character.Skills.Lifting:
					return Character.Attributes.Physique;
				case Character.Skills.Resistance:
					return Character.Attributes.Physique;
				case Character.Skills.Running:
					return Character.Attributes.Physique;
				case Character.Skills.Swimming:
					return Character.Attributes.Physique;
				case Character.Skills.ArcaneLore:
					return Character.Attributes.Knowledge;
				case Character.Skills.ComputerOps:
					return Character.Attributes.Knowledge;
				case Character.Skills.Criminology:
					return Character.Attributes.Knowledge;
				case Character.Skills.Demolitions:
					return Character.Attributes.Knowledge;
				case Character.Skills.Forgery:
					return Character.Attributes.Knowledge;
				case Character.Skills.Languages:
					return Character.Attributes.Knowledge;
				case Character.Skills.Medicine:
					return Character.Attributes.Knowledge;
				case Character.Skills.Navigation:
					return Character.Attributes.Knowledge;
				case Character.Skills.Research:
					return Character.Attributes.Knowledge;
				case Character.Skills.Scholar:
					return Character.Attributes.Knowledge;
				case Character.Skills.Science:
					return Character.Attributes.Knowledge;
				case Character.Skills.Security:
					return Character.Attributes.Knowledge;
				case Character.Skills.Artist:
					return Character.Attributes.Perception;
				case Character.Skills.Engineering:
					return Character.Attributes.Perception;
				case Character.Skills.Hide:
					return Character.Attributes.Perception;
				case Character.Skills.Invent:
					return Character.Attributes.Perception;
				case Character.Skills.Repair:
					return Character.Attributes.Perception;
				case Character.Skills.Search:
					return Character.Attributes.Perception;
				case Character.Skills.Shadowing:
					return Character.Attributes.Perception;
				case Character.Skills.Streetwise:
					return Character.Attributes.Perception;
				case Character.Skills.Surveillance:
					return Character.Attributes.Perception;
				case Character.Skills.Survival:
					return Character.Attributes.Perception;
				case Character.Skills.Tracking:
					return Character.Attributes.Perception;
				case Character.Skills.AnimalHandling:
					return Character.Attributes.Presence;
				case Character.Skills.Bluff:
					return Character.Attributes.Presence;
				case Character.Skills.Charm:
					return Character.Attributes.Presence;
				case Character.Skills.Command:
					return Character.Attributes.Presence;
				case Character.Skills.Disguise:
					return Character.Attributes.Presence;
				case Character.Skills.Interrogation:
					return Character.Attributes.Presence;
				case Character.Skills.Intimidation:
					return Character.Attributes.Presence;
				case Character.Skills.Persuasion:
					return Character.Attributes.Presence;
				case Character.Skills.Willpower:
					return Character.Attributes.Presence;
				default:
					throw new Exception("Invalid Skill Passed");
			}
        }
    }
}
