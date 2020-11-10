using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DrivenSample.ViewModel
{
    public class DashboardViewModel: INotifyPropertyChanged
    {
        int taps = 0;
        ICommand _profileimageTappedCommand;
        ICommand _texasImageTappedCommand;
        public DashboardViewModel()
        {
            _profileimageTappedCommand = new Command(OnProfileTapped);
            _texasImageTappedCommand = new Command(OnTexasImageTapped);
        }
        public ICommand ProfileImageTapCommand
        {
            get { return _profileimageTappedCommand; }
        }

        public ICommand TexasTapCommand
        {
            get { return _texasImageTappedCommand; }
        }
        void OnProfileTapped()
        {
            Application.Current.MainPage.DisplayAlert("Tapped", "Profile tapped", "ok");
        }
        void OnTexasImageTapped()
        {
            Application.Current.MainPage.DisplayAlert("Tapped", "Number plate tapped", "ok");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
