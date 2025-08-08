using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ModelFirstMVVM
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public ICommand AddProductCommand { get; private set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
            LoadProducts(); // Populate initial data
            AddProductCommand = new RelayCommand(AddProduct); // Assuming a RelayCommand implementation
        }

        private void LoadProducts()
        {
            // Simulate loading data from a data source
            Products.Add(new Product { Id = 1, Name = "Laptop", Price = 1200.00m });
            Products.Add(new Product { Id = 2, Name = "Mouse", Price = 25.00m });
        }

        private void AddProduct(object parameter)
        {
            // Logic to add a new product (e.g., from user input)
            // For simplicity, add a dummy product
            Products.Add(new Product { Id = Products.Count + 1, Name = "New Item", Price = 50.00m });
        }
    }
}
