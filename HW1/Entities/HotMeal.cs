namespace HW1.Entities
{
    public class HotMeal : Meal
    {
        public HotMeal(int ıd, string name, int price) 
        {
            Id = ıd;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                   $"Name: {this.Name}\n" +
                   $"Price: {this.Price}\n";
        }
    }
}
