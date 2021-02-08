using System;
namespace lab13bonus
{
    public class Wizard : MagicUsingCharcter
    {
        public int SpellNumber{ get; set; }

        public Wizard(int spellNumber, int magicalEnergy, string name, int strength, int intelligence) : base (magicalEnergy, name, strength, intelligence)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"The property is:{ SpellNumber}");
        }


    }
}
