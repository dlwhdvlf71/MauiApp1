using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public class BoxViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _width = 50;
        public int width
        {
            get { return _width; }
            set
            {
                if(_width != value)
                {
                    _width = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("width"));
                }
            }
        }

        private int _height = 50;
        public int height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("height"));
                }
            }
        }

        private int _cornerRadius = 0;
        public int cornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                if (_cornerRadius != value)
                {
                    _cornerRadius = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("cornerRadius"));
                }
            }
        }
    }
}
