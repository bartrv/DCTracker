using System;
using System.Collections.Generic;
using System.Text;

namespace DCTracker.Domain.Characters.Models
{
    public class Character
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

        public string Id { get; set; } = Guid.NewGuid().ToString("n");

        #region Attributes
        public Attribute Reflexes { get; private set; } = new Attribute(Attributes.Reflexes, 0);
        public Attribute Coordination { get; private set; } = new Attribute(Attributes.Coordination, 0);
        public Attribute Physique { get; private set; } = new Attribute(Attributes.Physique, 0);
        public Attribute Knowledge { get; private set; } = new Attribute(Attributes.Knowledge, 0);
        public Attribute Perception { get; private set; } = new Attribute(Attributes.Perception, 0);
        public Attribute Presence { get; private set; } = new Attribute(Attributes.Presence, 0);
        #endregion

        #region Skills
        public Skill Acrobatics { get; private set; } = new Skill(Skills.Acrobatics);
        public Skill Boating { get; private set; } = new Skill(Character.Skills.Boating);
        public Skill Brawling { get; private set; } = new Skill(Character.Skills.Brawling);
        public Skill Climbing { get; private set; } = new Skill(Character.Skills.Climbing);
        public Skill Dodge { get; private set; } = new Skill(Character.Skills.Dodge);
        public Skill Driving { get; private set; } = new Skill(Character.Skills.Driving);
        public Skill MartialArts { get; private set; } = new Skill(Character.Skills.MartialArts);
        public Skill MeleeWeapons { get; private set; } = new Skill(Character.Skills.MeleeWeapons);
        public Skill Piloting { get; private set; } = new Skill(Character.Skills.Piloting);
        public Skill Riding { get; private set; } = new Skill(Character.Skills.Riding);
        public Skill Sneak { get; private set; } = new Skill(Character.Skills.Sneak);
        public Skill Catch { get; private set; } = new Skill(Character.Skills.Catch);
        public Skill Lockpicking { get; private set; } = new Skill(Character.Skills.Lockpicking);
        public Skill Marksmanship { get; private set; } = new Skill(Character.Skills.Marksmanship);
        public Skill MissileWeapons { get; private set; } = new Skill(Character.Skills.MissileWeapons);
        public Skill SleightOfHand { get; private set; } = new Skill(Character.Skills.SleightOfHand);
        public Skill Thievery { get; private set; } = new Skill(Character.Skills.Thievery);
        public Skill ThrownWeapons { get; private set; } = new Skill(Character.Skills.ThrownWeapons);
        public Skill Flying { get; private set; } = new Skill(Character.Skills.Flying);
        public Skill Leap { get; private set; } = new Skill(Character.Skills.Leap);
        public Skill Lifting { get; private set; } = new Skill(Character.Skills.Lifting);
        public Skill Resistance { get; private set; } = new Skill(Character.Skills.Resistance);
        public Skill Running { get; private set; } = new Skill(Character.Skills.Running);
        public Skill Swimming { get; private set; } = new Skill(Character.Skills.Swimming);
        public Skill ArcaneLore { get; private set; } = new Skill(Character.Skills.ArcaneLore);
        public Skill ComputerOps { get; private set; } = new Skill(Character.Skills.ComputerOps);
        public Skill Criminology { get; private set; } = new Skill(Character.Skills.Criminology);
        public Skill Demolitions { get; private set; } = new Skill(Character.Skills.Demolitions);
        public Skill Forgery { get; private set; } = new Skill(Character.Skills.Forgery);
        public Skill Languages { get; private set; } = new Skill(Character.Skills.Languages);
        public Skill Medicine { get; private set; } = new Skill(Character.Skills.Medicine);
        public Skill Navigation { get; private set; } = new Skill(Character.Skills.Navigation);
        public Skill Research { get; private set; } = new Skill(Character.Skills.Research);
        public Skill Scholar { get; private set; } = new Skill(Character.Skills.Scholar);
        public Skill Science { get; private set; } = new Skill(Character.Skills.Science);
        public Skill Security { get; private set; } = new Skill(Character.Skills.Security);
        public Skill Artist { get; private set; } = new Skill(Character.Skills.Artist);
        public Skill Engineering { get; private set; } = new Skill(Character.Skills.Engineering);
        public Skill Hide { get; private set; } = new Skill(Character.Skills.Hide);
        public Skill Invent { get; private set; } = new Skill(Character.Skills.Invent);
        public Skill Repair { get; private set; } = new Skill(Character.Skills.Repair);
        public Skill Search { get; private set; } = new Skill(Character.Skills.Search);
        public Skill Shadowing { get; private set; } = new Skill(Character.Skills.Shadowing);
        public Skill Streetwise { get; private set; } = new Skill(Character.Skills.Streetwise);
        public Skill Surveillance { get; private set; } = new Skill(Character.Skills.Surveillance);
        public Skill Survival { get; private set; } = new Skill(Character.Skills.Survival);
        public Skill Tracking { get; private set; } = new Skill(Character.Skills.Tracking);
        public Skill AnimalHandling { get; private set; } = new Skill(Character.Skills.AnimalHandling);
        public Skill Bluff { get; private set; } = new Skill(Character.Skills.Bluff);
        public Skill Charm { get; private set; } = new Skill(Character.Skills.Charm);
        public Skill Command { get; private set; } = new Skill(Character.Skills.Command);
        public Skill Disguise { get; private set; } = new Skill(Character.Skills.Disguise);
        public Skill Interrogation { get; private set; } = new Skill(Character.Skills.Interrogation);
        public Skill Intimidation { get; private set; } = new Skill(Character.Skills.Intimidation);
        public Skill Persuasion { get; private set; } = new Skill(Character.Skills.Persuasion);
        public Skill Willpower { get; private set; } = new Skill(Character.Skills.Willpower);
        #endregion
    }
}
