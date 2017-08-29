using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation.Example
{
    /// <summary>
    /// Employee view model
    /// </summary>
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private readonly Employee _data;

        public EmployeeViewModel(Employee data)
        {
            data = _data ?? throw new ArgumentNullException(nameof(data));
        }

        public string Name
        {
            get
            {
                return _data.Name;
            }
            set
            {
                _data.Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
