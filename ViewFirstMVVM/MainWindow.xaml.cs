using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ViewFirstMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create a new ViewModel and set it as the DataContext
            DataContext = new SampleViewModel();
        }
    }

    public class SampleViewModel : INotifyPropertyChanged
    {
        private string _loggedInUserName;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // Sample property for demonstration
        public string LoggedInUserName
        {
            get => _loggedInUserName;
            set
            {
                _loggedInUserName = value;
                OnPropertyChanged(nameof(LoggedInUserName));
            }
        }

        public SampleViewModel()
        {
            LoggedInUserName = Environment.UserName; // Set the logged-in user name
        }
    }
}
