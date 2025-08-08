using System.ComponentModel;

namespace ViewModelFirstMVVM
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Product _product;

        public ProductViewModel()
        {
            _product = new Product
            {
                Id = 1,
                Name = "Sample Product",
                Price = 19.99m
            };
        }

        public int Id
        {
            get { return _product.Id; }
            set
            {
                if (_product.Id != value)
                {
                    _product.Id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public string Name
        {
            get { return _product.Name; }
            set
            {
                if (_product.Name != value)
                {
                    _product.Name = value;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Description)); // Update Description when Name changes
                }
            }
        }

        public decimal Price
        {
            get { return _product.Price; }
            set
            {
                if (_product.Price != value)
                {
                    _product.Price = value;
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Description)); // Update Description when Price changes
                }
            }
        }

        public string Description
        {
            get
            {
                return $"{Name} | Id - {Id} | Price = ${Price}";
            }
        }

    }
}
