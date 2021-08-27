using System.Collections.Generic;
using XBindConverterSimulation.ComponentModel;

namespace XBindConverterSimulation
{
    public class MainViewModel : NotifyPropertyChangedBase
    {
        #region Fields

        private string[] _itemsSource = new string[]
        {
            "Test 1",
            "Test 2",
            "Test 3",
            null
        };

        private string _selectedItem;

        #endregion

        #region Properties

        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public IEnumerable<string> ItemsSource => _itemsSource;

        #endregion

        #region Constructor

        public MainViewModel()
        {
            _selectedItem = _itemsSource[0];
        }

        #endregion
    }
}
