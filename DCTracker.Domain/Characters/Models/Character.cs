using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public string CharacterName { get; set; }
        public string AlternateIdentity { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }
        public int Speed { get; set; }
        public int TechLevel { get; set; }
        public int CurrentCharacterPoints { get; set; }
        public int TotalCharacterPoints { get; set; }
        public int HeroPoints { get; set; }
        public int VillianPoints { get; set; }
        public int BodyPoints { get; set; }

        public int BDV => CalculateBDV();
        public int PDV => CalculatePDV();
        public int LiftingBonus => CalculateLiftingBonus();

        internal int PDVAdditives { get; set; }
        internal int LiftingBonusAdditives { get; set; }
        internal bool IsCharacterFinished { get; set; } = false;

        #region Attributes
        public Attribute Reflexes { get; internal set; } = new Attribute(Attributes.Reflexes, 0);
        public Attribute Coordination { get; internal set; } = new Attribute(Attributes.Coordination, 0);
        public Attribute Physique { get; internal set; } = new Attribute(Attributes.Physique, 0);
        public Attribute Knowledge { get; internal set; } = new Attribute(Attributes.Knowledge, 0);
        public Attribute Perception { get; internal set; } = new Attribute(Attributes.Perception, 0);
        public Attribute Presence { get; internal set; } = new Attribute(Attributes.Presence, 0);
        #endregion

        #region Skills
        public Skill Acrobatics { get; internal set; } = new Skill(Skills.Acrobatics);
        public Skill Boating { get; internal set; } = new Skill(Character.Skills.Boating);
        public Skill Brawling { get; internal set; } = new Skill(Character.Skills.Brawling);
        public Skill Climbing { get; internal set; } = new Skill(Character.Skills.Climbing);
        public Skill Dodge { get; internal set; } = new Skill(Character.Skills.Dodge);
        public Skill Driving { get; internal set; } = new Skill(Character.Skills.Driving);
        public Skill MartialArts { get; internal set; } = new Skill(Character.Skills.MartialArts);
        public Skill MeleeWeapons { get; internal set; } = new Skill(Character.Skills.MeleeWeapons);
        public Skill Piloting { get; internal set; } = new Skill(Character.Skills.Piloting);
        public Skill Riding { get; internal set; } = new Skill(Character.Skills.Riding);
        public Skill Sneak { get; internal set; } = new Skill(Character.Skills.Sneak);
        public Skill Catch { get; internal set; } = new Skill(Character.Skills.Catch);
        public Skill Lockpicking { get; internal set; } = new Skill(Character.Skills.Lockpicking);
        public Skill Marksmanship { get; internal set; } = new Skill(Character.Skills.Marksmanship);
        public Skill MissileWeapons { get; internal set; } = new Skill(Character.Skills.MissileWeapons);
        public Skill SleightOfHand { get; internal set; } = new Skill(Character.Skills.SleightOfHand);
        public Skill Thievery { get; internal set; } = new Skill(Character.Skills.Thievery);
        public Skill ThrownWeapons { get; internal set; } = new Skill(Character.Skills.ThrownWeapons);
        public Skill Flying { get; internal set; } = new Skill(Character.Skills.Flying);
        public Skill Leap { get; internal set; } = new Skill(Character.Skills.Leap);
        public Skill Lifting { get; internal set; } = new Skill(Character.Skills.Lifting);
        public Skill Resistance { get; internal set; } = new Skill(Character.Skills.Resistance);
        public Skill Running { get; internal set; } = new Skill(Character.Skills.Running);
        public Skill Swimming { get; internal set; } = new Skill(Character.Skills.Swimming);
        public Skill ArcaneLore { get; internal set; } = new Skill(Character.Skills.ArcaneLore);
        public Skill ComputerOps { get; internal set; } = new Skill(Character.Skills.ComputerOps);
        public Skill Criminology { get; internal set; } = new Skill(Character.Skills.Criminology);
        public Skill Demolitions { get; internal set; } = new Skill(Character.Skills.Demolitions);
        public Skill Forgery { get; internal set; } = new Skill(Character.Skills.Forgery);
        public Skill Languages { get; internal set; } = new Skill(Character.Skills.Languages);
        public Skill Medicine { get; internal set; } = new Skill(Character.Skills.Medicine);
        public Skill Navigation { get; internal set; } = new Skill(Character.Skills.Navigation);
        public Skill Research { get; internal set; } = new Skill(Character.Skills.Research);
        public Skill Scholar { get; internal set; } = new Skill(Character.Skills.Scholar);
        public Skill Science { get; internal set; } = new Skill(Character.Skills.Science);
        public Skill Security { get; internal set; } = new Skill(Character.Skills.Security);
        public Skill Artist { get; internal set; } = new Skill(Character.Skills.Artist);
        public Skill Engineering { get; internal set; } = new Skill(Character.Skills.Engineering);
        public Skill Hide { get; internal set; } = new Skill(Character.Skills.Hide);
        public Skill Invent { get; internal set; } = new Skill(Character.Skills.Invent);
        public Skill Repair { get; internal set; } = new Skill(Character.Skills.Repair);
        public Skill Search { get; internal set; } = new Skill(Character.Skills.Search);
        public Skill Shadowing { get; internal set; } = new Skill(Character.Skills.Shadowing);
        public Skill Streetwise { get; internal set; } = new Skill(Character.Skills.Streetwise);
        public Skill Surveillance { get; internal set; } = new Skill(Character.Skills.Surveillance);
        public Skill Survival { get; internal set; } = new Skill(Character.Skills.Survival);
        public Skill Tracking { get; internal set; } = new Skill(Character.Skills.Tracking);
        public Skill AnimalHandling { get; internal set; } = new Skill(Character.Skills.AnimalHandling);
        public Skill Bluff { get; internal set; } = new Skill(Character.Skills.Bluff);
        public Skill Charm { get; internal set; } = new Skill(Character.Skills.Charm);
        public Skill Command { get; internal set; } = new Skill(Character.Skills.Command);
        public Skill Disguise { get; internal set; } = new Skill(Character.Skills.Disguise);
        public Skill Interrogation { get; internal set; } = new Skill(Character.Skills.Interrogation);
        public Skill Intimidation { get; internal set; } = new Skill(Character.Skills.Intimidation);
        public Skill Persuasion { get; internal set; } = new Skill(Character.Skills.Persuasion);
        public Skill Willpower { get; internal set; } = new Skill(Character.Skills.Willpower);
        #endregion
        
        public void FinishCharacterCreation()
        {
            IsCharacterFinished = true;
        }

        private int CalculatePDV()
        {
            return (int)Math.Ceiling((decimal)((new List<int>() { Reflexes.Value, Acrobatics.Value, Dodge.Value }.Max() + PDVAdditives) / 2));
        }

        private int CalculateLiftingBonus()
        {
            return (int)(Math.Floor((decimal)new List<int>() { Physique.Value, Lifting.Value }.Max()) / 2) + LiftingBonusAdditives;
        }

        private int CalculateBDV()
        {
            int defaultValue = Brawling.Value > 0 ? 2 : 1;
            int attributeAdditive = LiftingBonus;
            int brawlingValue = (int)Math.Floor((decimal)Brawling.Value / 3);
            return defaultValue + attributeAdditive + brawlingValue;
        }
    }
}
