using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UdemyTipCalculator.Annotations;

namespace UdemyTipCalculator.Classes
{
    public class TipCalculator : INotifyPropertyChanged
    {
        private double _bill;
        public double Bill
        {
            get { return _bill; }
            set
            {
                _bill = value;
                OnPropertyChanged("Bill");
                OnPropertyChanged("Tip");
            }
        }

        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set
            {
                _percentage = value;
                OnPropertyChanged("Percentage");
                OnPropertyChanged("Tip");
            }
        }

        public string Tip
        {
            get { return "£" + Bill * Percentage / 100; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
