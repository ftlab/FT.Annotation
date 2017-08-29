using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        [StringLength(15)]
        public string Name
        {
            get
            {
                return Data.Name;
            }
            set
            {
                Data.Name = value;

                PropertyChanged
                    ?.Invoke(
                        sender: this
                        , e: new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public Employee Data => _data;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
