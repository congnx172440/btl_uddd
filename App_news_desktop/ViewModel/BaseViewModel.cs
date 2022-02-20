using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.ComponentModel;

namespace App_news_desktop.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //Kich hoat su kien thong bao no co thay doi mot thuoc tinh nao do
        public event PropertyChangedEventHandler PropertyChanged;
        //Invoke() tranh xung dot luong
        //Thong bao co su thay doi
        //CallerMemberName thuc su khong biet thu se thay doi la gi
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    //Ho tro thuc thi command
    class RelayCommand<T> : ICommand
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        public RelayCommand(Predicate<T> canExecute, Action<T> execute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _canExecute = canExecute;
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            try
            {
                return _canExecute == null ? true : _canExecute((T)parameter);
            }
            catch
            {
                return true;
            }
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}