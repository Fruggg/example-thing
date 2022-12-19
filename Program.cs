namespace namespacee
{
    class Program
    {
        struct Country
        {
            public float GDP;
            public string name;
            public Country(string name, float GDP)
            {
                this.name = name;
                this.GDP = GDP;
            }
        }
        public static void Main(string[] args)
        {
            //create the instances
            Country US = new Country("U.S.A", 2);
            //the collection we'll use 
            Dictionary<string, Country> collection = new Dictionary<string, Country>();
            //add them
            collection.Add("America", US);


            Console.WriteLine("Choose your fate, O coward!\n\"America\"\n\"Ham\"");
            string choice = Console.ReadLine();

            //gets the correct country based on the entry. Null if the entry is invalid.
            Country selected = collection[choice];
            
        }
    }
}