namespace ButterfliesXFPrism.Models
{
    public class Butterfly
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Butterfly(){}

        public Butterfly(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
