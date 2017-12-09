using System.ComponentModel;
using System.Runtime.CompilerServices;
using CntApp.Utilities;

namespace CntApp.Domains.MyProfile
{
    public class MyProfileViewModel : INotifyPropertyChanged
    {
        private string _imageFilePath, _fullName, _nickname, _mobile, _email;

        public string ImageFilePath
        {
            get => _imageFilePath;
            set
            {
                _imageFilePath = value;
                OnPropertyChanged(nameof(ImageFilePath));
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string Nickname
        {
            get => _nickname;
            set
            {
                _nickname = value;
                OnPropertyChanged(nameof(Nickname));
            }
        }

        public string Mobile
        {
            get => _mobile;
            set
            {
                _mobile = value;
                OnPropertyChanged(nameof(Mobile));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}