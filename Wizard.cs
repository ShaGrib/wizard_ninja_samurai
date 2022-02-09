using System;

namespace wizard_ninja_samurai
{
    class Wizard : Human
    {

        public Wizard(string nmspace, int stre, int dext) : base(nmspace, stre, 25, dext,50)
        {
            Name = nmspace;
            Strength = stre;
            Dexterity = dext;
        }

        public override int Attack(Human target)
        {
            int damage = Intelligence * 5;
            target.health -= damage;
            this.health += damage;
            Console.WriteLine($"{target.Name} had a spell cast on them by {Name} for {damage} points of health which rejuvinated {Name} by {damage} points of health.");
            return target.health;
        }

        public int Heal(Human target)
        {
            int healing = target.health += Intelligence * 10;
            Console.WriteLine($"{target.Name} had {healing} health rejuvinated by {Name}.");
            return target.health;
        }
    }
}