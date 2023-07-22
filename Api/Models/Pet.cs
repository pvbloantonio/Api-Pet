namespace Api.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public double Age { get; set; }
        public float Weight { get; set; }
        public DateTime Created { get; set; }   
        public DateTime Updated { get; set; }

    }
}
