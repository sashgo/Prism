namespace ButterfliesXFPrism.Models
{
    public class Butterfly
    {
        public string ID { get; }
        public string Name { get; }
        public string Description { get; }
        public string ImageSource { get; }

        public Butterfly(){}

        public Butterfly(string id, string name, string description, string imageSource)
        {
            ID = id;
            Name = name;
            Description = description;
            ImageSource = imageSource;
        }
    }
}
