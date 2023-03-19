namespace RazorPages_PizzaStore.Model
{
    public class Pizza
    {
        public string ImageTitle { get; set; }
        public string Name { get; set; }
        public float BasePrice { get; set; } = 2;

        public bool Sauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }

        public float FinalPrice { get; set; }
    }
}
