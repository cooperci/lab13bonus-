using System;
namespace lab13bonus
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get;}

        public Warrior(string weaponType, string name, int strength, int intelligence): base (name, strength, intelligence)
        {

            WeaponType = weaponType;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"The property is:{ WeaponType}");
        }

    }
}
