using Windows.UI.Xaml.Controls;

namespace XBindConverterSimulation
{
    public sealed partial class MainPage : Page
    {
        #region Properties

        public MainViewModel ViewModel { get; } = new MainViewModel();

        #endregion

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
