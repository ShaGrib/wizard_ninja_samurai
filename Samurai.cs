using System;

namespace wizard_ninja_samurai
{
    class Samurai : Human
    {

        public Samurai(string nmspace, int stre, int inte, int dext) : base(nmspace, stre, inte, dext,200)
        {
            Name = nmspace;
            Strength = stre;
            Intelligence = inte;
            Dexterity = dext;
        }

        public override int Attack(Human target)
        {
            if (target.health < 50)
            {
                target.health = 0;
                Console.WriteLine($"{target.Name} was sliced clean in two and has {target.health} Health now.");
            } else 
            {
                base.Attack(target);
            }
            return target.health;
        }

        public int Meditate()
        {
            this.health = 200;
            Console.WriteLine($"{Name} focused and meditated restoring their vitality to {health}.");
            return this.health;
        }
    }
}