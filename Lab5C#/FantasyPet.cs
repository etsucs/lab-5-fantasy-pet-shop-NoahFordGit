namespace Lab5C_
{
    internal class FantasyPet
    {
        public string Name { get; set; }
        public string Species { get; set; } // Dragon, Phoenix, Unicorn, Slyph, Golem | last two are chatgpt
        public int Age { get; set; }
        public int Price { get; set; }
        public string MagicPower { get; set; }

        public FantasyPet(string name, string species, int age, int price, string magicPower)
        {
            Name = name;
            Species = species;
            Age = age;
            Price = price;
            MagicPower = magicPower;
        }

        public string DescribePet()
        { return $"This pet is called {Name}, is a {Species}, and costs ${Price}. It is {Age} years old and has the power to {MagicPower}."; }

        public double DiscountPrice(double percent)
        { return percent * Price; }

        public string PerformMagic() // all descriptions chatgpt
        {
            if (Species == "Dragon")
                return "The Dragon exhales a torrent of blazing flames, its roar echoing with ancient power.";
            else if (Species == "Phoenix")
                return "The Phoenix spreads its wings, releasing a surge of fiery energy that cleanses and renews.";
            else if (Species == "Unicorn")
                return "The Unicorn lowers its horn, emitting a gentle light that mends wounds and restores vitality.";
            else if (Species == "Slyph")
                return "The Sylph dances gracefully, conjuring swirling winds that whisper secrets of the skies.";
            else if (Species == "Golem")
                return "The Golem raises its stony arms, channeling the earth's strength to form an unbreakable barrier.";

            return "You're pets power is unknown...";
        }
    }
}
