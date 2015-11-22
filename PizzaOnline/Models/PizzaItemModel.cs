
using System.Drawing;

namespace PizzaOnline.Models
{
    /// <summary>
    /// Model to pizza item.
    /// </summary>
    public class PizzaItemModel : BaseModel
    {
        private int _counter;
        private double _price;
        private double _weight;
        private string _description;
        private string _name;
        private string _imgPath;

        public string ImagePath
        {
            get { return _imgPath; }
            set
            {
                _imgPath = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public int Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                OnPropertyChanged();
            }
        }
    }
}
