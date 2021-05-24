using System.ComponentModel;
using System.Runtime.CompilerServices;
using Interfaces;
using System.Runtime.Serialization;

namespace Models
{

    [DataContract]
    [KnownType(typeof(IShell))]
    public class Shell : IShell, INotifyPropertyChanged
    {
        string _statusText;
        string _fontText;
        bool _statusExecutable;
        bool _isExecuting;
        public string StatusText
        {
            get => _statusText;
            set
            {
                _statusText = value;
                OnPropertyChanged();
            }
        }
        public string FontText
        {
            get => _fontText;
            set
            {
                _fontText = value;
                OnPropertyChanged();
            }
        }
        [DataMember]
        public bool StatusExecutable
        {
            get => _statusExecutable;
            set
            {
                _statusExecutable = value;
                OnPropertyChanged();
            }
        }
        public bool IsExecuting
        {
            get => _isExecuting;
            set
            {
                _isExecuting = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
