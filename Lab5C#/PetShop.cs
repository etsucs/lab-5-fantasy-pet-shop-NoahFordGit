namespace Lab5C_
{
    internal class PetShop
    {
        public List<FantasyPet> Pets { get; set; }

        public PetShop() 
        {
            Pets = new List<FantasyPet>();
        }

        public string AddPet(FantasyPet pet)
        {
            Pets.Add(pet);
            return $"You added a {pet.Name} to the shop!";
        }

        public void listPets()
        {
            foreach (FantasyPet pet in Pets)
            {
                Console.WriteLine($"\n----- {pet.Name} ------");
                Console.WriteLine(pet.DescribePet());
            }

            return ;
        }
    }
}
