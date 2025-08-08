using System;
using System.ComponentModel;
using System.Windows;

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
