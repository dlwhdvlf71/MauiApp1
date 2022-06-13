using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime currentTime
        {
            get
            {
                return this.dateTime;
            }

            private set
            {
                if (this.dateTime != value)
                {
                    this.dateTime = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("currentTime"));
                    }
                }
            }
        }

        public ClockViewModel()
        {
            this.dateTime = DateTime.Now;

            Timer timer = new Timer(new TimerCallback((s) => this.currentTime = DateTime.Now), null, 0, 1000);
        }

    }
}
