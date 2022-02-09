using System;

namespace wizard_ninja_samurai
{
    class Ninja : Human
    {

        public Ninja(string nmspace, int stre, int inte, int hp) : base(nmspace, stre, inte, 175, hp)
        {
            Name = nmspace;
            Strength = stre;
            Intelligence = inte;
            health = hp;
        }

        public override int Attack(Human target)
        {
            Random random = new Random();
            int chance = random.Next(100);
            if (chance < 81)
            {
                int damage = Dexterity * 5;
                target.health -= damage;
                Console.WriteLine($"{target.Name} was attacked by {Name} for {damage} points of health.");
            } else
            {
                int damage = 10 + Dexterity * 5;
                target.health -= damage;
                Console.WriteLine($"{target.Name} was attacked by {Name} for {damage} points of health.");
            }
            return target.health;
        }

        public int Steal(Human target)
        {
            int stolen = target.health -= 5;
            int recovered = this.health += 5;
            Console.WriteLine($"{target.Name} had {stolen} health stolen by {Name} and {Name} restored health for {recovered} points.");
            return target.health;
        }
    }
}