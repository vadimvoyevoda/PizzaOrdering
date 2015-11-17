using System.Windows.Controls;

namespace PizzaOnline.Models
{
    /// <summary>
    /// Model to pizza item.
    /// </summary>
    public class PizzaItemModel
    {
        public Image Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int Counter { get; set; }
    }
}
