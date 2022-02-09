namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard joofy = new Wizard("Joofy",5,5);
            Samurai ragamuffin = new Samurai("Ragamuffin",10,5,5);
            Ninja sho = new Ninja("Sho",5,5,100);
            joofy.Attack(ragamuffin);
            joofy.Heal(ragamuffin);
            sho.Attack(joofy);
            sho.Steal(ragamuffin);
            ragamuffin.Attack(joofy);
            ragamuffin.Meditate();
        }
    }
}