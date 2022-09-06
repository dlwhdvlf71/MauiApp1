using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Class
{
    public class ColorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Color color;

        private float hue;
        private float saturation;
        private float luminosity;

        public float Hue
        {
            get => this.hue;

            set
            {
                if(this.hue != value)
                {
                    Color = Color.FromHsla(value, saturation, luminosity);
                }
            }
        }

        public float Saturation
        {
            get => this.saturation;

            set
            {
                if (this.saturation != value)
                {
                    Color = Color.FromHsla(this.hue, value, luminosity);
                }
            }
        }

        public float Luminosity
        {
            get => this.luminosity;

            set
            {
                if (this.luminosity != value)
                {
                    Color = Color.FromHsla(this.hue, saturation, value);
                }
            }
        }
    
        public Color Color
        {
            get => color;

            set 
            {
                if(value != color)
                {
                    color = value;

                    this.hue = value.GetHue();
                    this.saturation = value.GetSaturation();
                    this.luminosity = value.GetLuminosity();

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Saturation"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Luminosity"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Color"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
                }
            }
        }
    }
}
