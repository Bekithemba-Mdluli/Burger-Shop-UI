using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BurgerShop.ViewModel
{
    class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Items = GetItems();
            Headings = GetHeadings();
        }

        public List<Item> Items { get; set; }
        public List<Heading> Headings { get; set; }

        private List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Image = "burger.png", Title = "Burger", Price = "$25", Color = "#F7DEDA"},
                new Item { Image = "pizza.png", Title = "Pizza", Price = "$15", Color = "#FFE8B4"},
                new Item { Image = "donut.png", Title = "Donuts", Price = "$12", Color = "#CDF8C6"},
            };
        }

        private List<Heading> GetHeadings()
        {
            return new List<Heading>
            {
                new Heading { Title = "FEATURED"},
                new Heading { Title = "COMBOS"},
                new Heading { Title = "FAVORITES"},
                new Heading { Title = "OTHER"},
                new Heading { Title = "NEXT"},
                new Heading { Title = "OTHER MEXT"},
            };
        }
    }

    class Item
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
    }

    class Heading
    {
        public string Title { get; set; }
    }

    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
