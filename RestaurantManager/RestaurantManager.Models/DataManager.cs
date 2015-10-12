using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace RestaurantManager.Models
{
    public class DataManager:DependencyObject //i guess?
    {
        public ObservableCollection<string> OrderItems { get; set; }
        public List<string> MenuItems { get; set; }
        public List<string> CurrentlySelectedMenuItems { get; set; }

        public DataManager()
        {
            this.OrderItems = new ObservableCollection<string>(new List<string>{
                "Steak, Chicken, Peas",
                    "Rice, Chicken",
                    "Hummus, Pita"
            });
            this.MenuItems = new List<string> {
                "Steak",
                "Chicken",
                "Peas",
                "Rice",
                "Hummus",
                "Pita"
            };
            this.CurrentlySelectedMenuItems = new List<string> {
                "Rice",
                "Pita"
            };  
        }
    }
}
