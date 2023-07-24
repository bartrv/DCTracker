using DCTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCTracker.Domain.Characters.Services
{
    public class CharacterManager
    {
        public enum Attributes
        {
            Reflexes,
            Coordination,
            Physique,
            Knowledge,
            Perception,
            Presence
        }

        public enum Skills
        {
            Acrobatics,
            Boating,
            Brawling,
            Climbing,
            Dodge,
            Driving,
            MartialArts,
            MeleeWeapons,
            Piloting,
            Riding,
            Sneak,
            Catch,
            Lockpicking,
            Marksmanship,
            MissileWeapons,
            SleightOfHand,
            Thievery,
            ThrownWeapons,
            Flying,
            Leap,
            Lifting,
            Resistance,
            Running,
            Swimming,
            ArcaneLore,
            ComputerOps,
            Criminology,
            Demolitions,
            Forgery,
            Languages,
            Medicine,
            Navigation,
            Research,
            Scholar,
            Science,
            Security,
            Artist,
            Engineering,
            Hide,
            Invent,
            Repair,
            Search,
            Shadowing,
            Streetwise,
            Surveillance,
            Survival,
            Tracking,
            AnimalHandling,
            Bluff,
            Charm,
            Command,
            Disguise,
            Interrogation,
            Intimidation,
            Persuasion,
            Willpower
        }

        public Character GetCharacter(Guid characterId)
        {
            return new Character();
        }

        public void UpdateAttribute(Attributes attribute, int )
        {

        }
    }
}
