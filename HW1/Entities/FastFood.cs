namespace HW1.Entities
{
    public class FastFood : Meal
    {
        public FastFood(int id, string name, int price, string volume)
        {
            Id = id;
            Name = name;
            Price = price;
            Volume = volume;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Volume { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                   $"Name: {this.Name}\n" +
                   $"Price: {this.Price}\n" +
                   $"Volume: {this.Volume}\n";
        }
    }
}
