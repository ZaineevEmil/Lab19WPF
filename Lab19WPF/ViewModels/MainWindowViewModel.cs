using Lab19WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab19WPF.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged ([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        private double circle;
        public double Сircle
        {
            get => circle;
            set
            {
                circle = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Сircle = Arif.Add(Radius);
        }

        private bool CanAddCommandExecute(object p)
        {
            if (Radius > 0) return true;
            else return false;
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecute);
        }

    }
}
