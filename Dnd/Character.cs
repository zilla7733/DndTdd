using System;

namespace Dnd
{
    public class Character
    {
        public string Name { get; set; }

        public DndEnum.Alignment Alignment { get; set; }

        public int ArmorClass { get; set; }

        public int HitPoints { get; set; }

        public bool IsDead => HitPoints <= 0;

        public Ability Strength { get; set; }
        public Ability Dexterity { get; set; }
        public Ability Constitution { get; set; }
        public Ability Wisdom { get; set; }
        public Ability Intelligence { get; set; }
        public Ability Charisma { get; set; }


        public Character()
        {
            ArmorClass = 10;
            HitPoints = 5;
            Strength = new Ability();
            Dexterity = new Ability();
            Constitution = new Ability();
            Wisdom = new Ability();
            Intelligence = new Ability();
            Charisma = new Ability();

        }

    }
}
