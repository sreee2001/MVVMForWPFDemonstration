using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicMVVM
{
    /// <summary>
    /// Interaction logic for CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        public CarWindow()
        {
            InitializeComponent();

            // Create a sample car and its view model
            Car car = new Car("Toyota", "Corolla", 2020);
            CarViewModel carViewModel = new CarViewModel(car);
            DataContext = carViewModel;
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    public class CarViewModel
    {
        public Car Car { get; set; }
        public CarViewModel(Car car)
        {
            Car = car;
        }
    }
}
