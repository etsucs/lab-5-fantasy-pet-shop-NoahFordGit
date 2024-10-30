namespace Lab5C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetShop petShop = new PetShop();

            // with hindsight should instantiated each pet as a variable, then added to the list but whatever
            petShop.AddPet(new FantasyPet("Kyle", "Dragon", 12, 900000, "Breathe intense flames"));
            petShop.AddPet(new FantasyPet("Jeremy", "Phoenix", 20, 4, "Ignite a healing fire"));
            petShop.AddPet(new FantasyPet("Hank", "Unicorn", 21, 5, "Radiate a healing glow"));
            petShop.AddPet(new FantasyPet("Carol", "Sylph", 40, 19, "Control swift winds"));
            petShop.AddPet(new FantasyPet("Jake", "Golem", 80, 200, "Wield earth’s strength"));

            // Describe each pet | Listing all pets in the shop
            petShop.listPets();

            Console.WriteLine();

            // Showing a discounted price for one more pets.
            Console.WriteLine($"{petShop.Pets[0].Name}'s discounted price is ${petShop.Pets[0].DiscountPrice(0.5)}."); // Kyle discounted 50%
            Console.WriteLine($"{petShop.Pets[4].Name}'s discounted price is ${petShop.Pets[4].DiscountPrice(0.5)}."); // Jake discounted 50%
            Console.WriteLine();

            // Performing magic for one or more pets
            Console.WriteLine(petShop.Pets[0].PerformMagic());
            Console.WriteLine(petShop.Pets[1].PerformMagic());
        }
    }
}
