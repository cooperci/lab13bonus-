using System;
namespace lab13bonus
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter( string  name, int strength, int intelligence)

        {

            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        //had to change to virtual ??
        public virtual void Play()
        {
            Console.WriteLine($" The name of the Character is: {Name}");
            Console.WriteLine($" The Strength is: {Strength}");
            Console.WriteLine($" The Intelligence is: {Intelligence}");
        }

    }
}
