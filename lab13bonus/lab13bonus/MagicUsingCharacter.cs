using System;
namespace lab13bonus
{
    public class MagicUsingCharcter : GameCharacter

    {
        public int MagicalEngery { get; set; }


        public MagicUsingCharcter(int magicalEnergy, string name, int strength, int intelligence) : base(name, strength, intelligence)


         

 {
            MagicalEngery = magicalEnergy;


        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine( $"The property is:{ MagicalEngery}");
        }
        /// read that override must have return - tring to override play method

        //public override int 

       // public override Play()
        
           // return $"The name of the Character is: {Name}";
           // Console.WriteLine($" The Strength is: {Strength}");
            //Console.WriteLine($" The Intelligence is: {Intelligence}");
        }
    }
    

